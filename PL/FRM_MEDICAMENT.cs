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
    public partial class FRM_MEDICAMENT : Form
    {
        BL.CLS_MEDICAMENT con = new BL.CLS_MEDICAMENT();
        public FRM_MEDICAMENT()
        {
            InitializeComponent();
        }

        private void FRM_MEDICAMENT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionCabinetDentaireDataSet5.GET_ALL_MEDICAMENT' table. You can move, or remove it, as needed.
            this.gET_ALL_MEDICAMENTTableAdapter.Fill(this.gestionCabinetDentaireDataSet5.GET_ALL_MEDICAMENT);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            con.ADD_MEDICAMENT(NomMedicament.Text);
            MessageBox.Show("Ajouter un medicament avec succès", "processus Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.gET_ALL_MEDICAMENTTableAdapter.Fill(this.gestionCabinetDentaireDataSet5.GET_ALL_MEDICAMENT);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.gET_ALL_MEDICAMENTTableAdapter.Fill(this.gestionCabinetDentaireDataSet5.GET_ALL_MEDICAMENT);
        }

        private void deleteuser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment supprimer le patient ?", "processus de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.DELETE_MEDICAMENT (this.medicamenttable.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("La suppression a été effectuée avec succès", "processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.medicamenttable.DataSource = con.GET_ALL_MEDICAMENT ();
                //this.gET_ALL_PATIENTTableAdapter.Fill(this.gestionCabinetDentaireDataSet.GET_ALL_PATIENT);
            }
            else
            {
                MessageBox.Show("La suppression a été annulée", "processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
