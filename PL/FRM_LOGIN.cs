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
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.LOGIN(username.Text,pwd.Text);   // Dt have executing LOGIN 
            if (Dt.Rows.Count > 0)
            {
                PL.FRM_MAIN frm = new PL.FRM_MAIN(username.Text);
                frm.Show();
                this.Hide();
                //MessageBox.Show("loogin success !");
            }
            else
            {
                MessageBox.Show("login failed !");
            }
        }
    }
}
