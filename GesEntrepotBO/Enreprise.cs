using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEntrepotBO
{
    public class Entreprise
    {
        private int id;
        private string nom;
        private string rue;
        private string mel;
        private Ville ville;

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

        public string Rue
        {
            get { return rue; }
            set { rue = value; }
        }

        public string Mel
        {
            get { return mel; }
            set { mel = value; }
        }

        public Ville Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        public string NomVille { get => ville.NomVille; }

        public Entreprise(int id, string nom, string rue, string mel, Ville ville)
        {
            this.id = id;
            this.nom = nom;
            this.rue = rue;
            this.mel = mel;
            this.ville = ville;
        }

        public Entreprise(string nom, string rue, string mel, Ville ville)
        {
            this.nom = nom;
            this.rue = rue;
            this.mel = mel;
            this.ville = ville;
        }

        public Entreprise(int id)
        {
            this.id = id;
        }

        public Entreprise(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public Entreprise(int id, string nom, string rue, string mel)
        {
            this.id = id;
            this.nom = nom;
            this.rue = rue;
            this.mel = mel;
        }
    }
}
