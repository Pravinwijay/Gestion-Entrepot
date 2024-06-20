using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEntrepotBO
{
    public class CategProduit
    {
        private int id;
        private string libelle;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public CategProduit(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
    }
}
