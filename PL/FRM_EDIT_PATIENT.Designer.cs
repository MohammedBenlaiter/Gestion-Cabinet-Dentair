namespace Gestion_Cabinet_Dentair.PL
{
    partial class FRM_EDIT_PATIENT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txttypepaiement = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtraisondevenir = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnumtelf = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtadresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLieuDeNaissance = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modifDateDeNaissance = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtprenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsexe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnmodf = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtpatientid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPatient_ID = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttypepaiement
            // 
            this.txttypepaiement.BackColor = System.Drawing.Color.Transparent;
            this.txttypepaiement.BorderRadius = 8;
            this.txttypepaiement.BorderThickness = 2;
            this.txttypepaiement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txttypepaiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttypepaiement.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttypepaiement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttypepaiement.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txttypepaiement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txttypepaiement.ItemHeight = 30;
            this.txttypepaiement.Items.AddRange(new object[] {
            "Plusieurs Foix",
            "Complète"});
            this.txttypepaiement.Location = new System.Drawing.Point(34, 458);
            this.txttypepaiement.Name = "txttypepaiement";
            this.txttypepaiement.Size = new System.Drawing.Size(183, 36);
            this.txttypepaiement.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(41, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "Type De Paiement";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(269, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Raison De Venir ( Motif )";
            this.label10.Visible = false;
            // 
            // txtraisondevenir
            // 
            this.txtraisondevenir.Animated = true;
            this.txtraisondevenir.BorderRadius = 8;
            this.txtraisondevenir.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtraisondevenir.BorderThickness = 2;
            this.txtraisondevenir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtraisondevenir.DefaultText = "";
            this.txtraisondevenir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtraisondevenir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtraisondevenir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtraisondevenir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtraisondevenir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtraisondevenir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtraisondevenir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtraisondevenir.Location = new System.Drawing.Point(262, 458);
            this.txtraisondevenir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtraisondevenir.Name = "txtraisondevenir";
            this.txtraisondevenir.PasswordChar = '\0';
            this.txtraisondevenir.PlaceholderText = "";
            this.txtraisondevenir.SelectedText = "";
            this.txtraisondevenir.Size = new System.Drawing.Size(200, 36);
            this.txtraisondevenir.TabIndex = 9;
            this.txtraisondevenir.Visible = false;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillThickness = 2;
            this.guna2Separator2.Location = new System.Drawing.Point(0, 405);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(749, 15);
            this.guna2Separator2.TabIndex = 27;
            // 
            // txtemail
            // 
            this.txtemail.Animated = true;
            this.txtemail.BorderRadius = 8;
            this.txtemail.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtemail.BorderThickness = 2;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Location = new System.Drawing.Point(262, 304);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(274, 36);
            this.txtemail.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(269, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Email";
            // 
            // txtnumtelf
            // 
            this.txtnumtelf.Animated = true;
            this.txtnumtelf.BorderRadius = 8;
            this.txtnumtelf.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtnumtelf.BorderThickness = 2;
            this.txtnumtelf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnumtelf.DefaultText = "";
            this.txtnumtelf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnumtelf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnumtelf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnumtelf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnumtelf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnumtelf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtnumtelf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnumtelf.Location = new System.Drawing.Point(34, 304);
            this.txtnumtelf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnumtelf.Name = "txtnumtelf";
            this.txtnumtelf.PasswordChar = '\0';
            this.txtnumtelf.PlaceholderText = "";
            this.txtnumtelf.SelectedText = "";
            this.txtnumtelf.Size = new System.Drawing.Size(200, 36);
            this.txtnumtelf.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(41, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Numero De Telephone";
            // 
            // txtadresse
            // 
            this.txtadresse.Animated = true;
            this.txtadresse.BorderRadius = 8;
            this.txtadresse.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtadresse.BorderThickness = 2;
            this.txtadresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadresse.DefaultText = "";
            this.txtadresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtadresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtadresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadresse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtadresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadresse.Location = new System.Drawing.Point(460, 218);
            this.txtadresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.PasswordChar = '\0';
            this.txtadresse.PlaceholderText = "";
            this.txtadresse.SelectedText = "";
            this.txtadresse.Size = new System.Drawing.Size(223, 36);
            this.txtadresse.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(467, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Adresse";
            // 
            // txtLieuDeNaissance
            // 
            this.txtLieuDeNaissance.Animated = true;
            this.txtLieuDeNaissance.BorderRadius = 8;
            this.txtLieuDeNaissance.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtLieuDeNaissance.BorderThickness = 2;
            this.txtLieuDeNaissance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLieuDeNaissance.DefaultText = "";
            this.txtLieuDeNaissance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLieuDeNaissance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLieuDeNaissance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLieuDeNaissance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLieuDeNaissance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLieuDeNaissance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLieuDeNaissance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLieuDeNaissance.Location = new System.Drawing.Point(262, 218);
            this.txtLieuDeNaissance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLieuDeNaissance.Name = "txtLieuDeNaissance";
            this.txtLieuDeNaissance.PasswordChar = '\0';
            this.txtLieuDeNaissance.PlaceholderText = "";
            this.txtLieuDeNaissance.SelectedText = "";
            this.txtLieuDeNaissance.Size = new System.Drawing.Size(168, 36);
            this.txtLieuDeNaissance.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(269, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lieu De Naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(41, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date De Naissance";
            // 
            // modifDateDeNaissance
            // 
            this.modifDateDeNaissance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.modifDateDeNaissance.BorderRadius = 8;
            this.modifDateDeNaissance.Checked = true;
            this.modifDateDeNaissance.FillColor = System.Drawing.Color.White;
            this.modifDateDeNaissance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modifDateDeNaissance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(53)))));
            this.modifDateDeNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.modifDateDeNaissance.Location = new System.Drawing.Point(34, 218);
            this.modifDateDeNaissance.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.modifDateDeNaissance.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.modifDateDeNaissance.Name = "modifDateDeNaissance";
            this.modifDateDeNaissance.Size = new System.Drawing.Size(168, 36);
            this.modifDateDeNaissance.TabIndex = 4;
            this.modifDateDeNaissance.Value = new System.DateTime(2022, 4, 24, 23, 55, 48, 248);
            // 
            // txtprenom
            // 
            this.txtprenom.Animated = true;
            this.txtprenom.BorderRadius = 8;
            this.txtprenom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtprenom.BorderThickness = 2;
            this.txtprenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprenom.DefaultText = "";
            this.txtprenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprenom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtprenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprenom.Location = new System.Drawing.Point(427, 99);
            this.txtprenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.PasswordChar = '\0';
            this.txtprenom.PlaceholderText = "";
            this.txtprenom.SelectedText = "";
            this.txtprenom.Size = new System.Drawing.Size(168, 36);
            this.txtprenom.TabIndex = 2;
            // 
            // txtsexe
            // 
            this.txtsexe.BackColor = System.Drawing.Color.Transparent;
            this.txtsexe.BorderRadius = 8;
            this.txtsexe.BorderThickness = 2;
            this.txtsexe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtsexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtsexe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsexe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsexe.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtsexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtsexe.ItemHeight = 30;
            this.txtsexe.Items.AddRange(new object[] {
            "F",
            "M"});
            this.txtsexe.Location = new System.Drawing.Point(625, 99);
            this.txtsexe.Name = "txtsexe";
            this.txtsexe.Size = new System.Drawing.Size(102, 36);
            this.txtsexe.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(632, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sexe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(434, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(230, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // txtnom
            // 
            this.txtnom.Animated = true;
            this.txtnom.BorderRadius = 8;
            this.txtnom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtnom.BorderThickness = 2;
            this.txtnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnom.DefaultText = "";
            this.txtnom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtnom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnom.Location = new System.Drawing.Point(223, 99);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnom.Name = "txtnom";
            this.txtnom.PasswordChar = '\0';
            this.txtnom.PlaceholderText = "";
            this.txtnom.SelectedText = "";
            this.txtnom.Size = new System.Drawing.Size(168, 36);
            this.txtnom.TabIndex = 1;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 142);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(749, 15);
            this.guna2Separator1.TabIndex = 31;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(785, 37);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(750, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(35, 35);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(709, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(35, 35);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // btnmodf
            // 
            this.btnmodf.Animated = true;
            this.btnmodf.BorderRadius = 8;
            this.btnmodf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmodf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmodf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmodf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmodf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.btnmodf.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnmodf.ForeColor = System.Drawing.Color.White;
            this.btnmodf.IndicateFocus = true;
            this.btnmodf.Location = new System.Drawing.Point(489, 449);
            this.btnmodf.Name = "btnmodf";
            this.btnmodf.Size = new System.Drawing.Size(180, 45);
            this.btnmodf.TabIndex = 16;
            this.btnmodf.Text = "Modifier";
            this.btnmodf.Click += new System.EventHandler(this.btnmodf_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // txtpatientid
            // 
            this.txtpatientid.Animated = true;
            this.txtpatientid.BorderRadius = 8;
            this.txtpatientid.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtpatientid.BorderThickness = 2;
            this.txtpatientid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpatientid.DefaultText = "";
            this.txtpatientid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpatientid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpatientid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpatientid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpatientid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpatientid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtpatientid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpatientid.Location = new System.Drawing.Point(17, 99);
            this.txtpatientid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpatientid.Name = "txtpatientid";
            this.txtpatientid.PasswordChar = '\0';
            this.txtpatientid.PlaceholderText = "";
            this.txtpatientid.ReadOnly = true;
            this.txtpatientid.SelectedText = "";
            this.txtpatientid.Size = new System.Drawing.Size(168, 36);
            this.txtpatientid.TabIndex = 32;
            // 
            // txtPatient_ID
            // 
            this.txtPatient_ID.AutoSize = true;
            this.txtPatient_ID.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtPatient_ID.Location = new System.Drawing.Point(24, 75);
            this.txtPatient_ID.Name = "txtPatient_ID";
            this.txtPatient_ID.Size = new System.Drawing.Size(84, 21);
            this.txtPatient_ID.TabIndex = 33;
            this.txtPatient_ID.Text = "Patient_ID";
            // 
            // FRM_EDIT_PATIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 541);
            this.Controls.Add(this.txtpatientid);
            this.Controls.Add(this.txtPatient_ID);
            this.Controls.Add(this.btnmodf);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.txttypepaiement);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtraisondevenir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.txtsexe);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtnumtelf);
            this.Controls.Add(this.txtLieuDeNaissance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modifDateDeNaissance);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_EDIT_PATIENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_EDIT_PATIENT";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public Guna.UI2.WinForms.Guna2ComboBox txttypepaiement;
        public Guna.UI2.WinForms.Guna2TextBox txtraisondevenir;
        public Guna.UI2.WinForms.Guna2TextBox txtemail;
        public Guna.UI2.WinForms.Guna2TextBox txtnumtelf;
        public Guna.UI2.WinForms.Guna2TextBox txtadresse;
        public Guna.UI2.WinForms.Guna2TextBox txtLieuDeNaissance;
        public Guna.UI2.WinForms.Guna2DateTimePicker modifDateDeNaissance;
        public Guna.UI2.WinForms.Guna2TextBox txtprenom;
        public Guna.UI2.WinForms.Guna2ComboBox txtsexe;
        public Guna.UI2.WinForms.Guna2TextBox txtnom;
        public Guna.UI2.WinForms.Guna2Button btnmodf;
        public Guna.UI2.WinForms.Guna2TextBox txtpatientid;
        private System.Windows.Forms.Label txtPatient_ID;
    }
}