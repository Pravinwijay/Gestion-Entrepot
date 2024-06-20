using GesEntrepotBO;
using GesEntrepotDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEntrepotBLL
{
    public class EntrepriseManager
    {
        private static EntrepriseManager uneInstance;

        // Cette méthode crée un objet de la classe ClientManager, s'il n'existe pas déja un, puis retourne la ref à cet objet
        public static EntrepriseManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EntrepriseManager();
            }
            return uneInstance;
        }

        // Le constructeur par défaut est privé : il ne sera donc pas possible de créer un obj à l'extérieur de la classe avec l'instruction new...
        private EntrepriseManager()
        {
        }

        // Apl de la couche DAL pour créer une nvl entreprise
        public string CreerEntreprise(string sonNom, string sonRue, string sonMel, int inseeVille)
        {
            // Déclaration et création d'une variable MessageErreur
            string msgErreur = "";

            // Vérification : si le champ est vide --> message d'erreur
            if (sonNom == "")
                msgErreur = msgErreur + "\nle nom de l'entreprise";
            if (sonRue == "")
                msgErreur = msgErreur + "\nla rue";
            if (sonMel == "")
                msgErreur = msgErreur + "\nle mail de l'entreprise";

            // S'il n'y a pas de msg d'erreur --> on crée l'objet
            if (msgErreur != "")
                return "Veuillez saisir " + msgErreur;

            // Création d'un objet de type Entreprise
            Entreprise lEntreprise;
            lEntreprise = new Entreprise(sonNom, sonRue, sonMel, new Ville(inseeVille, null, null));

            // La méthode retourne un string
            string msgRetourne = EntrepriseDAO.GetInstance().AjoutEntreprise(lEntreprise);
            return msgRetourne;
        }

        // Apl de la couche DAL pour récupérer une collection des entreprises
        public List<Entreprise>GetLesEntreprises()
        {
            return EntrepriseDAO.GetInstance().GetEntreprises();
        }

        // Apl de la couche DAL pour récupérer une entreprise
        public Entreprise GetUneEntreprise(int idEntreprise)
        {
            Entreprise lEntreprise = new Entreprise(idEntreprise);
            return EntrepriseDAO.GetInstance().GetUneEntreprise(lEntreprise);
        }

        // Apl de la couche DAL pour supprimer l'entreprise sélectionnée
        public string SupprEntreprise(int idEntreprise)
        {
            Entreprise lEntreprise = new Entreprise(idEntreprise);
            string msgRetourne = EntrepriseDAO.GetInstance().SupprEntreprise(lEntreprise);
            return EntrepriseDAO.GetInstance().SupprEntreprise(lEntreprise);
        }

        // Apl de la couche DAL pour modifier les caractéristiques de l'entreprise sélectionnée
        public string ModifEntreprise(int sonID, string sonNom, string sonRue, string sonMel, int inseeVille)
        {
            Entreprise lEntreprise = new Entreprise(sonID, sonNom, sonRue, sonMel, new Ville(inseeVille, null, null));
            string msgRetourne = EntrepriseDAO.GetInstance().ModifEntreprise(lEntreprise);
            return EntrepriseDAO.GetInstance().ModifEntreprise(lEntreprise); 
        }
    }
}
