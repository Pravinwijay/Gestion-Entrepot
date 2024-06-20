using GesClientDAL;
using GesEntrepotBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace GesEntrepotDAL
{
    public class EntrepriseDAO
    {
        private static EntrepriseDAO uneInstance;

        // Cette méthode crée un obj de la classe EntrepriseDAO s'il n'existe pas déja un, puis retourne la ref à cet obj
        public static EntrepriseDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EntrepriseDAO();
            }
            return uneInstance;
        }

        // Le constructeur par défaut est privé : il ne sera donc pas possible de créer un obj à l'extérieur de la classe avec l'instruction new...
        private EntrepriseDAO()
        {
        }

        #region Ajout entreprise
        // La méthode permettant d'AJOUTER une ENTREPRISE
        /// <summary>
        /// Permet l'ajout d'une entreprise
        /// </summary>
        /// <param name="uneEntreprise"></param>
        /// <returns></returns>
        public string AjoutEntreprise(Entreprise uneEntreprise)
        {
            try
            {
                // Objet de type SqlCommand qui va contenir la requête SQL
                SqlCommand maCommand;

                // Création de l'objet contenant la PROCEDURE et la CONNEXION 
                maCommand = new SqlCommand("spAjtEntreprise", Connexion.GetObjConnexion());

                // Procédure stockée : 
                maCommand.CommandType = CommandType.StoredProcedure;

                // La procédure comporte des paramètres : pour le nom
                maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[0].Value = uneEntreprise.Nom;

                // La procédure comporte des paramètres : pour la rue
                maCommand.Parameters.Add("rue", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[1].Value = uneEntreprise.Rue;

                // La procédure comporte des paramètres : pour le mel
                maCommand.Parameters.Add("mel", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[2].Value = uneEntreprise.Mel;

                // La procédure comporte des paramètres : pour la ville
                maCommand.Parameters.Add("numInsee", System.Data.SqlDbType.Int);
                maCommand.Parameters[3].Value = uneEntreprise.Ville.NumInsee;

                // Execution
                maCommand.ExecuteNonQuery();

                // Fermeture de la BD
                maCommand.Connection.Close();
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
            return "L'entreprise a été ajoutée !";
        }
        #endregion

        #region Liste des entreprises
        // La méthode GetEntreprise retourne une collection contenant les entreprises
        /// <summary>
        /// Permet d'obtenir la liste des villes
        /// </summary>
        /// <returns></returns>
        public List<Entreprise> GetEntreprises()
        {
            // Déclaration des variables
            int id;
            string nom;
            string rue;
            string mel;
            int inseeVille;
            string ville;

            // Création de la collection 
            List<Entreprise> lesEntreprises = new List<Entreprise>();

            // Objet de type SqlCommand qui va contenir la requête SQL permettant d'obetnir tous les caract des entreprises
            SqlCommand maCommand;

            // Création de l'objet contenant la requête (apl de la procédure stockée)
            maCommand = new SqlCommand("spGetLesEntreprises", Connexion.GetObjConnexion());

            // Procédure stockée : 
            maCommand.CommandType = CommandType.StoredProcedure;

            // Déclaration d'un objet permettant de lire les lignes retournées par la requête
            SqlDataReader reader;

            // Execution de la requête
            reader = maCommand.ExecuteReader();

            // Pour chq enreg du DataReader on crée un objet d'instance de Entreprise que l'on ajt dans la collection lesEntreprises
            while (reader.Read())
            {
                // Pour lire l'id etc...
                id = (int)reader["id"];
                inseeVille = (int)reader["numInsee"];

                if (reader["nom"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = reader["nom"].ToString();
                }
                if (reader["rue"] == DBNull.Value)
                {
                    rue = default(string);
                }
                else
                {
                    rue = reader["rue"].ToString();
                }
                if (reader["mel"] == DBNull.Value)
                {
                    mel = default(string);
                }
                else
                {
                    mel = reader["mel"].ToString();
                }
                if (reader["nomVille"] == DBNull.Value)
                {
                    ville = default(string);
                }
                else
                {
                    ville = reader["nomVille"].ToString();
                }

                // Création de l'instance contenant les caracts d'une enteprise
                Entreprise uneEntreprise = new Entreprise(id, nom, rue, mel, new Ville(inseeVille, null, ville));

                // Ajout de l'entreprise dans la collection
                lesEntreprises.Add(uneEntreprise);
            }

            // On ferme le reader
            reader.Close();

            // On ferme la connexion
            Connexion.CloseConnexion();

            // On retourne la collection
            return lesEntreprises;
        }
        #endregion

        #region Consultation des caracts d'une entreprise
        // Méthode permettant de séléctionner une Entreprise
        /// <summary>
        /// Permet d'afficher les caractéristiques d'une entreprise
        /// </summary>
        /// <param name="uneEntreprise"></param>
        /// <returns></returns>
        public Entreprise GetUneEntreprise(Entreprise uneEntreprise)
        {
            int id;
            string nom;
            string mel;
            int insee;
            string ville;
            string rue;
            Entreprise entRetournee = null;

            try
            {
                // Objet de type SqlCommand qui va contenir la requête SQL
                SqlCommand maCommand;

                // Création de l'objet contenant la PROCEDURE et la CONNEXION 
                maCommand = new SqlCommand("spGetUneEntreprise", Connexion.GetObjConnexion());

                // Procédure stockée : 
                maCommand.CommandType = CommandType.StoredProcedure;

                // La procédure comporte des paramètres : pour l'id
                maCommand.Parameters.Add("id", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[0].Value = uneEntreprise.Id;

                // Déclaration d'un objet permettant de lire les lignes retournées par la requête
                SqlDataReader reader;

                // Execution
                reader = maCommand.ExecuteReader();

                // on récupère l'entreprise returnée par la procédure stockée
                reader.Read();

                // Pour lire l'id etc..
                id = (int)reader["id"];
                insee = (int)reader["numInsee"];

                if (reader["nom"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = reader["nom"].ToString();
                }
                if (reader["mel"] == DBNull.Value)
                {
                    mel = default(string);
                }
                else
                {
                    mel = reader["mel"].ToString();
                }
                if (reader["rue"] == DBNull.Value)
                {
                    rue = default(string);
                }
                else
                {
                    rue = reader["rue"].ToString();
                }
                if (reader["nomVille"] == DBNull.Value)
                {
                    ville = default(string);
                }
                else
                {
                    ville = reader["nomVille"].ToString();
                }

                // Création d'une instance pour l'entreprise retournée
                entRetournee = new Entreprise(id, nom, rue, mel, new Ville(insee, ville));

                // Fermeture de la BD
                maCommand.Connection.Close();
            }
            catch (SqlException exc)
            {
                //return exc.Message;
            }
            return entRetournee;
        }
        #endregion

        #region Suppression d'une entreprise
        // Méthode permattant la suppression de l'entreprise
        /// <summary>
        /// Permet la suppression d'une entreprise
        /// </summary>
        /// <param name="uneEntreprise"></param>
        /// <returns></returns>
        public string SupprEntreprise(Entreprise uneEntreprise)
        {
            try
            {
                // Objet de type SqlCommand qui va contenir la requête SQL
                SqlCommand maCommand;

                // Création de l'objet contenant la PROCEDURE et la CONNEXION 
                maCommand = new SqlCommand("spSupprEntreprise", Connexion.GetObjConnexion());

                // Procédure stockée : 
                maCommand.CommandType = CommandType.StoredProcedure;

                // La procédure comporte un paramètre ID et on lui fournit sa valeur : 
                maCommand.Parameters.Add("id", System.Data.SqlDbType.Int);
                maCommand.Parameters[0].Value = uneEntreprise.Id;

                // Execution
                maCommand.ExecuteNonQuery();

                // Fermeture de la BD
                maCommand.Connection.Close();
            }
            catch (Exception exc)
            {
                return exc.Message;
            }

            // On retourne un message d'erreur
            return "L'entreprise a été supprimée !";
        }
        #endregion

        #region Modifications des caracts d'une entreprise
        // Méthode permettant de MODIFIER une ENTREPRISE
        /// <summary>
        /// Permet de modifier les caractéristiques d'une entreprise
        /// </summary>
        /// <param name="uneEntreprise"></param>
        /// <returns></returns>
        public string ModifEntreprise(Entreprise uneEntreprise)
        {
            try
            {
                // Objet de type SqlCommand qui va contenir la requête SQL
                SqlCommand maCommand;

                // Création de l'objet contenant la PROCEDURE et la CONNEXION 
                maCommand = new SqlCommand("spModifEntreprise", Connexion.GetObjConnexion());

                // Procédure stockée : 
                maCommand.CommandType = CommandType.StoredProcedure;

                // La procédure comporte des paramètres et on leurs fournit une valeur : 
                maCommand.Parameters.Add("id", System.Data.SqlDbType.Int);
                maCommand.Parameters[0].Value = uneEntreprise.Id;

                maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[1].Value = uneEntreprise.Nom;

                maCommand.Parameters.Add("rue", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[2].Value = uneEntreprise.Rue;

                maCommand.Parameters.Add("mel", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[3].Value = uneEntreprise.Mel;

                maCommand.Parameters.Add("numInsee", System.Data.SqlDbType.Int);
                maCommand.Parameters[4].Value = uneEntreprise.Ville.NumInsee;

                // Execution
                maCommand.ExecuteNonQuery();

                // Fermeture de la BD
                maCommand.Connection.Close();
            }
            catch (Exception exc)
            {
                return exc.Message;
            }

            // On retourne un message d'erreur
            return "L'entreprise a été modifiée !";
        } 
        #endregion
    }
}