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
    public partial class FRM_EDIT_USER : Form
    {
        BL.CLS_USER_MANAGEMENT pat = new BL.CLS_USER_MANAGEMENT();
        public FRM_EDIT_USER()
        {
            InitializeComponent();
        }

        private void btnmodf_Click(object sender, EventArgs e)
        {
            pat.UPDATE_USER(Convert.ToInt32(idusermodif.Text), nomumodif.Text , prenomumodif.Text , usrnamemodif.Text , verifiusermodif.Text , typeusermodif.Text);
            MessageBox.Show("Mise à jour terminée avec succès", "Processus de mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FRM_EDIT_USER_Load(object sender, EventArgs e)
        {

        }
    }
}
