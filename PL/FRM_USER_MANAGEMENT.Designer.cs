namespace Gestion_Cabinet_Dentair.PL
{
    partial class FRM_USER_MANAGEMENT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.userview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.utilisateurIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDutilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motDePasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDutilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gETALLUSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCabinetDentaireDataSet1 = new Gestion_Cabinet_Dentair.GestionCabinetDentaireDataSet1();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteuser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.modifuserbtn = new Guna.UI2.WinForms.Guna2Button();
            this.gET_ALL_USERSTableAdapter = new Gestion_Cabinet_Dentair.GestionCabinetDentaireDataSet1TableAdapters.GET_ALL_USERSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETALLUSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDentaireDataSet1)).BeginInit();
            this.SuspendLayout();
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
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.FillThickness = 2;
            this.guna2Separator3.Location = new System.Drawing.Point(1, 457);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(783, 12);
            this.guna2Separator3.TabIndex = 18;
            // 
            // userview
            // 
            this.userview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userview.AutoGenerateColumns = false;
            this.userview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userview.BackgroundColor = System.Drawing.Color.White;
            this.userview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userview.ColumnHeadersHeight = 47;
            this.userview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.utilisateurIDDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.nomDutilisateurDataGridViewTextBoxColumn,
            this.motDePasseDataGridViewTextBoxColumn,
            this.typeDutilisateurDataGridViewTextBoxColumn});
            this.userview.DataSource = this.gETALLUSERSBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userview.DefaultCellStyle = dataGridViewCellStyle3;
            this.userview.EnableHeadersVisualStyles = false;
            this.userview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userview.Location = new System.Drawing.Point(1, 96);
            this.userview.Name = "userview";
            this.userview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.userview.RowHeadersVisible = false;
            this.userview.RowTemplate.Height = 35;
            this.userview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userview.Size = new System.Drawing.Size(783, 355);
            this.userview.TabIndex = 17;
            this.userview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.userview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.userview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.userview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.userview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.userview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.userview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.userview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userview.ThemeStyle.HeaderStyle.Height = 47;
            this.userview.ThemeStyle.ReadOnly = false;
            this.userview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.userview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.userview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userview.ThemeStyle.RowsStyle.Height = 35;
            this.userview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // utilisateurIDDataGridViewTextBoxColumn
            // 
            this.utilisateurIDDataGridViewTextBoxColumn.DataPropertyName = "Utilisateur_ID";
            this.utilisateurIDDataGridViewTextBoxColumn.HeaderText = "Utilisateur_ID";
            this.utilisateurIDDataGridViewTextBoxColumn.Name = "utilisateurIDDataGridViewTextBoxColumn";
            this.utilisateurIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // nomDutilisateurDataGridViewTextBoxColumn
            // 
            this.nomDutilisateurDataGridViewTextBoxColumn.DataPropertyName = "NomDutilisateur";
            this.nomDutilisateurDataGridViewTextBoxColumn.HeaderText = "NomDutilisateur";
            this.nomDutilisateurDataGridViewTextBoxColumn.Name = "nomDutilisateurDataGridViewTextBoxColumn";
            // 
            // motDePasseDataGridViewTextBoxColumn
            // 
            this.motDePasseDataGridViewTextBoxColumn.DataPropertyName = "MotDePasse";
            this.motDePasseDataGridViewTextBoxColumn.HeaderText = "MotDePasse";
            this.motDePasseDataGridViewTextBoxColumn.Name = "motDePasseDataGridViewTextBoxColumn";
            // 
            // typeDutilisateurDataGridViewTextBoxColumn
            // 
            this.typeDutilisateurDataGridViewTextBoxColumn.DataPropertyName = "TypeDutilisateur";
            this.typeDutilisateurDataGridViewTextBoxColumn.HeaderText = "TypeDutilisateur";
            this.typeDutilisateurDataGridViewTextBoxColumn.Name = "typeDutilisateurDataGridViewTextBoxColumn";
            // 
            // gETALLUSERSBindingSource
            // 
            this.gETALLUSERSBindingSource.DataMember = "GET_ALL_USERS";
            this.gETALLUSERSBindingSource.DataSource = this.gestionCabinetDentaireDataSet1;
            // 
            // gestionCabinetDentaireDataSet1
            // 
            this.gestionCabinetDentaireDataSet1.DataSetName = "GestionCabinetDentaireDataSet1";
            this.gestionCabinetDentaireDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillThickness = 2;
            this.guna2Separator2.Location = new System.Drawing.Point(1, 83);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(47, 10);
            this.guna2Separator2.TabIndex = 16;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(192, 83);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(592, 10);
            this.guna2Separator1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "List Des Utilisateurs";
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
            this.deleteuser.Location = new System.Drawing.Point(487, 475);
            this.deleteuser.Name = "deleteuser";
            this.deleteuser.Size = new System.Drawing.Size(180, 45);
            this.deleteuser.TabIndex = 20;
            this.deleteuser.Text = "Supprimer";
            this.deleteuser.Click += new System.EventHandler(this.deleteuser_Click);
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
            this.guna2Button2.Location = new System.Drawing.Point(79, 475);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 19;
            this.guna2Button2.Text = "Créer Un Utilisateur";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // modifuserbtn
            // 
            this.modifuserbtn.Animated = true;
            this.modifuserbtn.BorderRadius = 8;
            this.modifuserbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modifuserbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modifuserbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modifuserbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modifuserbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.modifuserbtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.modifuserbtn.ForeColor = System.Drawing.Color.White;
            this.modifuserbtn.IndicateFocus = true;
            this.modifuserbtn.Location = new System.Drawing.Point(284, 475);
            this.modifuserbtn.Name = "modifuserbtn";
            this.modifuserbtn.Size = new System.Drawing.Size(180, 45);
            this.modifuserbtn.TabIndex = 22;
            this.modifuserbtn.Text = "Modifier";
            this.modifuserbtn.Click += new System.EventHandler(this.modifuserbtn_Click);
            // 
            // gET_ALL_USERSTableAdapter
            // 
            this.gET_ALL_USERSTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_USER_MANAGEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.modifuserbtn);
            this.Controls.Add(this.deleteuser);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.userview);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_USER_MANAGEMENT";
            this.Text = "FRM_USER_MANAGEMENT";
            this.Load += new System.EventHandler(this.FRM_USER_MANAGEMENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETALLUSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCabinetDentaireDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        public Guna.UI2.WinForms.Guna2DataGridView userview;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button deleteuser;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button modifuserbtn;
        private GestionCabinetDentaireDataSet1 gestionCabinetDentaireDataSet1;
        private System.Windows.Forms.BindingSource gETALLUSERSBindingSource;
        private GestionCabinetDentaireDataSet1TableAdapters.GET_ALL_USERSTableAdapter gET_ALL_USERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilisateurIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDutilisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motDePasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDutilisateurDataGridViewTextBoxColumn;
    }
}