using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEntrepotBO
{
    public class Ville
    {
        private int numInsee;
        private string nomVille;
        private string codePostal;

        public Ville(string codePostal, string nomVille)
        {
            this.codePostal = codePostal;
            this.nomVille = nomVille;
        }

        public Ville(int numInsee, string nomVille)
        {
            this.numInsee = numInsee;
            this.nomVille = nomVille;
        }

        public Ville(int numInsee, string codePostal, string nomVille)
        {
            this.numInsee = numInsee;
            this.codePostal = codePostal;
            this.nomVille = nomVille;
        }

        public int NumInsee
        {
            get { return numInsee; }
            set { numInsee = value; }
        }

        public string CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }

        public string NomVille
        {
            get { return nomVille; }
            set { nomVille = value; }
        }
    }
}
