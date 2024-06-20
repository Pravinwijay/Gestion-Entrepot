using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEntrepotBO
{
    public class ControleAPrevoir
    {
        private int id;
        private string commentaire;
        private TypeControle typeControle;
        private ZoneStockage zoneStockage;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }

        public TypeControle TypeControle
        {
            get { return typeControle; }
            set { typeControle = value; }
        }

        public ZoneStockage ZoneStockage
        {
            get { return zoneStockage; }
            set { zoneStockage = value; }
        }

        public ControleAPrevoir(int id, string commentaire, TypeControle typeControle, ZoneStockage zoneStockage)
        {
            this.id = id;
            this.commentaire = commentaire;
            this.typeControle = typeControle;
            this.zoneStockage = zoneStockage;
        }
    }
}
