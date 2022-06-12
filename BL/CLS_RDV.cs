using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   // This is what I used for sql
using System.Data;             // This is what I used for sql

namespace Gestion_Cabinet_Dentair.BL
{
    class CLS_RDV
    {
        public DataTable GET_ALL_DOCTORS()      // This method for select all doctors from database 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_DOCTORS", null);
            DAL.Close();
            return Dt;
        }
        public void ADD_RDV(int Patient_ID,int Utilisateur_ID,DateTime DateDeReservation,string HeureDeRendezVous, string RaisonDeVenir) // This method for add new rdv 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Patient_ID", SqlDbType.Int);
            param[0].Value = Patient_ID;

            param[1] = new SqlParameter("@Utilisateur_ID", SqlDbType.Int);
            param[1].Value = Utilisateur_ID;

            param[2] = new SqlParameter("@DateDeReservation", SqlDbType.Date);
            param[2].Value = DateDeReservation;

            param[3] = new SqlParameter("@HeureDeRendezVous",SqlDbType.VarChar,5);
            param[3].Value = HeureDeRendezVous;

            param[4] = new SqlParameter("@RaisonDeVenir", SqlDbType.VarChar,15);
            param[4].Value = RaisonDeVenir;
          
            DAL.ExecuteCommand("ADD_RDV", param);
            DAL.Close();
        }
        public void DELETE_RDV(string Rdv_ID) // This method for delete rdv 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Rdv_ID", SqlDbType.VarChar, 50);
            param[0].Value = Rdv_ID;
            DAL.ExecuteCommand("DELETE_RDV", param);
            DAL.Close();
        }
        public DataTable GET_ALL_RDV()      // This method for select all rdv from database 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_RDV", null);
            DAL.Close();
            return Dt;
        }
        public DataTable SEARCH_RDV(string search)      // This method for search rdv from database 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("search", SqlDbType.VarChar, 50);
            param[0].Value = search;
            Dt = DAL.SelectData("SEARCH_RDV", param);
            DAL.Close();
            return Dt;
        }
    }
}
