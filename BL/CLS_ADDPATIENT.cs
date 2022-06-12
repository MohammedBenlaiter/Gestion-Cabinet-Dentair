using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   // This is what I used for sql
using System.Data;             // This is what I used for sql

namespace Gestion_Cabinet_Dentair.BL
{
    class CLS_ADDPATIENT
    {
        public void ADD_PATIENT(string Nom,string Prenom,string Sexe , DateTime DateDeNaissance , string LieuDeNaissance , string Adresse , string @NumeroDeTelephone , string Email , string RaisonDeVenir , string TypeDePaiement) // This method for add new patient 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); // Create an object from DAL 
            DAL.Open();
            
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@Nom", SqlDbType.VarChar, 15);
            param[0].Value = Nom;

            param[1] = new SqlParameter("@Prenom", SqlDbType.VarChar, 15);
            param[1].Value = Prenom;

            param[2] = new SqlParameter("@Sexe", SqlDbType.VarChar, 1);
            param[2].Value = Sexe;

            param[3] = new SqlParameter("@DateDeNaissance", SqlDbType.Date);
            param[3].Value = DateDeNaissance;

            param[4] = new SqlParameter("@LieuDeNaissance", SqlDbType.VarChar, 20);
            param[4].Value = LieuDeNaissance;
            
            param[5] = new SqlParameter("@Adresse", SqlDbType.VarChar, 40);
            param[5].Value = Adresse;

            param[6] = new SqlParameter("@NumeroDeTelephone", SqlDbType.VarChar, 15);
            param[6].Value = NumeroDeTelephone;

            param[7] = new SqlParameter("@Email", SqlDbType.VarChar, 40);
            param[7].Value = Email;

            param[8] = new SqlParameter("@RaisonDeVenir", SqlDbType.VarChar, 20);
            param[8].Value = RaisonDeVenir;

            param[9] = new SqlParameter("@TypeDePaiement", SqlDbType.VarChar, 20);
            param[9].Value = TypeDePaiement;

            DAL.ExecuteCommand("ADD_PATIENT", param);
            DAL.Close();
        }
    }
}
