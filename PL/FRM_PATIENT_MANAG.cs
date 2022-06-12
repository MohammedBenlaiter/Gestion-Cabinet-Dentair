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
    public partial class FRM_PATIENT_MANAG : Form
    {
        private static FRM_PATIENT_MANAG frm; // for refreshing the datagridview after updating  
        
        static void frm_FormClosed(object sender,FormClosedEventArgs e)   //// for refreshing the datagridview after updating 
        {
            frm = null ; 
        }
        public static FRM_PATIENT_MANAG getPatientManage   // for refreshing the datagridview after updating 
        {
            get
            {
                if (frm == null)
                {
                    frm= new FRM_PATIENT_MANAG();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm; 
            }
        }
        BL.CLS_PATIENT_MANAG prd = new BL.CLS_PATIENT_MANAG();  // for to show the data in DatagridViewer
        public FRM_PATIENT_MANAG()
        {
            InitializeComponent();
            if (frm == null) {   // for refreshing the datagridview after updating 
                frm = this;
            }     // for refreshing the datagridview after updating 
            this.PatientView.DataSource = prd.GET_ALL_PATIENT();    // this make us show the patient tablle in  DataGridViewer
           // this.gET_ALL_PATIENTTableAdapter.Fill(this.gestionCabinetDentaireDataSet.GET_ALL_PATIENT);
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = prd.SEARCH_PATIENT(txtsearch.Text);
            this.PatientView.DataSource=Dt;
        }

        private void deletepatient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment supprimer le patient ?", "processus de suppression", MessageBoxButtons.YesNo , MessageBoxIcon.Exclamation)== DialogResult.Yes)
            {
                prd.DELETE_PATIENT(this.PatientView.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("La suppression a été effectuée avec succès","processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.PatientView.DataSource = prd.GET_ALL_PATIENT();
                //this.gET_ALL_PATIENTTableAdapter.Fill(this.gestionCabinetDentaireDataSet.GET_ALL_PATIENT);
            }
            else { 
                MessageBox.Show("La suppression a été annulée", "processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)    
        {
            PL.FRM_EDIT_PATIENT frm = new PL.FRM_EDIT_PATIENT();
            frm.txtpatientid.Text = this.PatientView.CurrentRow.Cells[0].Value.ToString();
            frm.txtnom.Text = this.PatientView.CurrentRow.Cells[1].Value.ToString();
            frm.txtprenom.Text = this.PatientView.CurrentRow.Cells[2].Value.ToString();
            frm.txtsexe.Text = this.PatientView.CurrentRow.Cells[3].Value.ToString();
            frm.modifDateDeNaissance.Text = this.PatientView.CurrentRow.Cells[4].Value.ToString();
            frm.txtLieuDeNaissance.Text = this.PatientView.CurrentRow.Cells[5].Value.ToString();
            frm.txtadresse.Text = this.PatientView.CurrentRow.Cells[6].Value.ToString();
            frm.txtnumtelf.Text = this.PatientView.CurrentRow.Cells[7].Value.ToString();
            frm.txtemail.Text = this.PatientView.CurrentRow.Cells[8].Value.ToString();
            frm.txtraisondevenir.Text = this.PatientView.CurrentRow.Cells[9].Value.ToString();
            frm.txttypepaiement.Text = this.PatientView.CurrentRow.Cells[10].Value.ToString();
          //frm.Text = "mise à jour de patient" + this.PatientView.CurrentRow.Cells[1].Value.ToString();
            frm.Show();
        }

        public void FRM_PATIENT_MANAG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionCabinetDentaireDataSet.GET_ALL_PATIENT' table. You can move, or remove it, as needed.
            this.gET_ALL_PATIENTTableAdapter.Fill(this.gestionCabinetDentaireDataSet.GET_ALL_PATIENT);

        }

        private void refreshe_Click(object sender, EventArgs e)
        {
            this.PatientView.DataSource = prd.GET_ALL_PATIENT();
        }
    }
}
