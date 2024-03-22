namespace gsb
{
    partial class frmAjoutRapport
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cmbVisiteur = new System.Windows.Forms.ComboBox();
            this.bindingSourceVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMedecin = new System.Windows.Forms.ComboBox();
            this.bindingSourceMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.bindingSourceMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSourceRapport = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceOffrir = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMedicament = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOffrir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visiteurs : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Médecins : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Motif : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bilan :";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(159, 323);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(100, 22);
            this.txtMotif.TabIndex = 10;
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(162, 366);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(100, 22);
            this.txtBilan.TabIndex = 11;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(162, 273);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 12;
            // 
            // cmbVisiteur
            // 
            this.cmbVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceVisiteur, "id", true));
            this.cmbVisiteur.DataSource = this.bindingSourceVisiteur;
            this.cmbVisiteur.DisplayMember = "id";
            this.cmbVisiteur.FormattingEnabled = true;
            this.cmbVisiteur.Location = new System.Drawing.Point(162, 104);
            this.cmbVisiteur.Name = "cmbVisiteur";
            this.cmbVisiteur.Size = new System.Drawing.Size(121, 24);
            this.cmbVisiteur.TabIndex = 13;
            this.cmbVisiteur.SelectedIndexChanged += new System.EventHandler(this.cmbVisiteur_SelectedIndexChanged);
            // 
            // bindingSourceVisiteur
            // 
            this.bindingSourceVisiteur.DataSource = typeof(gsb.visiteur);
            // 
            // cmbMedecin
            // 
            this.cmbMedecin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMedecin, "id", true));
            this.cmbMedecin.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSourceMedecin, "id", true));
            this.cmbMedecin.DataSource = this.bindingSourceMedecin;
            this.cmbMedecin.DisplayMember = "id";
            this.cmbMedecin.FormattingEnabled = true;
            this.cmbMedecin.Location = new System.Drawing.Point(162, 159);
            this.cmbMedecin.Name = "cmbMedecin";
            this.cmbMedecin.Size = new System.Drawing.Size(121, 24);
            this.cmbMedecin.TabIndex = 14;
            // 
            // bindingSourceMedecin
            // 
            this.bindingSourceMedecin.DataSource = typeof(gsb.medecin);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(58, 62);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(21, 16);
            this.id.TabIndex = 18;
            this.id.Text = "Id:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(159, 55);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 19;
            // 
            // bindingSourceMedicament
            // 
            this.bindingSourceMedicament.DataSource = typeof(gsb.medicament);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Famille medicament:";
            // 
            // bindingSourceRapport
            // 
            this.bindingSourceRapport.DataSource = typeof(gsb.rapport);
            // 
            // bindingSourceOffrir
            // 
            this.bindingSourceOffrir.DataSource = typeof(gsb.offrir);
            // 
            // cmbMedicament
            // 
            this.cmbMedicament.DataSource = this.bindingSourceMedicament;
            this.cmbMedicament.DisplayMember = "idFamille";
            this.cmbMedicament.FormattingEnabled = true;
            this.cmbMedicament.Location = new System.Drawing.Point(226, 223);
            this.cmbMedicament.Name = "cmbMedicament";
            this.cmbMedicament.Size = new System.Drawing.Size(121, 24);
            this.cmbMedicament.TabIndex = 22;
            this.cmbMedicament.SelectedIndexChanged += new System.EventHandler(this.cmbMedicament_SelectedIndexChanged);
            // 
            // frmAjoutRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.cmbMedicament);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbMedecin);
            this.Controls.Add(this.cmbVisiteur);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAjoutRapport";
            this.Text = "l";
            this.Load += new System.EventHandler(this.frmAjoutRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOffrir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox cmbVisiteur;
        private System.Windows.Forms.ComboBox cmbMedecin;
        private System.Windows.Forms.BindingSource bindingSourceVisiteur;
        private System.Windows.Forms.BindingSource bindingSourceMedecin;
        private System.Windows.Forms.BindingSource bindingSourceMedicament;
        private System.Windows.Forms.BindingSource bindingSourceRapport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.BindingSource bindingSourceOffrir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMedicament;
    }
}