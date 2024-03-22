namespace gsb
{
    partial class frmRechercheRapport
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRapport = new System.Windows.Forms.DataGridView();
            this.cmbVisiteur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateRapport = new System.Windows.Forms.DateTimePicker();
            this.bindingSourceVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offrirsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceRapport = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdVisiteur : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Recherche";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRapport
            // 
            this.dgvRapport.AutoGenerateColumns = false;
            this.dgvRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.motifDataGridViewTextBoxColumn,
            this.bilanDataGridViewTextBoxColumn,
            this.idVisiteurDataGridViewTextBoxColumn,
            this.idMedecinDataGridViewTextBoxColumn,
            this.medecinDataGridViewTextBoxColumn,
            this.offrirsDataGridViewTextBoxColumn,
            this.visiteurDataGridViewTextBoxColumn});
            this.dgvRapport.DataSource = this.bindingSourceRapport;
            this.dgvRapport.Location = new System.Drawing.Point(57, 211);
            this.dgvRapport.Name = "dgvRapport";
            this.dgvRapport.RowHeadersWidth = 51;
            this.dgvRapport.RowTemplate.Height = 24;
            this.dgvRapport.Size = new System.Drawing.Size(725, 150);
            this.dgvRapport.TabIndex = 3;
            // 
            // cmbVisiteur
            // 
            this.cmbVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceVisiteur, "id", true));
            this.cmbVisiteur.DataSource = this.bindingSourceVisiteur;
            this.cmbVisiteur.DisplayMember = "id";
            this.cmbVisiteur.FormattingEnabled = true;
            this.cmbVisiteur.Location = new System.Drawing.Point(168, 78);
            this.cmbVisiteur.Name = "cmbVisiteur";
            this.cmbVisiteur.Size = new System.Drawing.Size(93, 24);
            this.cmbVisiteur.TabIndex = 4;
            this.cmbVisiteur.ValueMember = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date :";
            // 
            // dateRapport
            // 
            this.dateRapport.Location = new System.Drawing.Point(376, 83);
            this.dateRapport.Name = "dateRapport";
            this.dateRapport.Size = new System.Drawing.Size(257, 22);
            this.dateRapport.TabIndex = 7;
            // 
            // bindingSourceVisiteur
            // 
            this.bindingSourceVisiteur.DataSource = typeof(gsb.visiteur);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // motifDataGridViewTextBoxColumn
            // 
            this.motifDataGridViewTextBoxColumn.DataPropertyName = "motif";
            this.motifDataGridViewTextBoxColumn.HeaderText = "motif";
            this.motifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motifDataGridViewTextBoxColumn.Name = "motifDataGridViewTextBoxColumn";
            this.motifDataGridViewTextBoxColumn.Width = 125;
            // 
            // bilanDataGridViewTextBoxColumn
            // 
            this.bilanDataGridViewTextBoxColumn.DataPropertyName = "bilan";
            this.bilanDataGridViewTextBoxColumn.HeaderText = "bilan";
            this.bilanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bilanDataGridViewTextBoxColumn.Name = "bilanDataGridViewTextBoxColumn";
            this.bilanDataGridViewTextBoxColumn.Width = 125;
            // 
            // idVisiteurDataGridViewTextBoxColumn
            // 
            this.idVisiteurDataGridViewTextBoxColumn.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idVisiteurDataGridViewTextBoxColumn.Name = "idVisiteurDataGridViewTextBoxColumn";
            this.idVisiteurDataGridViewTextBoxColumn.Width = 125;
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            this.idMedecinDataGridViewTextBoxColumn.Width = 125;
            // 
            // medecinDataGridViewTextBoxColumn
            // 
            this.medecinDataGridViewTextBoxColumn.DataPropertyName = "medecin";
            this.medecinDataGridViewTextBoxColumn.HeaderText = "medecin";
            this.medecinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medecinDataGridViewTextBoxColumn.Name = "medecinDataGridViewTextBoxColumn";
            this.medecinDataGridViewTextBoxColumn.Width = 125;
            // 
            // offrirsDataGridViewTextBoxColumn
            // 
            this.offrirsDataGridViewTextBoxColumn.DataPropertyName = "offrirs";
            this.offrirsDataGridViewTextBoxColumn.HeaderText = "offrirs";
            this.offrirsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.offrirsDataGridViewTextBoxColumn.Name = "offrirsDataGridViewTextBoxColumn";
            this.offrirsDataGridViewTextBoxColumn.Width = 125;
            // 
            // visiteurDataGridViewTextBoxColumn
            // 
            this.visiteurDataGridViewTextBoxColumn.DataPropertyName = "visiteur";
            this.visiteurDataGridViewTextBoxColumn.HeaderText = "visiteur";
            this.visiteurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.visiteurDataGridViewTextBoxColumn.Name = "visiteurDataGridViewTextBoxColumn";
            this.visiteurDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceRapport
            // 
            this.bindingSourceRapport.DataSource = typeof(gsb.rapport);
            // 
            // frmRechercheRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.dateRapport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVisiteur);
            this.Controls.Add(this.dgvRapport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmRechercheRapport";
            this.Text = "frmRechercheRapport";
            this.Load += new System.EventHandler(this.frmRechercheRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSourceRapport;
        private System.Windows.Forms.DataGridView dgvRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrirsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbVisiteur;
        private System.Windows.Forms.BindingSource bindingSourceVisiteur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateRapport;
    }
}