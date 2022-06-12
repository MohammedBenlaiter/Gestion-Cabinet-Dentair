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
    public partial class FRM_USER_MANAGEMENT : Form
    {
        private static FRM_USER_MANAGEMENT frm; // for refreshing the datagridview after updating  

        static void frm_FormClosed(object sender, FormClosedEventArgs e)   //// for refreshing the datagridview after updating 
        {
            frm = null;
        }
        public static FRM_USER_MANAGEMENT getPatientManage   // for refreshing the datagridview after updating 
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_USER_MANAGEMENT();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public FRM_USER_MANAGEMENT()
        {
            InitializeComponent();
            if (frm == null)
            {   // for refreshing the datagridview after updating 
                frm = this;
            }     // for refreshing the datagridview after updating 
            this.gET_ALL_USERSTableAdapter.Fill(this.gestionCabinetDentaireDataSet1.GET_ALL_USERS);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            PL.FRM_CREATUSER frm = new PL.FRM_CREATUSER();
            frm.Show();
        }

        private void FRM_USER_MANAGEMENT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionCabinetDentaireDataSet1.GET_ALL_USERS' table. You can move, or remove it, as needed.
            this.gET_ALL_USERSTableAdapter.Fill(this.gestionCabinetDentaireDataSet1.GET_ALL_USERS);

        }

        BL.CLS_USER_MANAGEMENT prd = new BL.CLS_USER_MANAGEMENT();
        private void deleteuser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment supprimer le patient ?", "processus de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.DELETE_USER(this.userview.CurrentRow.Cells[0].Value.ToString() );
                MessageBox.Show("La suppression a été effectuée avec succès", "processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La suppression a été annulée", "processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.gET_ALL_USERSTableAdapter.Fill(this.gestionCabinetDentaireDataSet1.GET_ALL_USERS);
        }

        private void modifuserbtn_Click(object sender, EventArgs e)
        {
            PL.FRM_EDIT_USER frm = new PL.FRM_EDIT_USER();
            frm.idusermodif.Text = this.userview.CurrentRow.Cells[0].Value.ToString();
            frm.nomumodif.Text = this.userview.CurrentRow.Cells[1].Value.ToString();
            frm.prenomumodif.Text = this.userview.CurrentRow.Cells[2].Value.ToString();
            frm.usrnamemodif.Text = this.userview.CurrentRow.Cells[3].Value.ToString();
            frm.usserpasswordmodif.Text = this.userview.CurrentRow.Cells[3].Value.ToString();
            frm.typeusermodif.Text = this.userview.CurrentRow.Cells[3].Value.ToString();
            frm.Show();
        }
    }
}
