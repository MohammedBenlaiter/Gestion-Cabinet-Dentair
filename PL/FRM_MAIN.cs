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
    public partial class FRM_MAIN : Form
    {    
        public FRM_MAIN(string fgh)
        {
            InitializeComponent();
            guna2Button3.Checked = true;
            loadform(new FRM_DASHBOARD());
            usernamestate.Text = fgh;
            BL.CLS_LOGIN use = new BL.CLS_LOGIN();
            this.usertypegrid.DataSource = use.GET_USER_TYPE(fgh);
            type.Text = Convert.ToString(usertypegrid.Rows[0].Cells[0].Value);
            
            if (type.Text == "Medecin")
            {
                btnusermang.Hide();
            }
            else if (type.Text =="Reception")
            {
                btnusermang.Hide();
                guna2Button5.Hide();
                guna2Button4.Hide();
            }
        }     

        public void loadform(object Form)   // method to load form to another form 
        {
            if (this.loadpanel.Controls.Count > 0)
                this.loadpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.loadpanel.Controls.Add(f);
            this.loadpanel.Tag = f;
            f.Show();
        }

        private void btnaddpat_Click(object sender, EventArgs e)   // load add patient form
        {
            loadform(new FRM_ADDPATIENT());
        }

        private void btnusermang_Click(object sender, EventArgs e)   // load usermanagement form
        {
            loadform(new FRM_USER_MANAGEMENT());
        }

        public void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(new FRM_PATIENT_MANAG());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            loadform(new FRM_RENDEZ_VOUS());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            loadform(new FRM_CONSULT_MANAG());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loadform(new FRM_DASHBOARD());
            //here

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            loadform(new FRM_MEDICAMENT());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            loadform(new FRM_PAIMENT() );
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            PL.FRM_LOGIN frm = new PL.FRM_LOGIN();
            frm.Show();
            this.Hide();
        }
    }
}
