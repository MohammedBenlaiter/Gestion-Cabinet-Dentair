using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   // This is what I used for sql
using System.Data;             // This is what I used for sql

namespace Gestion_Cabinet_Dentair.BL
{
    class CLS_PAY
    {
        public void ADD_PAY(int Patient_ID, int PaymentComplet) // This method for add new payment 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Patient_ID", SqlDbType.Int);
            param[0].Value = Patient_ID;

            param[1] = new SqlParameter("@PaymentComplet", SqlDbType.Int);
            param[1].Value = PaymentComplet;

            DAL.ExecuteCommand("ADD_PAY", param);
            DAL.Close();
        }
        public DataTable SHOW_PAY(int Patient_ID)    // This method for show rdv from patient ID
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Patient_ID", SqlDbType.Int);
            param[0].Value = Patient_ID;

            DataTable Dt = new DataTable();
            //DAL.ExecuteCommand("SHOW_MEDICAMENT_FOR_CONSULT", param);
            Dt = DAL.SelectData("SHOW_PAY", param);

            return Dt;
            DAL.Close();
        }
    }
}