using GesClientDAL;
using GesEntrepotBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEntrepotDAL
{
    public class VilleDAO
    {
        private static VilleDAO uneInstance;

        // Cette méthode crée un obj de la classe VilleDAO s'il n'existe pas déja un, puis retourne la ref à cet obj
        public static VilleDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new VilleDAO();
            }
            return uneInstance;
        }

        // Le constructeur par défaut est privé : il ne sera donc pas possible de créer un obj à l'extérieur de la classe avec l'instruction new...
        private VilleDAO()
        {
        }

        // La méthode GetClients retourne une collection contenant les clients
        public List<Ville> GetVilles()
        {
            // Déclaration des variables
            int insee;
            string codePostal;
            string nomVille;

            // Création de la collection
            List<Ville> lesVilles = new List<Ville>();

            // Objet de type SqlCommand qui va contenir la requête SQL permettant d'obetnir tous les caract des clients
            SqlCommand maCommand;

            // Création de l'objet contenant la requête (apl de la procédure stockée)
            maCommand = new SqlCommand("spGetLesVilles", Connexion.GetObjConnexion());

            // Procédure stockée : 
            maCommand.CommandType = CommandType.StoredProcedure;

            // Déclaration d'un objet permettant de lire les lignes retournées par la requête
            SqlDataReader reader;

            // Execution de la requête
            reader = maCommand.ExecuteReader();

            // Pour chq enreg du DataReader on crée un objet d'instance de CategorieSocioProfessionnelle que l'on ajt dans la collection lesCategoriesSocioPro
            while (reader.Read())
            {
                // Pour lire l'id
                insee = (int)reader["insee"];

                if (reader["nomVille"] == DBNull.Value)
                {
                    nomVille = default(string);
                }
                else
                {
                    nomVille = reader["nomVille"].ToString();
                }
                if (reader["codePostal"] == DBNull.Value)
                {
                    codePostal = default(string);
                }
                else
                {
                    codePostal = reader["codePostal"].ToString();
                }

                // Création d'une instance
                Ville uneVille = new Ville(insee, codePostal, nomVille);

                // Ajout de la categ à la liste
                lesVilles.Add(uneVille);
            }
            // On ferme le reader
            reader.Close();

            // On ferme la connexion
            Connexion.CloseConnexion();

            // On retourne la liste
            return lesVilles;

        }
    }
}
