using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   // This is what I used for sql
using System.Data;             // This is what I used for sql

namespace Gestion_Cabinet_Dentair.BL
{
    internal class CLS_MEDICAMENT
    {
        public void ADD_MEDICAMENT(string Nom_medacement) // This method for add medicament 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Nom_medacement", SqlDbType.VarChar, 20);
            param[0].Value = Nom_medacement;

            DAL.ExecuteCommand("ADD_MEDICAMENT", param);
            DAL.Close();
        }
        public void DELETE_MEDICAMENT(string Medicament_ID) // This method for delete MEDICAMENT 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Medicament_ID", SqlDbType.VarChar,50);
            param[0].Value = Medicament_ID;
            DAL.ExecuteCommand("DELETE_MEDICAMENT", param);
            DAL.Close();
        }
        public DataTable GET_ALL_MEDICAMENT()      // This method for select all medicaments from database 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_MEDICAMENT", null);
            DAL.Close();
            return Dt;
        }
    }
}
