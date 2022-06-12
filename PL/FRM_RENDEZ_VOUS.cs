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
    public partial class FRM_RENDEZ_VOUS : Form
    {
        public FRM_RENDEZ_VOUS()
        {
            InitializeComponent();
        }

        private void btnmodf_Click(object sender, EventArgs e)
        {
            PL.FRM_ADD_RENDEZ_VOUS frm = new PL.FRM_ADD_RENDEZ_VOUS();
            frm.Show();
        }

        private void FRM_RENDEZ_VOUS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionCabinetDentaireDataSet9.GET_ALL_RDV' table. You can move, or remove it, as needed.
            this.gET_ALL_RDVTableAdapter1.Fill(this.gestionCabinetDentaireDataSet9.GET_ALL_RDV);
            // TODO: This line of code loads data into the 'gestionCabinetDentaireDataSet6.GET_ALL_RDV' table. You can move, or remove it, as needed.
            this.gET_ALL_RDVTableAdapter.Fill(this.gestionCabinetDentaireDataSet6.GET_ALL_RDV);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            BL.CLS_RDV con = new BL.CLS_RDV();
            if (MessageBox.Show("Voulez-vous vraiment supprimer le patient ?", "processus de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.DELETE_RDV(this.Rdvview.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("La suppression a été effectuée avec succès", "processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Rdvview.DataSource = con.GET_ALL_RDV();
            }
            else
            {
                MessageBox.Show("La suppression a été annulée", "processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            BL.CLS_RDV prd = new BL.CLS_RDV();
            DataTable Dt = new DataTable();
            Dt = prd.SEARCH_RDV(txtsearch.Text);
            this.Rdvview.DataSource = Dt;
        }
    }
}
