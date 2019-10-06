using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_2
{
    class Racun
    {
        static int brojac = 1;
        private int id_racun=brojac++;
        private double cena;
        private DateTime datum;
        private DateTime vreme;


        public Racun()
        {

        }
        public Racun(double cena, DateTime datum, DateTime vreme)
        {
            this.id_racun = id_racun++;
            this.cena = cena;
            this.datum = datum;
            this.vreme = vreme;
        }

        public int Id_Racun
        {
            get
            {
                return this.id_racun;
            }
            set
            {
                this.id_racun = value;
            }
        }

        public double Cena
        {
            get
            {
                return this.cena;
            }
            set
            {
                this.cena = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return this.datum;
            }
            set
            {
                this.datum = value;
            }
        }

        public DateTime Vreme
        {
            get
            {
                return this.vreme;
            }
            set
            {
                this.vreme = value;
            }
        }

        public override string ToString()
        {
            return id_racun + "\n" + cena + "\n" +datum+"\n"+vreme;
        }
    }
}
