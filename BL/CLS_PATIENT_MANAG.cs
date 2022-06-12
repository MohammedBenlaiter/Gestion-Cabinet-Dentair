using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   // This is what I used for sql
using System.Data;             // This is what I used for sql

namespace Gestion_Cabinet_Dentair.BL
{
    class CLS_PATIENT_MANAG
    {
        public DataTable GET_ALL_PATIENT()      // This method for select all patient from database 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_PATIENT", null);
            DAL.Close();
            return Dt;
        }
        public DataTable SEARCH_PATIENT(string search)      // This method for search patient from database 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ("search", SqlDbType.VarChar, 50);
            param[0].Value = search;
            Dt = DAL.SelectData("SEARCH_PATIENT",param);
            DAL.Close();
            return Dt;
        }
        public void DELETE_PATIENT(string Patient_ID) // This method for delete patient 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Patient_ID", SqlDbType.Int);
            param[0].Value = Patient_ID;
            DAL.ExecuteCommand("DELETE_PATIENT", param);
            DAL.Close();
        }
        public void UPDATE_PATIENT(int Patient_ID , string Nom, string Prenom, string Sexe, DateTime DateDeNaissance, string LieuDeNaissance, string Adresse, string @NumeroDeTelephone, string Email, string RaisonDeVenir, string TypeDePaiement) // This method for updates new patient 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("Patient_ID", SqlDbType.Int);
            param[0].Value = Patient_ID;

            param[1] = new SqlParameter("@Nom", SqlDbType.VarChar, 15);
            param[1].Value = Nom;

            param[2] = new SqlParameter("@Prenom", SqlDbType.VarChar, 15);
            param[2].Value = Prenom;

            param[3] = new SqlParameter("@Sexe", SqlDbType.VarChar, 1);
            param[3].Value = Sexe;

            param[4] = new SqlParameter("@DateDeNaissance", SqlDbType.Date);
            param[4].Value = DateDeNaissance;

            param[5] = new SqlParameter("@LieuDeNaissance", SqlDbType.VarChar, 20);
            param[5].Value = LieuDeNaissance;

            param[6] = new SqlParameter("@Adresse", SqlDbType.VarChar, 40);
            param[6].Value = Adresse;

            param[7] = new SqlParameter("@NumeroDeTelephone", SqlDbType.VarChar, 15);
            param[7].Value = NumeroDeTelephone;

            param[8] = new SqlParameter("@Email", SqlDbType.VarChar, 40);
            param[8].Value = Email;

            param[9] = new SqlParameter("@RaisonDeVenir", SqlDbType.VarChar, 20);
            param[9].Value = RaisonDeVenir;

            param[10] = new SqlParameter("@TypeDePaiement", SqlDbType.VarChar, 20);
            param[10].Value = TypeDePaiement;

            DAL.ExecuteCommand("UPDATE_PATIENT", param);
            DAL.Close();
        }
    }
}
