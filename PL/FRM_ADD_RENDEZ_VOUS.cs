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
    public partial class FRM_ADD_RENDEZ_VOUS : Form
    {
        BL.CLS_RDV pat = new BL.CLS_RDV();
        public FRM_ADD_RENDEZ_VOUS()
        {
            InitializeComponent();
        }

        private void showPatienForRdv_Click(object sender, EventArgs e)
        {
            FRM_SEARCH_PATIENT_FOR_RDV frm = new FRM_SEARCH_PATIENT_FOR_RDV();
            frm.ShowDialog();
            this.txtIdRdv.Text = frm.PatientListForRdv.CurrentRow.Cells[0].Value.ToString();      
            this.txtNomRdv.Text = frm.PatientListForRdv.CurrentRow.Cells[1].Value.ToString();
            this.txtPrenomRdv.Text = frm.PatientListForRdv.CurrentRow.Cells[2].Value.ToString();
        }

        private void MedShowbtn_Click(object sender, EventArgs e)
        {
            FRM_SEARCH_MED_FOR_RDV frm = new FRM_SEARCH_MED_FOR_RDV();
            frm.ShowDialog();
            this.txtidmed.Text = frm.MedListForRdv.CurrentRow.Cells[0].Value.ToString();    
            this.txtnommed.Text = frm.MedListForRdv.CurrentRow.Cells[1].Value.ToString();
            this.txtprenommed.Text = frm.MedListForRdv.CurrentRow.Cells[2].Value.ToString();
            //string name = Environment.MachineName.ToString();
            //MessageBox.Show(name);

        }

        private void addrdvbtn_Click(object sender, EventArgs e)
        {
            pat.ADD_RDV( Convert.ToInt32(txtIdRdv.Text), Convert.ToInt32(txtidmed.Text) , Convert.ToDateTime(DateRe.Value) , txtHeureDeRendezVous.Text , txtRaisonDeVenir.Text );
            MessageBox.Show("Ajouté RendezVous avec succès", "processus d'ajout RendezVous", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
