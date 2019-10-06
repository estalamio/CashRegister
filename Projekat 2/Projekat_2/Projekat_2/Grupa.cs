using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_2
{
    class Grupa
    {
        private int id_grupa;
        private string naziv;

        public Grupa()
        {

        }
        public Grupa(int id_grupa, string naziv)
        {
            this.id_grupa = id_grupa;
            this.naziv = naziv;
        }

        public int Id_Grupa
        {
            get
            {
                return this.id_grupa;
            }
            set
            {
                this.id_grupa = value;
            }
        }

        public string Naziv
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

        public override string ToString()
        {
            return this.naziv;
        }
    }
}
