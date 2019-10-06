using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_2
{
    class Artikal
    {
        static int brojac = 1;
        private int id_artikla = brojac++;
        private String naziv;
        private double cena;
        private double popust;
        private int id_grupe;

        
        public Artikal()
        {

        }
        public Artikal(string naziv, double cena, double popust, int id_grupe)
        {
            this.id_artikla =id_artikla++;
            this.naziv = naziv;
            this.cena = cena;
            this.popust = popust;
            this.id_grupe = id_grupe;
        }


        public int Id_Grupe
        {
            get
            {
                return this.id_grupe;
            }
            set
            {
                this.id_grupe = value;
            }
        }
        public int Id_Artikla
        {
            get
            {
                return this.id_artikla;
            }
            set
            {
                this.id_artikla = value;
            }
        }
        public String Naziv
        {
            get
            {
                return this.naziv;
            }
            set
            {
                this.naziv = value;
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
        public double Popust
        {
            get
            {
                return this.popust;
            }
            set
            {
                this.popust = value;
            }
        }

        public override string ToString()
        {
            return this.naziv;
        }
    }
}
