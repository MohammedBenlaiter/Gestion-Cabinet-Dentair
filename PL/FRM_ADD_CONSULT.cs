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
    public partial class FRM_ADD_CONSULT : Form
    {
        BL.CLS_CONSULT_MANAG con = new BL.CLS_CONSULT_MANAG();
        public FRM_ADD_CONSULT()
        {
            InitializeComponent();
          //  this.medicamentforconsult.DataSource = con.GET_ALL_MEDICAMENT_FOR_CONSULT();
        }
        private void showPatienForRdv_Click(object sender, EventArgs e)
        {
            FRM_SEARCH_PATIENT_FOR_CONSULT frm = new FRM_SEARCH_PATIENT_FOR_CONSULT();
            frm.ShowDialog();
            this.patidconsult.Text = frm.PatientListForConsult.CurrentRow.Cells[0].Value.ToString();    
            this.nompatconsult.Text = frm.PatientListForConsult.CurrentRow.Cells[1].Value.ToString();
            this.prenompatconsult.Text = frm.PatientListForConsult.CurrentRow.Cells[2].Value.ToString();
            this.SexeConsult.Text = frm.PatientListForConsult.CurrentRow.Cells[3].Value.ToString();
            this.DateDeNaissanceConsult.Text = frm.PatientListForConsult.CurrentRow.Cells[4].Value.ToString();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            RadioPic.Image.Save(ms, RadioPic.Image.RawFormat);
            byte[] byteImage = ms.ToArray();

            con.ADD_CONSULT(Convert.ToInt32(patidconsult.Text), diagnostic.Text, traitement.Text, byteImage , Convert.ToDateTime(DateConsult.Text));
            MessageBox.Show("Validation avec succès", "processus Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MedShowbtn_Click(object sender, EventArgs e)
        {
            PL.FRM_SEARCH_MEDICAMENT_FOR_CONSULT frm = new PL.FRM_SEARCH_MEDICAMENT_FOR_CONSULT();
            frm.ShowDialog();
            this.idmedicamentcon.Text = frm.MedListForConsult.CurrentRow.Cells[0].Value.ToString();     
            this.nommedicamentconsult.Text = frm.MedListForConsult.CurrentRow.Cells[1].Value.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            con.ADD_CONSULT_DET(Convert.ToInt32(idmedicamentcon.Text));
            this.gET_ALL_MEDICAMENT_FOR_CONSULTTableAdapter.Fill(this.gestionCabinetDentaireDataSet2.GET_ALL_MEDICAMENT_FOR_CONSULT);
            this.medicamentforconsult.Show();
           // MessageBox.Show("Ajouter un medicament avec succès", "processus Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FRM_ADD_CONSULT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionCabinetDentaireDataSet2.GET_ALL_MEDICAMENT_FOR_CONSULT' table. You can move, or remove it, as needed.
            this.gET_ALL_MEDICAMENT_FOR_CONSULTTableAdapter.Fill(this.gestionCabinetDentaireDataSet2.GET_ALL_MEDICAMENT_FOR_CONSULT);
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files | *.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RadioPic.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
