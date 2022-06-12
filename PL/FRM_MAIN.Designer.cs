namespace Gestion_Cabinet_Dentair.PL
{
    partial class FRM_MAIN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.type = new System.Windows.Forms.Label();
            this.usertypegrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.usernamestate = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnusermang = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddpat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.loadpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.gestionCabinetDentaireDataSet10 = new Gestion_Cabinet_Dentair.GestionCabinetDentaireDataSet10();
            this.gETUSERTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_USER_TYPETableAdapter = new Gestion_Cabinet_Dentair.GestionCabinetDentaireDataSet10TableAdapters.GET_USER_TYPETableAdapter();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usertypegrid)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDentaireDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETUSERTYPEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 2;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.usernamestate);
            this.guna2Panel1.Controls.Add(this.type);
            this.guna2Panel1.Controls.Add(this.usertypegrid);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(972, 38);
            this.guna2Panel1.TabIndex = 0;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.type.Location = new System.Drawing.Point(583, 11);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(19, 15);
            this.type.TabIndex = 94;
            this.type.Text = "12";
            this.type.Visible = false;
            // 
            // usertypegrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.usertypegrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usertypegrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usertypegrid.BackgroundColor = System.Drawing.Color.White;
            this.usertypegrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertypegrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usertypegrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usertypegrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usertypegrid.ColumnHeadersHeight = 15;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usertypegrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.usertypegrid.EnableHeadersVisualStyles = false;
            this.usertypegrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.usertypegrid.Location = new System.Drawing.Point(276, 6);
            this.usertypegrid.Name = "usertypegrid";
            this.usertypegrid.RowHeadersVisible = false;
            this.usertypegrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usertypegrid.Size = new System.Drawing.Size(181, 20);
            this.usertypegrid.TabIndex = 93;
            this.usertypegrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.usertypegrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.usertypegrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.usertypegrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.usertypegrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.usertypegrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.usertypegrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.usertypegrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.usertypegrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usertypegrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertypegrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.usertypegrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.usertypegrid.ThemeStyle.HeaderStyle.Height = 15;
            this.usertypegrid.ThemeStyle.ReadOnly = false;
            this.usertypegrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.usertypegrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usertypegrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertypegrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.usertypegrid.ThemeStyle.RowsStyle.Height = 22;
            this.usertypegrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.usertypegrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.usertypegrid.Visible = false;
            // 
            // usernamestate
            // 
            this.usernamestate.AutoSize = true;
            this.usernamestate.BackColor = System.Drawing.Color.Transparent;
            this.usernamestate.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamestate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.usernamestate.Location = new System.Drawing.Point(210, 6);
            this.usernamestate.Name = "usernamestate";
            this.usernamestate.Size = new System.Drawing.Size(23, 20);
            this.usernamestate.TabIndex = 92;
            this.usernamestate.Text = "12";
            this.usernamestate.Visible = false;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(937, 0);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(896, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(35, 35);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Controls.Add(this.guna2Separator1);
            this.guna2Panel2.Controls.Add(this.guna2Button7);
            this.guna2Panel2.Controls.Add(this.guna2Button6);
            this.guna2Panel2.Controls.Add(this.guna2Button5);
            this.guna2Panel2.Controls.Add(this.guna2Button4);
            this.guna2Panel2.Controls.Add(this.guna2Button2);
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Controls.Add(this.btnusermang);
            this.guna2Panel2.Controls.Add(this.btnaddpat);
            this.guna2Panel2.Controls.Add(this.guna2Button3);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 38);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(188, 540);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ErrorImage = null;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Gestion_Cabinet_Dentair.Properties.Resources.Logotipo_clinica_dental_dinámico_color_verde_y_blanco_1_2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(146, 54);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 55);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(188, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // guna2Button7
            // 
            this.guna2Button7.Animated = true;
            this.guna2Button7.BorderRadius = 7;
            this.guna2Button7.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button7.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.guna2Button7.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button7.CustomImages.CheckedImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_shutdown_32px_1;
            this.guna2Button7.CustomImages.HoveredImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_shutdown_32px_2;
            this.guna2Button7.CustomImages.Image = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_shutdown_32px;
            this.guna2Button7.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.White;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button7.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button7.Location = new System.Drawing.Point(32, 493);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(114, 45);
            this.guna2Button7.TabIndex = 12;
            this.guna2Button7.Text = "Logout";
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.TextOffset = new System.Drawing.Point(31, 0);
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.Animated = true;
            this.guna2Button6.BorderRadius = 7;
            this.guna2Button6.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.guna2Button6.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button6.CustomImages.CheckedImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_payment_history_32px;
            this.guna2Button6.CustomImages.HoveredImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_payment_history_32px_2;
            this.guna2Button6.CustomImages.Image = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_payment_history_32px_1;
            this.guna2Button6.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.White;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button6.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button6.Location = new System.Drawing.Point(3, 275);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(182, 45);
            this.guna2Button6.TabIndex = 11;
            this.guna2Button6.Text = "Paiement";
            this.guna2Button6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.TextOffset = new System.Drawing.Point(31, 0);
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.Animated = true;
            this.guna2Button5.BorderRadius = 7;
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.guna2Button5.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button5.CustomImages.CheckedImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_pill_32px_2;
            this.guna2Button5.CustomImages.HoveredImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_pill_32px_1;
            this.guna2Button5.CustomImages.Image = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_pill_32px;
            this.guna2Button5.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.White;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button5.Location = new System.Drawing.Point(3, 377);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(182, 45);
            this.guna2Button5.TabIndex = 10;
            this.guna2Button5.Text = "Medicament";
            this.guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.TextOffset = new System.Drawing.Point(31, 0);
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BorderRadius = 7;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.guna2Button4.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.CustomImages.CheckedImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_health_checkup_32px;
            this.guna2Button4.CustomImages.HoveredImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_health_checkup_32px_2;
            this.guna2Button4.CustomImages.Image = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_health_checkup_32px_1;
            this.guna2Button4.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button4.Location = new System.Drawing.Point(3, 326);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(182, 45);
            this.guna2Button4.TabIndex = 9;
            this.guna2Button4.Text = "Gestion De Consultation";
            this.guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.TextOffset = new System.Drawing.Point(31, 0);
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 7;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.guna2Button2.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.CheckedImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_planner_64px_31;
            this.guna2Button2.CustomImages.HoveredImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_planner_64px_11;
            this.guna2Button2.CustomImages.Image = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_planner_64px_21;
            this.guna2Button2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button2.Location = new System.Drawing.Point(3, 224);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(182, 45);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Text = "Rendez-vous";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.TextOffset = new System.Drawing.Point(31, 0);
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.CheckedImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_management_32px_2;
            this.guna2Button1.CustomImages.HoveredImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_management_32px;
            this.guna2Button1.CustomImages.Image = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_management_32px_1;
            this.guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Location = new System.Drawing.Point(3, 173);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(182, 45);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Gestion Des Patients";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(31, 0);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnusermang
            // 
            this.btnusermang.Animated = true;
            this.btnusermang.BorderRadius = 7;
            this.btnusermang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnusermang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.btnusermang.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnusermang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnusermang.CustomImages.CheckedImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_users_settings_32px_2;
            this.btnusermang.CustomImages.HoveredImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_users_settings_32px;
            this.btnusermang.CustomImages.Image = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_users_settings_32px_1;
            this.btnusermang.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnusermang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnusermang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnusermang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnusermang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnusermang.FillColor = System.Drawing.Color.White;
            this.btnusermang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnusermang.ForeColor = System.Drawing.Color.DimGray;
            this.btnusermang.Location = new System.Drawing.Point(3, 428);
            this.btnusermang.Name = "btnusermang";
            this.btnusermang.Size = new System.Drawing.Size(182, 45);
            this.btnusermang.TabIndex = 6;
            this.btnusermang.Text = "Gestion Des Utilisateurs";
            this.btnusermang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnusermang.TextOffset = new System.Drawing.Point(31, 0);
            this.btnusermang.Click += new System.EventHandler(this.btnusermang_Click);
            // 
            // btnaddpat
            // 
            this.btnaddpat.Animated = true;
            this.btnaddpat.BorderRadius = 7;
            this.btnaddpat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnaddpat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.btnaddpat.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnaddpat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddpat.CustomImages.CheckedImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_add_user_male_32px_1;
            this.btnaddpat.CustomImages.HoveredImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_add_user_male_32px_2;
            this.btnaddpat.CustomImages.Image = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_add_user_male_32px;
            this.btnaddpat.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnaddpat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddpat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddpat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddpat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddpat.FillColor = System.Drawing.Color.White;
            this.btnaddpat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnaddpat.ForeColor = System.Drawing.Color.DimGray;
            this.btnaddpat.Location = new System.Drawing.Point(3, 122);
            this.btnaddpat.Name = "btnaddpat";
            this.btnaddpat.Size = new System.Drawing.Size(182, 45);
            this.btnaddpat.TabIndex = 5;
            this.btnaddpat.Text = "Ajouter Un Patient";
            this.btnaddpat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnaddpat.TextOffset = new System.Drawing.Point(31, 0);
            this.btnaddpat.Click += new System.EventHandler(this.btnaddpat_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderRadius = 7;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.guna2Button3.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.CheckedImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_align_top_120px_2;
            this.guna2Button3.CustomImages.HoveredImage = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_align_top_120px;
            this.guna2Button3.CustomImages.Image = global::Gestion_Cabinet_Dentair.Properties.Resources.icons8_align_top_120px_1;
            this.guna2Button3.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button3.Location = new System.Drawing.Point(3, 71);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(182, 45);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "Dashboard";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.TextOffset = new System.Drawing.Point(31, 0);
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // loadpanel
            // 
            this.loadpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadpanel.Location = new System.Drawing.Point(188, 38);
            this.loadpanel.Name = "loadpanel";
            this.loadpanel.Size = new System.Drawing.Size(784, 540);
            this.loadpanel.TabIndex = 2;
            // 
            // gestionCabinetDentaireDataSet10
            // 
            this.gestionCabinetDentaireDataSet10.DataSetName = "GestionCabinetDentaireDataSet10";
            this.gestionCabinetDentaireDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gETUSERTYPEBindingSource
            // 
            this.gETUSERTYPEBindingSource.DataMember = "GET_USER_TYPE";
            this.gETUSERTYPEBindingSource.DataSource = this.gestionCabinetDentaireDataSet10;
            // 
            // gET_USER_TYPETableAdapter
            // 
            this.gET_USER_TYPETableAdapter.ClearBeforeFill = true;
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(972, 578);
            this.Controls.Add(this.loadpanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CBD";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usertypegrid)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDentaireDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETUSERTYPEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnusermang;
        private Guna.UI2.WinForms.Guna2Button btnaddpat;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Panel loadpanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public System.Windows.Forms.Label usernamestate;
        private Guna.UI2.WinForms.Guna2DataGridView usertypegrid;
        public System.Windows.Forms.Label type;
        private System.Windows.Forms.BindingSource gETUSERTYPEBindingSource;
        private GestionCabinetDentaireDataSet10 gestionCabinetDentaireDataSet10;
        private GestionCabinetDentaireDataSet10TableAdapters.GET_USER_TYPETableAdapter gET_USER_TYPETableAdapter;
    }
}