using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEntrepotBO
{

    public class ZoneStockage
    {
        private int id;
        private string nom;
        private CategProduit categProduit;
        private Emplacement emplacement;

        public ZoneStockage(int id, string nom, CategProduit categProduit, Emplacement emplacement)
        {
            this.id = id;
            this.nom = nom;
            this.categProduit = categProduit;
            this.emplacement = emplacement;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public CategProduit CategProduit
        {
            get { return categProduit; }
            set { categProduit = value; }
        }

        public Emplacement Emplacement
        {
            get { return emplacement; }
            set { emplacement = value; }
        }
    }
}

