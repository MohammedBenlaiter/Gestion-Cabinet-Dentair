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

    public partial class FRM_SEARCH_PATIENT_FOR_RDV : Form
    {
        BL.CLS_PATIENT_MANAG PAT = new BL.CLS_PATIENT_MANAG();
        public FRM_SEARCH_PATIENT_FOR_RDV()
        {
            InitializeComponent();
            this.PatientListForRdv.DataSource = PAT.GET_ALL_PATIENT();     //  excute get all patient in data grid view 
            this.PatientListForRdv.Columns[3].Visible = false ;            // hide some columns in data grid view 
            this.PatientListForRdv.Columns[4].Visible = false;
            this.PatientListForRdv.Columns[5].Visible = false;
            this.PatientListForRdv.Columns[6].Visible = false;
            this.PatientListForRdv.Columns[7].Visible = false;
            this.PatientListForRdv.Columns[8].Visible = false;
            this.PatientListForRdv.Columns[9].Visible = false;
            this.PatientListForRdv.Columns[10].Visible = false;
        }

        private void PatientListForRdv_DoubleClick(object sender, EventArgs e)
        {
            this.Close();          
        }
    }
}
