namespace GestionOffreMedocs
{
    partial class AjoutMedoc
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
            this.comboFamille = new System.Windows.Forms.ComboBox();
            this.IDMed = new System.Windows.Forms.TextBox();
            this.NomMed = new System.Windows.Forms.TextBox();
            this.CIMed = new System.Windows.Forms.RichTextBox();
            this.EffetMed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CompoMed = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboFamille
            // 
            this.comboFamille.FormattingEnabled = true;
            this.comboFamille.Location = new System.Drawing.Point(553, 75);
            this.comboFamille.Name = "comboFamille";
            this.comboFamille.Size = new System.Drawing.Size(137, 21);
            this.comboFamille.TabIndex = 0;
            this.comboFamille.Text = "selectionner une famille";
            this.comboFamille.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // IDMed
            // 
            this.IDMed.Location = new System.Drawing.Point(185, 71);
            this.IDMed.Name = "IDMed";
            this.IDMed.Size = new System.Drawing.Size(127, 20);
            this.IDMed.TabIndex = 1;
            // 
            // NomMed
            // 
            this.NomMed.Location = new System.Drawing.Point(185, 141);
            this.NomMed.Name = "NomMed";
            this.NomMed.Size = new System.Drawing.Size(127, 20);
            this.NomMed.TabIndex = 2;
            // 
            // CIMed
            // 
            this.CIMed.Location = new System.Drawing.Point(552, 211);
            this.CIMed.Name = "CIMed";
            this.CIMed.Size = new System.Drawing.Size(138, 96);
            this.CIMed.TabIndex = 4;
            this.CIMed.Text = "";
            // 
            // EffetMed
            // 
            this.EffetMed.Location = new System.Drawing.Point(553, 141);
            this.EffetMed.Name = "EffetMed";
            this.EffetMed.Size = new System.Drawing.Size(137, 20);
            this.EffetMed.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Medicamement";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Famille de médicaments";
            // 
            // CompoMed
            // 
            this.CompoMed.Location = new System.Drawing.Point(185, 211);
            this.CompoMed.Name = "CompoMed";
            this.CompoMed.Size = new System.Drawing.Size(127, 96);
            this.CompoMed.TabIndex = 9;
            this.CompoMed.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Composition";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contre indication";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Effets";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AjoutMedoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CompoMed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EffetMed);
            this.Controls.Add(this.CIMed);
            this.Controls.Add(this.NomMed);
            this.Controls.Add(this.IDMed);
            this.Controls.Add(this.comboFamille);
            this.Name = "AjoutMedoc";
            this.Text = "AjoutMedoc";
            this.Load += new System.EventHandler(this.AjoutMedoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFamille;
        private System.Windows.Forms.TextBox IDMed;
        private System.Windows.Forms.TextBox NomMed;
        private System.Windows.Forms.RichTextBox CIMed;
        private System.Windows.Forms.TextBox EffetMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox CompoMed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}