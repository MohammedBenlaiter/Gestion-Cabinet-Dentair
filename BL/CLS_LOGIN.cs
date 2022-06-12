using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   // This is what I used for sql
using System.Data;             // This is what I used for sql

namespace Gestion_Cabinet_Dentair.BL
{
    class CLS_LOGIN
    {
        public DataTable LOGIN(string NomDutilisateur, string MotDePasse) // This class enables us to log in
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            SqlParameter[] param = new SqlParameter[2];   // Create an object from SqlParameter 

            param[0] = new SqlParameter("@NomDutilisateur", SqlDbType.VarChar, 20);
            param[0].Value = NomDutilisateur;

            param[1] = new SqlParameter("@MotDePasse", SqlDbType.VarChar, 30);
            param[1].Value = MotDePasse;

            //DAL.Open();
            DataTable Dt = new DataTable();    // Create an object Dt from DataTable
            Dt = DAL.SelectData("SP_LOGIN", param);  // Dt Get user information from SelectData method
            DAL.Close();
            return Dt;
            
        }
        public DataTable GET_USER_TYPE(string NomDutilisateur)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@NomDutilisateur",SqlDbType.VarChar,10);
            param[0].Value = NomDutilisateur;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_USER_TYPE", param);

            return Dt;
            DAL.Close();
        }
    }
}
