using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   // This is what I used for sql
using System.Data;             // This is what I used for sql

namespace Gestion_Cabinet_Dentair.BL
{
    class CLS_USER_MANAGEMENT
    {
        public void ADD_USER(string Nom, string Prenom,string NomDutilisateur, string MotDePasse, string TypeDutilisateur) // This method for add new user 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Nom", SqlDbType.VarChar,20);
            param[0].Value = Nom;

            param[1] = new SqlParameter("@Prenom", SqlDbType.VarChar,20);
            param[1].Value = Prenom;

            param[2] = new SqlParameter("@NomDutilisateur", SqlDbType.VarChar,20);
            param[2].Value = NomDutilisateur;

            param[3] = new SqlParameter("@MotDePasse", SqlDbType.VarChar,30);
            param[3].Value = MotDePasse;

            param[4] = new SqlParameter("@TypeDutilisateur", SqlDbType.VarChar,10);
            param[4].Value = TypeDutilisateur;

            DAL.ExecuteCommand("ADD_USER", param);
            DAL.Close();
        }
        public void DELETE_USER(string Utilisateur_ID) // This method for delete user 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Utilisateur_ID",SqlDbType.VarChar,50);
            param[0].Value = Utilisateur_ID;
            DAL.ExecuteCommand("DELETE_USER", param);
            DAL.Close();
        }
        public void UPDATE_USER(int Utilisateur_ID, string Nom, string Prenom, string NomDutilisateur,string MotDePasse, string TypeDutilisateur) // This method for updates useres
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("Utilisateur_ID", SqlDbType.Int);
            param[0].Value = Utilisateur_ID;

            param[1] = new SqlParameter("@Nom", SqlDbType.VarChar, 20);
            param[1].Value = Nom;

            param[2] = new SqlParameter("@Prenom", SqlDbType.VarChar, 20);
            param[2].Value = Prenom;

            param[3] = new SqlParameter("@NomDutilisateur", SqlDbType.VarChar,20);
            param[3].Value = NomDutilisateur;

            param[4] = new SqlParameter("@MotDePasse", SqlDbType.VarChar,30);
            param[4].Value = MotDePasse;

            param[5] = new SqlParameter("@TypeDutilisateur", SqlDbType.VarChar,10);
            param[5].Value = TypeDutilisateur;

            DAL.ExecuteCommand("UPDATE_USER", param);
            DAL.Close();
        }
    }
}
