using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEntrepotBO
{
    public class Habilitation
    {
        private int id;
        private DateTime dateDeb;
        private DateTime dateFin;
        private Entreprise entreprise;
        private TypeControle typeControle;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DateDeb
        {
            get { return dateDeb; }
            set { dateDeb = value; }
        }

        public DateTime DateFin
        {
            get { return dateFin; }
            set { dateFin = value; }
        }

        public Entreprise Entreprise
        {
            get { return entreprise; }
            set { entreprise = value; }
        }

        public TypeControle TypeControle
        {
            get { return typeControle; }
            set { typeControle = value; }
        }

        public Habilitation(int id, DateTime dateDeb, DateTime dateFin, Entreprise entreprise, TypeControle typeControle)
        {
            this.id = id;
            this.dateDeb = dateDeb;
            this.dateFin = dateFin;
            this.entreprise = entreprise;
            this.typeControle = typeControle;
        }
    }
}

