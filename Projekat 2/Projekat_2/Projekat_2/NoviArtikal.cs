using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_2
{
    public partial class NoviArtikal : Form
    {
      
        Baza konekcija;
        List<Grupa> listaGrupa;
        Grupa g2 = new Grupa();
        ListViewItem lvi;
        BindingList<Artikal> listaArtikala;
        static int brojac = 1;
        int pozicija = brojac++;
        string imeForme;
        public NoviArtikal(string Forma)
        {
            InitializeComponent();
            konekcija = new Baza();
            listaGrupa=new List<Grupa>();
            listaArtikala = new BindingList<Artikal>();
            imeForme = Forma;
        }

        private void NoviArtikal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodavnicaDataSet.Artikal' table. You can move, or remove it, as needed.
            //   this.artikalTableAdapter.Fill(this.prodavnicaDataSet.Artikal);

            try
            {
                konekcija.OtvoriKonekciju();
                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.Connection = konekcija.Konekcija;
                cmd1.CommandText = @"SELECT * FROM Grupa";
                OleDbDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    Grupa g = new Grupa();
                    g.Id_Grupa = Int32.Parse(reader["id_grupe"].ToString());
                    g.Naziv = reader["naziv"].ToString();

                    listaGrupa.Add(g);
                }
                cbGrupe.DataSource = listaGrupa;
                cbGrupe.DisplayMember = "Naziv";
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.ZatvoriKonekciju();
            }


            try
            {
                konekcija.OtvoriKonekciju();
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = konekcija.Konekcija;

                cmd2.CommandText = @"SELECT * FROM Artikal";
                OleDbDataReader reader = cmd2.ExecuteReader();
                
                while (reader.Read())
                {
                    Artikal a = new Artikal();
                    a.Id_Artikla =Int32.Parse(reader["id_artikla"].ToString());
                    a.Naziv = reader["naziv"].ToString();
                    a.Cena = Int32.Parse(reader["cena"].ToString());
                    a.Popust = Int32.Parse(reader["popust"].ToString());
                    a.Id_Grupe = Int32.Parse(reader["id_grupe"].ToString());
                    listaArtikala.Add(a);
                }
                dataGridView1.DataSource = listaArtikala;
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.ZatvoriKonekciju();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            /* ProdavnicaDataSet.ArtikalRow red = ds.Artikal.NewArtikalRow();
             red.naziv = txtNazivProizvoda.Text;
             red.cena = Convert.ToInt32(txtCena.Text);
             red.popust = Convert.ToInt32(txtPopust.Text);
             red.id_grupe = Convert.ToInt32(textBox1.Text);
             ds.Artikal.AddArtikalRow(red);
             daArtikal.Update(ds.Artikal);
             daArtikal.Fill(ds.Artikal);


             dataGridView1.DataSource = ds.Artikal;*/
       
            try
            {

                foreach (Grupa g in listaGrupa)
                {
                    if (cbGrupe.SelectedValue.ToString().Equals(g.Naziv))
                    {
                        g2 = new Grupa(g.Id_Grupa, g.Naziv);
                    }
                }
                konekcija.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = konekcija.Konekcija;
                cmd.CommandText = @"INSERT INTO Artikal(naziv,cena,popust,id_grupe) VALUES(@naziv,@cena,@popust,@id_grupe)";
               
                cmd.Parameters.AddWithValue("naziv", txtNazivProizvoda.Text);
                cmd.Parameters.AddWithValue("cena", double.Parse(txtCena.Text));
                cmd.Parameters.AddWithValue("popust", double.Parse(txtPopust.Text));
                cmd.Parameters.AddWithValue("id_grupe", g2.Id_Grupa);

                Artikal a=new Artikal(txtNazivProizvoda.Text, double.Parse(txtCena.Text), double.Parse(txtPopust.Text),g2.Id_Grupa);

             

                int rezultat = cmd.ExecuteNonQuery();

                if (rezultat > 0)
                {
                    MessageBox.Show("Artikal je dodat u ponudu");
                    cbGrupe.ResetText();
                    txtNazivProizvoda.Clear();
                    txtCena.Clear();
                    txtPopust.Clear();
                }
                else
                {
                    MessageBox.Show("Greska");
                }

            }
            catch (Exception ex)
            {
                /*
                MessageBox.Show(ex.Message);*/
                MessageBox.Show("Polja nisu pravilno popunjena ili grupa nije izabrana!");
            }
            finally
            {
                konekcija.ZatvoriKonekciju();
            }

            

        }

        private void btnUkloniArtikal_Click(object sender, EventArgs e)
        {
            
            try
            {
                var itemToDelete = (Artikal)dataGridView1.SelectedRows[0].DataBoundItem;
                konekcija.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = konekcija.Konekcija;
                cmd.CommandText = @"DELETE FROM Artikal WHERE id_artikla=?";

                cmd.Parameters.AddWithValue("@id_artikla", itemToDelete.Id_Artikla);
                cmd.ExecuteNonQuery();

                var dataSource = (BindingList<Artikal>)dataGridView1.DataSource;
                //listaArtikala.RemoveAt(dataGridView1.SelectedRows[0].Index);
                dataSource.Remove(itemToDelete);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.ZatvoriKonekciju();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            PrikazRacuna frmPrikazRacuna = new PrikazRacuna(this.Name);
            frmPrikazRacuna.Show();
            this.Visible = false;
      
        }

        private void NoviArtikal_FormClosing(object sender, FormClosingEventArgs e)
        {
             if (imeForme =="Kupovina")
             {
                 Kupovina frmKupovina = new Kupovina();
                 frmKupovina.Show();
                 this.Visible = false;
             }
             if (imeForme == "NoviArtikal")
             {
                 NoviArtikal frmNoviArtikal = new NoviArtikal(this.Name);
                 frmNoviArtikal.Show();
                 this.Visible = false;
             }
             if (imeForme == "PrikazRacuna")
             {
                 Kupovina frmKupovina = new Kupovina();
                 frmKupovina.Show();
                 this.Visible = false;
             }
          
        }
    }
}
