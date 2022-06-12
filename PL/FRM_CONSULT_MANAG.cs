using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Gestion_Cabinet_Dentair.PL
{
    public partial class FRM_CONSULT_MANAG : Form
    {
        public FRM_CONSULT_MANAG()
        {
            InitializeComponent();
        }
        BL.CLS_CONSULT_MANAG prd = new BL.CLS_CONSULT_MANAG();
        private void btnmodf_Click(object sender, EventArgs e)
        {
            PL.FRM_ADD_CONSULT frm = new PL.FRM_ADD_CONSULT();
            frm.Show();
        } 

        private void showPatienForRdv_Click(object sender, EventArgs e)
        {


            FRM_SEARCH_PATIENT_FOR_CONSULT frm = new FRM_SEARCH_PATIENT_FOR_CONSULT ();
            frm.ShowDialog();
            this.patidconsult2.Text = frm.PatientListForConsult.CurrentRow.Cells[0].Value.ToString();     
            this.nompatconsult.Text = frm.PatientListForConsult.CurrentRow.Cells[1].Value.ToString();
            this.prenompatconsult.Text = frm.PatientListForConsult.CurrentRow.Cells[2].Value.ToString();
            this.SexeConsultR.Text = frm.PatientListForConsult.CurrentRow.Cells[3].Value.ToString();
            this.DateDeNaissanceConsultR.Text = frm.PatientListForConsult.CurrentRow.Cells[4].Value.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {  
            BL.CLS_CONSULT_MANAG con = new BL.CLS_CONSULT_MANAG();
            PL.FRM_CONSULT_MANAG frm = new FRM_CONSULT_MANAG();

            int a;
            a =  Convert.ToInt32( patidconsult2.Text) ; 

            this.PatientView.DataSource= con.SHOW_MEDICAMENT_FOR_CONSULT( a, Convert.ToDateTime(DateConsult.Text) );
            this.InformationsSurConsultation.DataSource = con.SHOW_CONSULT_INF_FOR_CONSULT( Convert.ToDateTime(DateConsult.Text));


            this.Hhhh.DataSource = con.SHOW_RADIO_INF_FOR_CONSULT(Convert.ToDateTime(DateConsult.Text));

            if (Hhhh.Rows[0].Cells[0] != null)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])( Hhhh.Rows[0].Cells[0].Value ) ;
                MemoryStream memory = new MemoryStream(data);
                RadioPicConsult.Image = Image.FromStream(memory);
            }
            else
                RadioPicConsult.Image = null;

            //byte[] image = (byte[])con.SHOW_RADIO_INF_FOR_CONSULT(this.Hhhh.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            //MemoryStream ms = new MemoryStream(image);
            //frm.RadioPicConsult.Image = Image.FromStream(ms);
        }
         
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FRM_SHOW_ALL_DATE_CONSULT frm = new FRM_SHOW_ALL_DATE_CONSULT(patidconsult2.Text);
            frm.ShowDialog();
            this.DateConsult.Text = frm.datesforconsultlist.CurrentRow.Cells[0].Value.ToString();     // 9abel lil taghyir
            //  BL.CLS_CONSULT_MANAG con = new BL.CLS_CONSULT_MANAG(); 
            // this.datesforconsultlist.DataSource = con.SHOW_ALL_DATE_CONSULT(Convert.ToInt32(patidconsult2.Text));
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Voulez-vous vraiment supprimer le patient ?", "processus de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.DELETE_CONSULT(DateConsult.Text);
                MessageBox.Show("La suppression a été effectuée avec succès", "processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
                //this.gET_ALL_PATIENTTableAdapter.Fill(this.gestionCabinetDentaireDataSet.GET_ALL_PATIENT);
            }
            else
            {
                MessageBox.Show("La suppression a été annulée", "processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
