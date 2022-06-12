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
    public partial class FRM_SEARCH_MED_FOR_RDV : Form
    {
        BL.CLS_RDV prd = new BL.CLS_RDV();
        public FRM_SEARCH_MED_FOR_RDV()
        {
            InitializeComponent();
            this.MedListForRdv.DataSource = prd.GET_ALL_DOCTORS();
        }
        private void MedListForRdv_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
