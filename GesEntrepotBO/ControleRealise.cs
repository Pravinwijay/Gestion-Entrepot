using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEntrepotBO
{
    public class ControleRealise
    {
        private int id;
        private DateTime dateControle;
        private string resultat;
        private decimal montantHT;
        private Entreprise entreprise;
        private ZoneStockage zoneStockage;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DateControle
        {
            get { return dateControle; }
            set { dateControle = value; }
        }

        public string Resultat
        {
            get { return resultat; }
            set { resultat = value; }
        }

        public decimal MontantHT
        {
            get { return montantHT; }
            set { montantHT = value; }
        }

        public Entreprise Entreprise
        {
            get { return entreprise; }
            set { entreprise = value; }
        }

        public ZoneStockage ZoneStockage
        {
            get { return zoneStockage; }
            set { zoneStockage = value; }
        }

        public ControleRealise(int id, DateTime dateControle, string resultat, decimal montantHT, Entreprise entreprise, ZoneStockage zoneStockage)
        {
            this.id = id;
            this.dateControle = dateControle;
            this.resultat = resultat;
            this.montantHT = montantHT;
            this.entreprise = entreprise;
            this.zoneStockage = zoneStockage;
        }
    }
}
