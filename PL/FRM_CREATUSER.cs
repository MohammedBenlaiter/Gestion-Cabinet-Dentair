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
    public partial class FRM_CREATUSER : Form
    {
        BL.CLS_USER_MANAGEMENT user = new BL.CLS_USER_MANAGEMENT();
        public FRM_CREATUSER()
        {
            InitializeComponent();
        }

        private void btnmodf_Click(object sender, EventArgs e)
        {
            user.ADD_USER(nomu.Text , prenomu.Text , usrname.Text , verifiuser.Text , typeuser.Text );
            MessageBox.Show("S'inscrire avec succès", "processus S'inscrire", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // FRM_PATIENT_MANAG.getPatientManage..DataSource = user;   // for refreshing the datagridview after updating
        }
    }
}
