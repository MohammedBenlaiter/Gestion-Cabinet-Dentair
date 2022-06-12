namespace Gestion_Cabinet_Dentair.PL
{
    partial class FRM_ADDPATIENT
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.TypePaiement = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RaisonDeVenir = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NumeroDeTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Adresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LieuDeNaissance = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateDeNaissance = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Prenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.Sexe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.guna2Button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(514, 418);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Ajouter";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // TypePaiement
            // 
            this.TypePaiement.BackColor = System.Drawing.Color.Transparent;
            this.TypePaiement.BorderRadius = 8;
            this.TypePaiement.BorderThickness = 2;
            this.TypePaiement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TypePaiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypePaiement.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypePaiement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypePaiement.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.TypePaiement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TypePaiement.ItemHeight = 30;
            this.TypePaiement.Items.AddRange(new object[] {
            "Par Facilité",
            "Complète"});
            this.TypePaiement.Location = new System.Drawing.Point(31, 418);
            this.TypePaiement.Name = "TypePaiement";
            this.TypePaiement.Size = new System.Drawing.Size(183, 36);
            this.TypePaiement.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "Type De Paiement";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Raison De Venir ( Motif )";
            this.label10.Visible = false;
            // 
            // RaisonDeVenir
            // 
            this.RaisonDeVenir.Animated = true;
            this.RaisonDeVenir.BorderRadius = 8;
            this.RaisonDeVenir.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.RaisonDeVenir.BorderThickness = 2;
            this.RaisonDeVenir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RaisonDeVenir.DefaultText = "";
            this.RaisonDeVenir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RaisonDeVenir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RaisonDeVenir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RaisonDeVenir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RaisonDeVenir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RaisonDeVenir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaisonDeVenir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RaisonDeVenir.Location = new System.Drawing.Point(250, 418);
            this.RaisonDeVenir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RaisonDeVenir.Name = "RaisonDeVenir";
            this.RaisonDeVenir.PasswordChar = '\0';
            this.RaisonDeVenir.PlaceholderText = "";
            this.RaisonDeVenir.SelectedText = "";
            this.RaisonDeVenir.Size = new System.Drawing.Size(200, 36);
            this.RaisonDeVenir.TabIndex = 9;
            this.RaisonDeVenir.Visible = false;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(3, 363);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(749, 15);
            this.guna2Separator2.TabIndex = 27;
            // 
            // Email
            // 
            this.Email.Animated = true;
            this.Email.BorderRadius = 8;
            this.Email.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Email.BorderThickness = 2;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.DefaultText = "";
            this.Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.Location = new System.Drawing.Point(259, 298);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.PlaceholderText = "";
            this.Email.SelectedText = "";
            this.Email.Size = new System.Drawing.Size(274, 36);
            this.Email.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Email";
            // 
            // NumeroDeTelephone
            // 
            this.NumeroDeTelephone.Animated = true;
            this.NumeroDeTelephone.BorderRadius = 8;
            this.NumeroDeTelephone.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.NumeroDeTelephone.BorderThickness = 2;
            this.NumeroDeTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumeroDeTelephone.DefaultText = "";
            this.NumeroDeTelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumeroDeTelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumeroDeTelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumeroDeTelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumeroDeTelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumeroDeTelephone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NumeroDeTelephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumeroDeTelephone.Location = new System.Drawing.Point(31, 298);
            this.NumeroDeTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumeroDeTelephone.Name = "NumeroDeTelephone";
            this.NumeroDeTelephone.PasswordChar = '\0';
            this.NumeroDeTelephone.PlaceholderText = "";
            this.NumeroDeTelephone.SelectedText = "";
            this.NumeroDeTelephone.Size = new System.Drawing.Size(200, 36);
            this.NumeroDeTelephone.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Numero De Telephone";
            // 
            // Adresse
            // 
            this.Adresse.Animated = true;
            this.Adresse.BorderRadius = 8;
            this.Adresse.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Adresse.BorderThickness = 2;
            this.Adresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Adresse.DefaultText = "";
            this.Adresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Adresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Adresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Adresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Adresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Adresse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Adresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Adresse.Location = new System.Drawing.Point(457, 212);
            this.Adresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Adresse.Name = "Adresse";
            this.Adresse.PasswordChar = '\0';
            this.Adresse.PlaceholderText = "";
            this.Adresse.SelectedText = "";
            this.Adresse.Size = new System.Drawing.Size(223, 36);
            this.Adresse.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Adresse";
            // 
            // LieuDeNaissance
            // 
            this.LieuDeNaissance.Animated = true;
            this.LieuDeNaissance.BorderRadius = 8;
            this.LieuDeNaissance.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.LieuDeNaissance.BorderThickness = 2;
            this.LieuDeNaissance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LieuDeNaissance.DefaultText = "";
            this.LieuDeNaissance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LieuDeNaissance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LieuDeNaissance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LieuDeNaissance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LieuDeNaissance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LieuDeNaissance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LieuDeNaissance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LieuDeNaissance.Location = new System.Drawing.Point(259, 212);
            this.LieuDeNaissance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LieuDeNaissance.Name = "LieuDeNaissance";
            this.LieuDeNaissance.PasswordChar = '\0';
            this.LieuDeNaissance.PlaceholderText = "";
            this.LieuDeNaissance.SelectedText = "";
            this.LieuDeNaissance.Size = new System.Drawing.Size(168, 36);
            this.LieuDeNaissance.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lieu De Naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date De Naissance";
            // 
            // DateDeNaissance
            // 
            this.DateDeNaissance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DateDeNaissance.BorderRadius = 8;
            this.DateDeNaissance.Checked = true;
            this.DateDeNaissance.FillColor = System.Drawing.Color.White;
            this.DateDeNaissance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateDeNaissance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(53)))));
            this.DateDeNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateDeNaissance.Location = new System.Drawing.Point(31, 212);
            this.DateDeNaissance.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateDeNaissance.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateDeNaissance.Name = "DateDeNaissance";
            this.DateDeNaissance.Size = new System.Drawing.Size(168, 36);
            this.DateDeNaissance.TabIndex = 4;
            this.DateDeNaissance.Value = new System.DateTime(2022, 4, 24, 23, 55, 48, 248);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 158);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(749, 15);
            this.guna2Separator1.TabIndex = 13;
            // 
            // Prenom
            // 
            this.Prenom.Animated = true;
            this.Prenom.BorderRadius = 8;
            this.Prenom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Prenom.BorderThickness = 2;
            this.Prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Prenom.DefaultText = "";
            this.Prenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Prenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Prenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Prenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Prenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Prenom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Prenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Prenom.Location = new System.Drawing.Point(259, 84);
            this.Prenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Prenom.Name = "Prenom";
            this.Prenom.PasswordChar = '\0';
            this.Prenom.PlaceholderText = "";
            this.Prenom.SelectedText = "";
            this.Prenom.Size = new System.Drawing.Size(168, 36);
            this.Prenom.TabIndex = 2;
            // 
            // Sexe
            // 
            this.Sexe.BackColor = System.Drawing.Color.Transparent;
            this.Sexe.BorderRadius = 8;
            this.Sexe.BorderThickness = 2;
            this.Sexe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sexe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sexe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sexe.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Sexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Sexe.ItemHeight = 30;
            this.Sexe.Items.AddRange(new object[] {
            "F",
            "M"});
            this.Sexe.Location = new System.Drawing.Point(457, 84);
            this.Sexe.Name = "Sexe";
            this.Sexe.Size = new System.Drawing.Size(102, 36);
            this.Sexe.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sexe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // Nom
            // 
            this.Nom.Animated = true;
            this.Nom.BorderRadius = 8;
            this.Nom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Nom.BorderThickness = 2;
            this.Nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nom.DefaultText = "";
            this.Nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nom.Location = new System.Drawing.Point(31, 84);
            this.Nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nom.Name = "Nom";
            this.Nom.PasswordChar = '\0';
            this.Nom.PlaceholderText = "";
            this.Nom.SelectedText = "";
            this.Nom.Size = new System.Drawing.Size(168, 36);
            this.Nom.TabIndex = 1;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Controls.Add(this.guna2Button1);
            this.guna2GroupBox1.Controls.Add(this.TypePaiement);
            this.guna2GroupBox1.Controls.Add(this.label11);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.RaisonDeVenir);
            this.guna2GroupBox1.Controls.Add(this.guna2Separator2);
            this.guna2GroupBox1.Controls.Add(this.Email);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.NumeroDeTelephone);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.Adresse);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.LieuDeNaissance);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.DateDeNaissance);
            this.guna2GroupBox1.Controls.Add(this.guna2Separator1);
            this.guna2GroupBox1.Controls.Add(this.Prenom);
            this.guna2GroupBox1.Controls.Add(this.Sexe);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.Nom);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(53)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, -1);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(785, 541);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Informations Sur Les Patients";
            // 
            // FRM_ADDPATIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ADDPATIENT";
            this.Text = "FRM_ADDPATIENT";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox Nom;
        private Guna.UI2.WinForms.Guna2ComboBox Sexe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Prenom;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateDeNaissance;
        private Guna.UI2.WinForms.Guna2TextBox LieuDeNaissance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox Adresse;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox TypePaiement;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox RaisonDeVenir;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2TextBox Email;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox NumeroDeTelephone;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}