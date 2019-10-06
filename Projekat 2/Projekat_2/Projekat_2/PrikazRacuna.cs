using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_2
{
    public partial class PrikazRacuna : Form
    {
        string imeForme;
        Baza konekcija;
        List<Racun> listaRacuna;
        public PrikazRacuna(string Forma)
        {
            InitializeComponent();
            konekcija = new Baza();
            listaRacuna = new List<Racun>();
            imeForme = Forma;
        }

        private void PrikazRacuna_Load(object sender, EventArgs e)
        {
          
            try
            {
                konekcija.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = konekcija.Konekcija;
                cmd.CommandText = "SELECT * FROM Racun";

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Racun r = new Racun();
                    r.Id_Racun = Int32.Parse(reader["id_racun"].ToString());
                    r.Cena =Convert.ToDouble(reader["cena"].ToString());
                    r.Datum = DateTime.Parse(reader["datum"].ToString());
                    r.Vreme = DateTime.Parse(reader["vreme"].ToString());
                   
                    listaRacuna.Add(r);
                }
               // dataGridView1.DataSource = listaRacuna;
               
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

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Racun> listaNadjenihRacuna = new List<Racun>();
            listaNadjenihRacuna.Clear();
            
            for (int i=0; i<listaRacuna.Count; i++)
            {
                if(listaRacuna[i].Datum>dateTimePicker1.Value && listaRacuna[i].Datum < dateTimePicker2.Value)
                {
                    listaNadjenihRacuna.Add(listaRacuna[i]);
                }
            }
            if (listaNadjenihRacuna.Count == 0)
            {
                MessageBox.Show("Nema pronadjenih racuna!");
                dataGridView1.DataSource = null;
            }
            else
            {
                if (dataGridView1.DataSource == null)
                {
                    dataGridView1.DataSource = listaNadjenihRacuna;
                    dataGridView1.Columns[3].DefaultCellStyle.Format = "HH:mm";
                }
            }
        }

      
        /*

        public void TraceMessage(string message,
                [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
                [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
                [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
           MessageBox.Show("message: " + message);
           MessageBox.Show("member name: " + memberName);
           MessageBox.Show("source file path: " + sourceFilePath);
           MessageBox.Show("source line number: " + sourceLineNumber);
        }
        public void DoProcessing()
        {
            TraceMessage("Something happened.");
        }*/

        private void btnZatvori_Click(object sender, EventArgs e)
        {

        }

        private void PrikazRacuna_FormClosing(object sender, FormClosingEventArgs e)
        {
          if (imeForme == "Kupovina") {
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
           
        }
    }
}
