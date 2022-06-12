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
    public partial class FRM_SEARCH_PATIENT_FOR_CONSULT : Form
    {
        public FRM_SEARCH_PATIENT_FOR_CONSULT()
        {
            InitializeComponent();
        }

        private void FRM_SEARCH_PATIENT_FOR_CONSULTcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionCabinetDentaireDataSet3.FichPatient' table. You can move, or remove it, as needed.
            this.fichPatientTableAdapter.Fill(this.gestionCabinetDentaireDataSet3.FichPatient);

        }

        private void PatientListForRdv_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
