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
    public partial class FRM_SEARCH_MEDICAMENT_FOR_CONSULT : Form
    {
        BL.CLS_CONSULT_MANAG med = new BL.CLS_CONSULT_MANAG();
        public FRM_SEARCH_MEDICAMENT_FOR_CONSULT()
        {
            InitializeComponent();
            this.MedListForConsult.DataSource = med.GET_ALL_MEDICAMENT();     //  excute get all medicament in data grid view
        }
        private void MedListForConsult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    } 
}
