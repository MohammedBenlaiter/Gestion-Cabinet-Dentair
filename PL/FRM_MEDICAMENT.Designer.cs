namespace Gestion_Cabinet_Dentair.PL
{
    partial class FRM_MEDICAMENT
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.deleteuser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.medicamenttable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.medicamentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nommedacementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gETALLMEDICAMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCabinetDentaireDataSet5 = new Gestion_Cabinet_Dentair.GestionCabinetDentaireDataSet5();
            this.gET_ALL_MEDICAMENTTableAdapter = new Gestion_Cabinet_Dentair.GestionCabinetDentaireDataSet5TableAdapters.GET_ALL_MEDICAMENTTableAdapter();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.NomMedicament = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicamenttable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETALLMEDICAMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDentaireDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 21);
            this.label1.TabIndex = 12;
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
            this.txtsearch.Location = new System.Drawing.Point(13, 33);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderText = "";
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(426, 36);
            this.txtsearch.TabIndex = 11;
            // 
            // deleteuser
            // 
            this.deleteuser.Animated = true;
            this.deleteuser.BorderRadius = 8;
            this.deleteuser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteuser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.deleteuser.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.deleteuser.ForeColor = System.Drawing.Color.White;
            this.deleteuser.IndicateFocus = true;
            this.deleteuser.Location = new System.Drawing.Point(204, 479);
            this.deleteuser.Name = "deleteuser";
            this.deleteuser.Size = new System.Drawing.Size(180, 45);
            this.deleteuser.TabIndex = 28;
            this.deleteuser.Text = "Supprimer";
            this.deleteuser.Click += new System.EventHandler(this.deleteuser_Click);
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.FillThickness = 2;
            this.guna2Separator3.Location = new System.Drawing.Point(1, 461);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(783, 12);
            this.guna2Separator3.TabIndex = 26;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillThickness = 2;
            this.guna2Separator2.Location = new System.Drawing.Point(1, 87);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(47, 10);
            this.guna2Separator2.TabIndex = 25;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(203, 87);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(581, 10);
            this.guna2Separator1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(45, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "List Des Médicament";
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
            this.guna2Button1.Location = new System.Drawing.Point(406, 479);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 29;
            this.guna2Button1.Text = "Rafraîchir";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // medicamenttable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.medicamenttable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.medicamenttable.AutoGenerateColumns = false;
            this.medicamenttable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicamenttable.BackgroundColor = System.Drawing.Color.White;
            this.medicamenttable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicamenttable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medicamenttable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicamenttable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.medicamenttable.ColumnHeadersHeight = 21;
            this.medicamenttable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicamentIDDataGridViewTextBoxColumn,
            this.nommedacementDataGridViewTextBoxColumn});
            this.medicamenttable.DataSource = this.gETALLMEDICAMENTBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicamenttable.DefaultCellStyle = dataGridViewCellStyle3;
            this.medicamenttable.EnableHeadersVisualStyles = false;
            this.medicamenttable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicamenttable.Location = new System.Drawing.Point(12, 103);
            this.medicamenttable.Name = "medicamenttable";
            this.medicamenttable.RowHeadersVisible = false;
            this.medicamenttable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicamenttable.Size = new System.Drawing.Size(380, 352);
            this.medicamenttable.TabIndex = 30;
            this.medicamenttable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.medicamenttable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.medicamenttable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.medicamenttable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.medicamenttable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.medicamenttable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.medicamenttable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicamenttable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.medicamenttable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.medicamenttable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.medicamenttable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.medicamenttable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.medicamenttable.ThemeStyle.HeaderStyle.Height = 21;
            this.medicamenttable.ThemeStyle.ReadOnly = false;
            this.medicamenttable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.medicamenttable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medicamenttable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.medicamenttable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.medicamenttable.ThemeStyle.RowsStyle.Height = 22;
            this.medicamenttable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicamenttable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // medicamentIDDataGridViewTextBoxColumn
            // 
            this.medicamentIDDataGridViewTextBoxColumn.DataPropertyName = "Medicament_ID";
            this.medicamentIDDataGridViewTextBoxColumn.HeaderText = "Medicament_ID";
            this.medicamentIDDataGridViewTextBoxColumn.Name = "medicamentIDDataGridViewTextBoxColumn";
            this.medicamentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nommedacementDataGridViewTextBoxColumn
            // 
            this.nommedacementDataGridViewTextBoxColumn.DataPropertyName = "Nom_medacement";
            this.nommedacementDataGridViewTextBoxColumn.HeaderText = "Nom_medacement";
            this.nommedacementDataGridViewTextBoxColumn.Name = "nommedacementDataGridViewTextBoxColumn";
            // 
            // gETALLMEDICAMENTBindingSource
            // 
            this.gETALLMEDICAMENTBindingSource.DataMember = "GET_ALL_MEDICAMENT";
            this.gETALLMEDICAMENTBindingSource.DataSource = this.gestionCabinetDentaireDataSet5;
            // 
            // gestionCabinetDentaireDataSet5
            // 
            this.gestionCabinetDentaireDataSet5.DataSetName = "GestionCabinetDentaireDataSet5";
            this.gestionCabinetDentaireDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gET_ALL_MEDICAMENTTableAdapter
            // 
            this.gET_ALL_MEDICAMENTTableAdapter.ClearBeforeFill = true;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(398, 103);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 352);
            this.guna2VSeparator1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(411, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ajouter Un Médicament";
            // 
            // NomMedicament
            // 
            this.NomMedicament.Animated = true;
            this.NomMedicament.BorderRadius = 8;
            this.NomMedicament.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.NomMedicament.BorderThickness = 2;
            this.NomMedicament.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NomMedicament.DefaultText = "";
            this.NomMedicament.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NomMedicament.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NomMedicament.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomMedicament.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomMedicament.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NomMedicament.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomMedicament.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NomMedicament.Location = new System.Drawing.Point(415, 179);
            this.NomMedicament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NomMedicament.Name = "NomMedicament";
            this.NomMedicament.PasswordChar = '\0';
            this.NomMedicament.PlaceholderText = "";
            this.NomMedicament.SelectedText = "";
            this.NomMedicament.Size = new System.Drawing.Size(226, 36);
            this.NomMedicament.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(422, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 21);
            this.label4.TabIndex = 76;
            this.label4.Text = "Nom De Medicament";
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.FillThickness = 2;
            this.guna2Separator4.Location = new System.Drawing.Point(594, 112);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(190, 12);
            this.guna2Separator4.TabIndex = 78;
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.FillThickness = 2;
            this.guna2Separator5.Location = new System.Drawing.Point(406, 233);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(378, 12);
            this.guna2Separator5.TabIndex = 79;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderRadius = 8;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.guna2Button3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.IndicateFocus = true;
            this.guna2Button3.Location = new System.Drawing.Point(652, 170);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(120, 45);
            this.guna2Button3.TabIndex = 80;
            this.guna2Button3.Text = "Ajouter";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // FRM_MEDICAMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Separator5);
            this.Controls.Add(this.guna2Separator4);
            this.Controls.Add(this.NomMedicament);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.medicamenttable);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.deleteuser);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_MEDICAMENT";
            this.Text = "FRM_MEDICAMENT";
            this.Load += new System.EventHandler(this.FRM_MEDICAMENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicamenttable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETALLMEDICAMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDentaireDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Button deleteuser;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView medicamenttable;
        private GestionCabinetDentaireDataSet5 gestionCabinetDentaireDataSet5;
        private System.Windows.Forms.BindingSource gETALLMEDICAMENTBindingSource;
        private GestionCabinetDentaireDataSet5TableAdapters.GET_ALL_MEDICAMENTTableAdapter gET_ALL_MEDICAMENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nommedacementDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox NomMedicament;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}