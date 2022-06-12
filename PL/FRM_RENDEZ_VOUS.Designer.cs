namespace Gestion_Cabinet_Dentair.PL
{
    partial class FRM_RENDEZ_VOUS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnmodf = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gestionCabinetDentaireDataSet6 = new Gestion_Cabinet_Dentair.GestionCabinetDentaireDataSet6();
            this.gETALLRDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_ALL_RDVTableAdapter = new Gestion_Cabinet_Dentair.GestionCabinetDentaireDataSet6TableAdapters.GET_ALL_RDVTableAdapter();
            this.Rdvview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.gestionCabinetDentaireDataSet9 = new Gestion_Cabinet_Dentair.GestionCabinetDentaireDataSet9();
            this.gETALLRDVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gET_ALL_RDVTableAdapter1 = new Gestion_Cabinet_Dentair.GestionCabinetDentaireDataSet9TableAdapters.GET_ALL_RDVTableAdapter();
            this.rdvIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeReservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDeRendezVousDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raisonDeVenirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecinIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDentaireDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETALLRDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rdvview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDentaireDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETALLRDVBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(1, 75);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(785, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillThickness = 2;
            this.guna2Separator2.Location = new System.Drawing.Point(-1, 468);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(785, 10);
            this.guna2Separator2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Entrez Le Mot Que Vous Souhaitez Rechercher";
            // 
            // txtsearch
            // 
            this.txtsearch.Animated = true;
            this.txtsearch.BorderRadius = 8;
            this.txtsearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtsearch.BorderThickness = 2;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.Location = new System.Drawing.Point(13, 32);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderText = "";
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(426, 36);
            this.txtsearch.TabIndex = 9;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
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
            this.btnmodf.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnmodf.ForeColor = System.Drawing.Color.White;
            this.btnmodf.IndicateFocus = true;
            this.btnmodf.Location = new System.Drawing.Point(86, 484);
            this.btnmodf.Name = "btnmodf";
            this.btnmodf.Size = new System.Drawing.Size(180, 45);
            this.btnmodf.TabIndex = 17;
            this.btnmodf.Text = "Ajouter Un Rendez Vous";
            this.btnmodf.Click += new System.EventHandler(this.btnmodf_Click);
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
            this.guna2Button1.Location = new System.Drawing.Point(295, 484);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Modifier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(43, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Liste Des Rendez Vous";
            // 
            // gestionCabinetDentaireDataSet6
            // 
            this.gestionCabinetDentaireDataSet6.DataSetName = "GestionCabinetDentaireDataSet6";
            this.gestionCabinetDentaireDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gETALLRDVBindingSource
            // 
            this.gETALLRDVBindingSource.DataMember = "GET_ALL_RDV";
            this.gETALLRDVBindingSource.DataSource = this.gestionCabinetDentaireDataSet6;
            // 
            // gET_ALL_RDVTableAdapter
            // 
            this.gET_ALL_RDVTableAdapter.ClearBeforeFill = true;
            // 
            // Rdvview
            // 
            this.Rdvview.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Rdvview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Rdvview.AutoGenerateColumns = false;
            this.Rdvview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Rdvview.BackgroundColor = System.Drawing.Color.White;
            this.Rdvview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rdvview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Rdvview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Rdvview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Rdvview.ColumnHeadersHeight = 47;
            this.Rdvview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rdvIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.dateDeReservationDataGridViewTextBoxColumn,
            this.heureDeRendezVousDataGridViewTextBoxColumn,
            this.raisonDeVenirDataGridViewTextBoxColumn,
            this.medecinIDDataGridViewTextBoxColumn,
            this.nom1DataGridViewTextBoxColumn,
            this.prenom1DataGridViewTextBoxColumn});
            this.Rdvview.DataSource = this.gETALLRDVBindingSource1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Rdvview.DefaultCellStyle = dataGridViewCellStyle7;
            this.Rdvview.EnableHeadersVisualStyles = false;
            this.Rdvview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Rdvview.Location = new System.Drawing.Point(1, 91);
            this.Rdvview.Name = "Rdvview";
            this.Rdvview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Rdvview.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Rdvview.RowHeadersVisible = false;
            this.Rdvview.RowTemplate.Height = 35;
            this.Rdvview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Rdvview.Size = new System.Drawing.Size(783, 371);
            this.Rdvview.TabIndex = 20;
            this.Rdvview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Rdvview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Rdvview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Rdvview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Rdvview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Rdvview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Rdvview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Rdvview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Rdvview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Rdvview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Rdvview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Rdvview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Rdvview.ThemeStyle.HeaderStyle.Height = 47;
            this.Rdvview.ThemeStyle.ReadOnly = false;
            this.Rdvview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Rdvview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Rdvview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Rdvview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Rdvview.ThemeStyle.RowsStyle.Height = 35;
            this.Rdvview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Rdvview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.guna2Button2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.IndicateFocus = true;
            this.guna2Button2.Location = new System.Drawing.Point(497, 484);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 21;
            this.guna2Button2.Text = "Supprimer";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // gestionCabinetDentaireDataSet9
            // 
            this.gestionCabinetDentaireDataSet9.DataSetName = "GestionCabinetDentaireDataSet9";
            this.gestionCabinetDentaireDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gETALLRDVBindingSource1
            // 
            this.gETALLRDVBindingSource1.DataMember = "GET_ALL_RDV";
            this.gETALLRDVBindingSource1.DataSource = this.gestionCabinetDentaireDataSet9;
            // 
            // gET_ALL_RDVTableAdapter1
            // 
            this.gET_ALL_RDVTableAdapter1.ClearBeforeFill = true;
            // 
            // rdvIDDataGridViewTextBoxColumn
            // 
            this.rdvIDDataGridViewTextBoxColumn.DataPropertyName = "Rdv_ID";
            this.rdvIDDataGridViewTextBoxColumn.HeaderText = "Rdv_ID";
            this.rdvIDDataGridViewTextBoxColumn.Name = "rdvIDDataGridViewTextBoxColumn";
            this.rdvIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // dateDeReservationDataGridViewTextBoxColumn
            // 
            this.dateDeReservationDataGridViewTextBoxColumn.DataPropertyName = "DateDeReservation";
            this.dateDeReservationDataGridViewTextBoxColumn.HeaderText = "DateDeReservation";
            this.dateDeReservationDataGridViewTextBoxColumn.Name = "dateDeReservationDataGridViewTextBoxColumn";
            // 
            // heureDeRendezVousDataGridViewTextBoxColumn
            // 
            this.heureDeRendezVousDataGridViewTextBoxColumn.DataPropertyName = "HeureDeRendezVous";
            this.heureDeRendezVousDataGridViewTextBoxColumn.HeaderText = "HeureDeRendezVous";
            this.heureDeRendezVousDataGridViewTextBoxColumn.Name = "heureDeRendezVousDataGridViewTextBoxColumn";
            // 
            // raisonDeVenirDataGridViewTextBoxColumn
            // 
            this.raisonDeVenirDataGridViewTextBoxColumn.DataPropertyName = "RaisonDeVenir";
            this.raisonDeVenirDataGridViewTextBoxColumn.HeaderText = "RaisonDeVenir";
            this.raisonDeVenirDataGridViewTextBoxColumn.Name = "raisonDeVenirDataGridViewTextBoxColumn";
            // 
            // medecinIDDataGridViewTextBoxColumn
            // 
            this.medecinIDDataGridViewTextBoxColumn.DataPropertyName = "Medecin_ID";
            this.medecinIDDataGridViewTextBoxColumn.HeaderText = "Medecin_ID";
            this.medecinIDDataGridViewTextBoxColumn.Name = "medecinIDDataGridViewTextBoxColumn";
            this.medecinIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nom1DataGridViewTextBoxColumn
            // 
            this.nom1DataGridViewTextBoxColumn.DataPropertyName = "Nom de medecin";
            this.nom1DataGridViewTextBoxColumn.HeaderText = "Nom de medecin";
            this.nom1DataGridViewTextBoxColumn.Name = "nom1DataGridViewTextBoxColumn";
            // 
            // prenom1DataGridViewTextBoxColumn
            // 
            this.prenom1DataGridViewTextBoxColumn.DataPropertyName = "Prenom1";
            this.prenom1DataGridViewTextBoxColumn.HeaderText = "Prenom med";
            this.prenom1DataGridViewTextBoxColumn.Name = "prenom1DataGridViewTextBoxColumn";
            // 
            // FRM_RENDEZ_VOUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.Rdvview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnmodf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_RENDEZ_VOUS";
            this.Text = "FRM_RENDEZ_VOUS";
            this.Load += new System.EventHandler(this.FRM_RENDEZ_VOUS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDentaireDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETALLRDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rdvview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDentaireDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETALLRDVBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        public Guna.UI2.WinForms.Guna2Button btnmodf;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private GestionCabinetDentaireDataSet6 gestionCabinetDentaireDataSet6;
        private System.Windows.Forms.BindingSource gETALLRDVBindingSource;
        private GestionCabinetDentaireDataSet6TableAdapters.GET_ALL_RDVTableAdapter gET_ALL_RDVTableAdapter;
        public Guna.UI2.WinForms.Guna2DataGridView Rdvview;
        public Guna.UI2.WinForms.Guna2Button guna2Button2;
        private GestionCabinetDentaireDataSet9 gestionCabinetDentaireDataSet9;
        private System.Windows.Forms.BindingSource gETALLRDVBindingSource1;
        private GestionCabinetDentaireDataSet9TableAdapters.GET_ALL_RDVTableAdapter gET_ALL_RDVTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdvIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeReservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDeRendezVousDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raisonDeVenirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecinIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom1DataGridViewTextBoxColumn;
    }
}