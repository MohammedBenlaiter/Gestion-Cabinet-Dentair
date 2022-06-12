using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   // This is what I used for sql
using System.Data;             // This is what I used for sql

namespace Gestion_Cabinet_Dentair.BL
{
    class CLS_DASHBOARD
    {
        public DataTable COUNT_PATIENT()      // This method for count patients
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("COUNT_PATIENT", null);
            DAL.Close();
            return Dt;
        }
        public DataTable COUNT_RDV()      // This method for count rdv
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("COUNT_RDV", null);
            DAL.Close();
            return Dt;
        }
        public DataTable COUNT_MEDECIN()      // This method for count medecin
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("COUNT_MEDECIN", null);
            DAL.Close();
            return Dt;
        }
    }
}
