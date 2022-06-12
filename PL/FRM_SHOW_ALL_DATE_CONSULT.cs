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
    public partial class FRM_SHOW_ALL_DATE_CONSULT : Form
    {

        BL.CLS_CONSULT_MANAG med = new BL.CLS_CONSULT_MANAG();

        public FRM_SHOW_ALL_DATE_CONSULT(string r)
        {
            InitializeComponent();
            this.datesforconsultlist.DataSource = med.SHOW_ALL_DATE_CONSULT( Convert.ToInt32(r)   );     //  excute get all medicament in data grid view
        }

        private void datesforconsultlist_DoubleClick(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}