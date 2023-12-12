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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutRapport));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.bindingSourceVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cmbVisiteur = new System.Windows.Forms.ComboBox();
            this.cmbMedecin = new System.Windows.Forms.ComboBox();
            this.bindingSourceMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.bindingSourceFamille = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorRapport = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingSourceRapport = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.bindingSourceOffrir = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFamille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorRapport)).BeginInit();
            this.bindingNavigatorRapport.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Famille de médicament : ";
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
            // bindingSourceVisiteur
            // 
            this.bindingSourceVisiteur.DataSource = typeof(gsb.visiteur);
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
            // cmbFamille
            // 
            this.cmbFamille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFamille, "id", true));
            this.cmbFamille.DataSource = this.bindingSourceFamille;
            this.cmbFamille.DisplayMember = "libelle";
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Location = new System.Drawing.Point(230, 212);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(121, 24);
            this.cmbFamille.TabIndex = 15;
            // 
            // bindingSourceFamille
            // 
            this.bindingSourceFamille.DataSource = typeof(gsb.famille);
            // 
            // bindingNavigatorRapport
            // 
            this.bindingNavigatorRapport.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorRapport.BindingSource = this.bindingSourceRapport;
            this.bindingNavigatorRapport.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorRapport.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorRapport.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorRapport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorRapport.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorRapport.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorRapport.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorRapport.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorRapport.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorRapport.Name = "bindingNavigatorRapport";
            this.bindingNavigatorRapport.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorRapport.Size = new System.Drawing.Size(800, 27);
            this.bindingNavigatorRapport.TabIndex = 16;
            this.bindingNavigatorRapport.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingSourceRapport
            // 
            this.bindingSourceRapport.DataSource = typeof(gsb.rapport);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 19;
            // 
            // bindingSourceOffrir
            // 
            this.bindingSourceOffrir.DataSource = typeof(gsb.offrir);
            // 
            // frmAjoutRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigatorRapport);
            this.Controls.Add(this.cmbFamille);
            this.Controls.Add(this.cmbMedecin);
            this.Controls.Add(this.cmbVisiteur);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAjoutRapport";
            this.Text = "l";
            this.Load += new System.EventHandler(this.frmAjoutRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFamille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorRapport)).EndInit();
            this.bindingNavigatorRapport.ResumeLayout(false);
            this.bindingNavigatorRapport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOffrir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox cmbVisiteur;
        private System.Windows.Forms.ComboBox cmbMedecin;
        private System.Windows.Forms.ComboBox cmbFamille;
        private System.Windows.Forms.BindingNavigator bindingNavigatorRapport;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSourceVisiteur;
        private System.Windows.Forms.BindingSource bindingSourceMedecin;
        private System.Windows.Forms.BindingSource bindingSourceFamille;
        private System.Windows.Forms.BindingSource bindingSourceRapport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.BindingSource bindingSourceOffrir;
    }
}