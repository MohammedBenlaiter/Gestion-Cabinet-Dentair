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
    public partial class FRM_EDIT_PATIENT : Form
    {
        BL.CLS_PATIENT_MANAG pat = new BL.CLS_PATIENT_MANAG();
        
        public FRM_EDIT_PATIENT()
        {
            InitializeComponent();

        }
        public void btnmodf_Click(object sender, EventArgs e)
        {
            pat.UPDATE_PATIENT(Convert.ToInt32(txtpatientid.Text), txtnom.Text , txtprenom.Text, txtsexe.Text, Convert.ToDateTime(modifDateDeNaissance.Value), txtLieuDeNaissance.Text, txtadresse.Text, txtnumtelf.Text, txtemail.Text, txtraisondevenir.Text, txttypepaiement.Text);
            MessageBox.Show("Mise à jour terminée avec succès", "Processus de mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FRM_PATIENT_MANAG.getPatientManage.PatientView.DataSource = pat.GET_ALL_PATIENT();   // for refreshing the datagridview after updating 
                         
        }
    }
}
