using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEntrepotBO
{

    public class Emplacement
    {
        private int id;
        private string batiment;
        private string rue;
        private int etage;
        private Ville ville;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Batiment
        {
            get { return batiment; }
            set { batiment = value; }
        }

        public string Rue
        {
            get { return rue; }
            set { rue = value; }
        }

        public int Etage
        {
            get { return etage; }
            set { etage = value; }
        }

        public Ville Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        public Emplacement(int id, string batiment, string rue, int etage, Ville ville)
        {
            this.id = id;
            this.batiment = batiment;
            this.rue = rue;
            this.etage = etage;
            this.ville = ville;
        }
    }
}
