using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   // This is what I used for sql
using System.Data;             // This is what I used for sql
using System.Windows.Forms;

namespace Gestion_Cabinet_Dentair.DAL
{
    class DataAccessLayer
    {
       
        SqlConnection sqlconnection;  // the connection object
        public DataAccessLayer()  // this constructor initialize the connection object
        {
            sqlconnection = new SqlConnection(@"Server=DESKTOP-SG9PKVR\SQLEXPRESS ; Database=GestionCabinetDentaire ; Integrated Security = true ");
        }
        public void Open() //Method to open the connection
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
        public void Close() //Method to close the connection
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        // Method To Read Data From database 
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();   // sqlcmd object 
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;  // CommandText Gets or sets the Transact-SQL statement
            sqlcmd.Connection = sqlconnection;
            if (param != null)  
            {
                for (int i = 0; i < param.Length; i++)
                {    
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);  // da is the link that have a result after execution sqlcmd 
            DataTable dt = new DataTable();    // dt have a result of execution sqlcmd
            da.Fill(dt);       // da's  fill in dt
            return dt;
        }  
        //Method to Insert , Update , and Delete Data From Database 
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();    // sqlcmd object
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;   // CommandText Gets or sets the Transact-SQL statement
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);  // Fill in the param if you find any parameter of one of them
            }
            sqlcmd.ExecuteNonQuery();  // Use this operation to execute any arbitrary SQL statements in SQL Server if you do not want any result set to be returned
        }
    }
}
