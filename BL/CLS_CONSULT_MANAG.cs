using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   // This is what I used for sql
using System.Data;             // This is what I used for sql

namespace Gestion_Cabinet_Dentair.BL
{
    class CLS_CONSULT_MANAG
    {
        public DataTable GET_ALL_MEDICAMENT()      // This method for select all medicament from database 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_MEDICAMENT", null);
            DAL.Close();
            return Dt;
        }

        public  DataTable SHOW_MEDICAMENT_FOR_CONSULT(int Patient_ID,DateTime DateConsultation)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Patient_ID", SqlDbType.Int);
            param[0].Value = Patient_ID;

            param[1] = new SqlParameter("@DateConsultation", SqlDbType.DateTime);
            param[1].Value = DateConsultation;

            DataTable Dt = new DataTable();
            //DAL.ExecuteCommand("SHOW_MEDICAMENT_FOR_CONSULT", param);
            Dt = DAL.SelectData("SHOW_MEDICAMENT_FOR_CONSULT", param);

            return Dt;
            DAL.Close();
        }
        public DataTable SHOW_ALL_DATE_CONSULT(int Patient_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Patient_ID", SqlDbType.Int);
            param[0].Value = Patient_ID;

            DataTable Dt = new DataTable();
            //DAL.ExecuteCommand("SHOW_MEDICAMENT_FOR_CONSULT", param);
            Dt = DAL.SelectData("SHOW_ALL_DATE_CONSULT", param);

            return Dt;
            DAL.Close();
        }
        public DataTable SHOW_CONSULT_INF_FOR_CONSULT(DateTime DateConsultation)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@DateConsultation", SqlDbType.DateTime);
            param[0].Value = DateConsultation;

            DataTable Dt = new DataTable();
            //DAL.ExecuteCommand("SHOW_MEDICAMENT_FOR_CONSULT", param);
            Dt = DAL.SelectData("SHOW_CONSULT_INF_FOR_CONSULT", param);

            return Dt;
            DAL.Close();
        }

        public void ADD_CONSULT(int Patient_ID, string Diagnostic, string Traitement ,byte[] RadiologieMédicale, DateTime DateConsultation) // This method for add consult for validation 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Patient_ID", SqlDbType.Int);
            param[0].Value = Patient_ID;

            param[1] = new SqlParameter("@Diagnostic", SqlDbType.VarChar,20);
            param[1].Value = Diagnostic;

            param[2] = new SqlParameter("@Traitement", SqlDbType.VarChar,20);
            param[2].Value = Traitement;

            param[3] = new SqlParameter("@RadiologieMédicale", SqlDbType.Image);
            param[3].Value = RadiologieMédicale;

            param[4] = new SqlParameter("@DateConsultation", SqlDbType.DateTime);
            param[4].Value = DateConsultation;

            DAL.ExecuteCommand("ADD_CONSULT", param);
            DAL.Close();
        }
        public void ADD_CONSULT_DET(int Medicament_ID) // This method for add consult det for add medicament 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Medicament_ID", SqlDbType.Int);
            param[0].Value = Medicament_ID;

            DAL.ExecuteCommand("ADD_CONSULT_DET", param);
            DAL.Close();
        }
        public DataTable SHOW_RADIO_INF_FOR_CONSULT(DateTime DateConsultation)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@DateConsultation", SqlDbType.DateTime);
            param[0].Value = DateConsultation;

            DataTable Dt = new DataTable();
            //DAL.ExecuteCommand("SHOW_MEDICAMENT_FOR_CONSULT", param);
            Dt = DAL.SelectData("SHOW_RADIO_INF_FOR_CONSULT", param);

            return Dt;
            DAL.Close();
        }
        public void DELETE_CONSULT(string DateConsultation) // This method for delete MEDICAMENT 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DateConsultation", SqlDbType.VarChar, 50);
            param[0].Value = DateConsultation;
            DAL.ExecuteCommand("DELETE_CONSULT", param);
            DAL.Close();
        }
    }
}