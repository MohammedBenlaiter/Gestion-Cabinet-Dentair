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
    public partial class FRM_PAIMENT : Form
    {
        BL.CLS_PAY pay = new BL.CLS_PAY();
        public FRM_PAIMENT()
        {
            InitializeComponent();
        }
        private void showPatienForRdv_Click(object sender, EventArgs e)
        {
            FRM_SEARCH_PATIENT_FOR_RDV frm = new FRM_SEARCH_PATIENT_FOR_RDV();
            frm.ShowDialog();
            this.patidconsult2.Text = frm.PatientListForRdv.CurrentRow.Cells[0].Value.ToString();     // 9abel lil taghyir 
            this.nompatconsult.Text = frm.PatientListForRdv.CurrentRow.Cells[1].Value.ToString();
            this.prenompatconsult.Text = frm.PatientListForRdv.CurrentRow.Cells[2].Value.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pay.ADD_PAY(Convert.ToInt32( patidconsult2.Text) ,Convert.ToInt32( paycomplet.Text) );
            this.paygrid.DataSource = pay.SHOW_PAY(Convert.ToInt32(patidconsult2.Text)) ;
        }
    }
}
