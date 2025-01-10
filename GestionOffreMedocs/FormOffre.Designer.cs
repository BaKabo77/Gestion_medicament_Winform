namespace GestionOffreMedocs
{
    partial class FormOffre
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
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.familleSrc = new System.Windows.Forms.BindingSource(this.components);
            this.labelMedoc = new System.Windows.Forms.Label();
            this.cmbMedoc = new System.Windows.Forms.ComboBox();
            this.MedocSrc = new System.Windows.Forms.BindingSource(this.components);
            this.AfficherBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.familleSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedocSrc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectionner une famille de medicaments";
            // 
            // cmbFamille
            // 
            this.cmbFamille.DataSource = this.familleSrc;
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Location = new System.Drawing.Point(453, 156);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(121, 21);
            this.cmbFamille.TabIndex = 1;
            this.cmbFamille.SelectedValueChanged += new System.EventHandler(this.cmbFamille_SelectedValueChanged);
            // 
            // familleSrc
            // 
            this.familleSrc.DataSource = typeof(GestionOffreMedocs.famille);
            // 
            // labelMedoc
            // 
            this.labelMedoc.AutoSize = true;
            this.labelMedoc.Location = new System.Drawing.Point(211, 243);
            this.labelMedoc.Name = "labelMedoc";
            this.labelMedoc.Size = new System.Drawing.Size(141, 13);
            this.labelMedoc.TabIndex = 2;
            this.labelMedoc.Text = "Selectionner un médicament";
            this.labelMedoc.Visible = false;
            // 
            // cmbMedoc
            // 
            this.cmbMedoc.FormattingEnabled = true;
            this.cmbMedoc.Location = new System.Drawing.Point(453, 243);
            this.cmbMedoc.Name = "cmbMedoc";
            this.cmbMedoc.Size = new System.Drawing.Size(121, 21);
            this.cmbMedoc.TabIndex = 3;
            this.cmbMedoc.Visible = false;
            this.cmbMedoc.SelectedIndexChanged += new System.EventHandler(this.cmbMedoc_SelectedIndexChanged);
            // 
            // MedocSrc
            // 
            this.MedocSrc.DataSource = typeof(GestionOffreMedocs.medicament);
            // 
            // AfficherBtn
            // 
            this.AfficherBtn.Enabled = false;
            this.AfficherBtn.Location = new System.Drawing.Point(385, 369);
            this.AfficherBtn.Name = "AfficherBtn";
            this.AfficherBtn.Size = new System.Drawing.Size(75, 23);
            this.AfficherBtn.TabIndex = 4;
            this.AfficherBtn.Text = "Afficher";
            this.AfficherBtn.UseVisualStyleBackColor = true;
            this.AfficherBtn.Click += new System.EventHandler(this.ValiderBtn_Click);
            // 
            // FormOffre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AfficherBtn);
            this.Controls.Add(this.cmbMedoc);
            this.Controls.Add(this.labelMedoc);
            this.Controls.Add(this.cmbFamille);
            this.Controls.Add(this.label1);
            this.Name = "FormOffre";
            this.Text = "FormOffre";
            this.Load += new System.EventHandler(this.FormOffre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familleSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedocSrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFamille;
        private System.Windows.Forms.BindingSource familleSrc;
        private System.Windows.Forms.Label labelMedoc;
        private System.Windows.Forms.ComboBox cmbMedoc;
        private System.Windows.Forms.BindingSource MedocSrc;
        private System.Windows.Forms.Button AfficherBtn;
    }
}