using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_2
{
    public partial class Kupovina : Form
    {
        Baza konekcija;
        List<Grupa> listaGrupa;
        List<Artikal> listaArtikala;
        List<Artikal> listaNadjenihArtikala;
        List<Racun> racun;
        Grupa g;
        PrikazRacuna frmPrikazRacuna;
        NoviArtikal frmNoviArtikal;

        public Kupovina()
        {
            InitializeComponent();
            konekcija = new Baza();
            listaGrupa = new List<Grupa>();
            listaArtikala = new List<Artikal>();
            listaNadjenihArtikala = new List<Artikal>();
            racun = new List<Racun>();
            g = new Grupa();
            frmPrikazRacuna = new PrikazRacuna(this.Name);
            frmNoviArtikal = new NoviArtikal(this.Name);
           
  
        }
        private void Kupovina_Load(object sender, EventArgs e)
        {
            
            txtUkupnoZaNaplatu.Enabled = false;
            try
            {
                konekcija.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = konekcija.Konekcija;
                cmd.CommandText = "SELECT * FROM Grupa";

                OleDbDataReader reader = cmd.ExecuteReader();
               

                while (reader.Read())
                {
                    Grupa g = new Grupa();
                    g.Naziv = reader["naziv"].ToString();
                    g.Id_Grupa = Int32.Parse(reader["id_grupe"].ToString());
                    listaGrupa.Add(g);
                }

                cbKategorija.DataSource = listaGrupa;

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.ZatvoriKonekciju();
            }
            
            try
            {
                konekcija.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = konekcija.Konekcija;
                cmd.CommandText = "SELECT * FROM Artikal";

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Artikal a = new Artikal();
                    a.Id_Artikla = Int32.Parse(reader["id_artikla"].ToString());
                    a.Naziv = reader["naziv"].ToString();
                    a.Cena = Int32.Parse(reader["cena"].ToString());
                    a.Popust = Int32.Parse(reader["popust"].ToString());
                    a.Id_Grupe = Int32.Parse(reader["id_grupe"].ToString());
                    listaArtikala.Add(a);
                }

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
        
        private void cbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaNadjenihArtikala.Clear();

         
            for (int i=0; i < listaGrupa.Count; i++)
            {
               
                if (cbKategorija.SelectedItem.ToString()==(listaGrupa[i].Naziv))
                {
                    g.Id_Grupa = listaGrupa[i].Id_Grupa;
                }
            }

            for(int i=0; i<listaArtikala.Count; i++)
            {
                if (listaArtikala[i].Id_Grupe.Equals(g.Id_Grupa))
                {
                    listaNadjenihArtikala.Add(listaArtikala[i]);
                }
            }
            if (listaNadjenihArtikala.Count == 0)
            {
                dataGridView1.DataSource = null;
            }

        
            dataGridView1.DataSource = null;
            if (listaNadjenihArtikala.Count != 0)
            {
                dataGridView1.DataSource = listaNadjenihArtikala;

                dataGridView1.Columns["id_grupe"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["id_artikla"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["naziv"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["cena"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["popust"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns["id_grupe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["id_artikla"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["naziv"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["cena"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["popust"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns["id_grupe"].Width = 70;
                dataGridView1.Columns["id_artikla"].Width = 73;
                dataGridView1.Columns["naziv"].Width = 250;
                dataGridView1.Columns["cena"].Width = 85;
                dataGridView1.Columns["popust"].Width = 85;
            }
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {


           /* foreach(DataGridViewColumn c in dataGridView1.Columns)
            {
                dataGridView2.Columns.Add(c.Clone() as DataGridViewColumn);
            }*/
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                int index = dataGridView2.Rows.Add();
                //dataGridView2.Rows[index].Cells[0].Value = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
                dataGridView2.Rows[index].Cells[0].Value = dataGridView1.SelectedRows[i].Cells[2].Value.ToString();
                //dataGridView2.Rows[index].Cells[2].Value = dataGridView1.SelectedRows[i].Cells[2].Value.ToString();
                dataGridView2.Rows[index].Cells[1].Value = nudKolicina.Value;
                dataGridView2.Rows[index].Cells[2].Value = double.Parse(dataGridView1.SelectedRows[i].Cells[3].Value.ToString())*Convert.ToDouble(nudKolicina.Value);
            }
           

            int suma=0;

            foreach(DataGridViewRow d in dataGridView2.Rows)
            {
    
                    int dIndex = d.Index;
                  
                    suma = suma + Convert.ToInt32(dataGridView2.Rows[dIndex].Cells[2].Value);
                
            }

            txtUkupnoZaNaplatu.Text=suma.ToString();
        }

        private void btnUkloniArtikal_Click(object sender, EventArgs e)
        {
            int suma = 0;

            foreach (DataGridViewRow d in dataGridView2.Rows)
            {

                int dIndex = d.Index;

                suma = suma + Convert.ToInt32(dataGridView2.Rows[dIndex].Cells[2].Value);

            }

            txtUkupnoZaNaplatu.Text = suma.ToString();
            /*
            var itemToDelete = (Artikal)dataGridView2.SelectedRows[0].DataBoundItem;
            var dataSource = (BindingList<Artikal>)dataGridView2.R;
            dataSource.Remove(itemToDelete);*/
            int redovi = Convert.ToInt32(dataGridView2.SelectedRows.Count);
            if(redovi>0)
            dataGridView2.Rows.Remove(dataGridView2.SelectedRows[0]);

        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
         //   Racun r = new Racun(Convert.ToDouble(txtUkupnoZaNaplatu.Text),DateTime.Parse(DateTime.Now.ToShortDateString()),DateTime.Parse(DateTime.Now.ToLocalTime().ToShortTimeString()));
         //  racun.Add(r);

            try
            {
                konekcija.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = konekcija.Konekcija;

                if (Int32.Parse(txtUkupnoZaNaplatu.Text)>0)
                {
                    cmd.CommandText = @"INSERT INTO Racun(cena,datum,vreme) VALUES(@cena,@datum,@vreme)";
                    cmd.Parameters.AddWithValue("cena", double.Parse(txtUkupnoZaNaplatu.Text));
                    cmd.Parameters.AddWithValue("datum", DateTime.Parse(DateTime.Now.ToShortDateString()));
                    cmd.Parameters.AddWithValue("vreme", DateTime.Parse(DateTime.Now.ToShortTimeString()));
                    int rezultat = cmd.ExecuteNonQuery();
                    if (rezultat > 0)
                    {
                        MessageBox.Show("Uspesno upisano u bazu!");
                    }
                }
                if (txtUkupnoZaNaplatu.Text == "" || Int32.Parse(txtUkupnoZaNaplatu.Text) == 0 || txtUkupnoZaNaplatu.TextLength ==0)
                {
                    MessageBox.Show("Racun ne moze biti prazan");
                }
      
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

        private void btnStorniraj_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            txtUkupnoZaNaplatu.Clear();
        }

        private void btnNoviArtikal_Click(object sender, EventArgs e)
        {

            frmNoviArtikal.Show();
            this.Visible = false;
        }

        private void btnPrikazSvihRacuna_Click(object sender, EventArgs e)
        {
            
            frmPrikazRacuna.Show();
            this.Visible = false;
        }

        private void Kupovina_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmNoviArtikal.Visible == false && frmPrikazRacuna.Visible == false)
            {
                frmNoviArtikal.Close();
                frmPrikazRacuna.Close();
            }
            try
            {
                foreach (Process proc in Process.GetProcessesByName("Projekat_2"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStorniraj_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            txtUkupnoZaNaplatu.Clear();
        }
    }
}
