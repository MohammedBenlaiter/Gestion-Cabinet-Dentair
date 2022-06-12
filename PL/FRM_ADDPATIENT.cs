using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Cabinet_Dentair.PL
{
    public partial class FRM_ADDPATIENT : Form
    {
        BL.CLS_ADDPATIENT pat = new BL.CLS_ADDPATIENT();  
        public FRM_ADDPATIENT()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pat.ADD_PATIENT(Nom.Text, Prenom.Text, Sexe.Text, Convert.ToDateTime(DateDeNaissance.Value), LieuDeNaissance.Text, Adresse.Text, NumeroDeTelephone.Text, Email.Text, RaisonDeVenir.Text, TypePaiement.Text);
            MessageBox.Show("Ajouté avec succès", "processus d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}