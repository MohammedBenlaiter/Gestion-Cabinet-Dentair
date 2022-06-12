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
    public partial class FRM_DASHBOARD : Form
    {
        BL.CLS_DASHBOARD con = new BL.CLS_DASHBOARD();
        BL.CLS_DASHBOARD rdv = new BL.CLS_DASHBOARD();
        BL.CLS_DASHBOARD med = new BL.CLS_DASHBOARD();
        public FRM_DASHBOARD()
        {
            InitializeComponent();
            patientstat.BackColor = Color.Transparent;

            this.patientstatgrid.DataSource = con.COUNT_PATIENT();
            this.rdvstatgrid.DataSource = rdv.COUNT_RDV();
            this.medstatgrid.DataSource = med.COUNT_MEDECIN();
            patientstat.Text = Convert.ToString( patientstatgrid.Rows[0].Cells[0].Value );
            rdvstat.Text = Convert.ToString( rdvstatgrid.Rows[0].Cells[0].Value );
            medstat.Text = Convert.ToString(medstatgrid.Rows[0].Cells[0].Value);
        }
        private void FRM_DASHBOARD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionCabinetDentaireDataSet8.COUNT_RDV' table. You can move, or remove it, as needed.
            this.cOUNT_RDVTableAdapter.Fill(this.gestionCabinetDentaireDataSet8.COUNT_RDV);
            // TODO: This line of code loads data into the 'gestionCabinetDentaireDataSet7.COUNT_PATIENT' table. You can move, or remove it, as needed.
            this.cOUNT_PATIENTTableAdapter.Fill(this.gestionCabinetDentaireDataSet7.COUNT_PATIENT);
        }

     }
}