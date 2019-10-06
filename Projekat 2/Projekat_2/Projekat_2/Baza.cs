using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_2
{
    class Baza
    {
        OleDbConnection konekcija;

        public Baza()
        {
            this.konekcija = new OleDbConnection();
            konekcija.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\User\Google Drive (mihajilomrsevic@gmail.com)\Druga godina\Vezbe\Cetvrti semestar\TVP\Projekat 2\Projekat_2\Projekat_2\Prodavnica.mdb";
        }
        public void OtvoriKonekciju()
        {
            konekcija.Open();
        }
        public void ZatvoriKonekciju()
        {
            konekcija.Close();
        }
        public OleDbConnection Konekcija
        {
            get
            {
                return this.konekcija;
            }
            set
            {
                this.konekcija = value;
            }
        }
    }
}
