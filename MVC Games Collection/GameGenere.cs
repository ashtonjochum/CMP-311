using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Games_Collection
{
    class GameGenere
    {
        private string genere;
        private string ageRange;

        public GameGenere()
        {
            genere = "";
            ageRange = "";
        }

        public GameGenere(string genereIn, string ageRangeIn)
        {
            genere = genereIn;
            ageRange = ageRangeIn;
        }

        public string Genere
        {
            get { return genere; }
            set { genere = value; }
        }
        public string AgeRange
        {
            get { return ageRange; }
            set { ageRange = value; }
        }

        public override string ToString()
        {
            return "Genere: " + this.Genere + " Ages: " + this.AgeRange;
        }
    }
}
