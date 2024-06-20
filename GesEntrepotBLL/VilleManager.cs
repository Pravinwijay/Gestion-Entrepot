using GesEntrepotBO;
using GesEntrepotDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEntrepotBLL
{
    public class VilleManager
    {
        private static VilleManager uneInstance;

        // Cette méthode crée un obj de la classe VilleManager, s'il n'existe pas déja un, puis retourne la ref à cet obj
        public static VilleManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new VilleManager();
            }
            return uneInstance;
        }

        // Le constructeur par défaut est privé : il ne sera donc pas possible de créer un obj à l'extérieur de la classe avec l'instruction new...
        private VilleManager()
        {
        }

        // Apl de la couche DAL pour récupérer une collection de clients
        public List<Ville> GetVilles()
        {
            // Ici, on peut appliquer des règles métier
            return VilleDAO.GetInstance().GetVilles();
        }
    }
}
