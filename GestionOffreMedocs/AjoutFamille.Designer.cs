namespace GestionOffreMedocs
{
    partial class AjoutFamille
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
            this.IDFamille = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LibFamille = new System.Windows.Forms.RichTextBox();
            this.dbdFamille = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dbdFamille)).BeginInit();
            this.SuspendLayout();
            // 
            // IDFamille
            // 
            this.IDFamille.Location = new System.Drawing.Point(347, 113);
            this.IDFamille.Name = "IDFamille";
            this.IDFamille.Size = new System.Drawing.Size(100, 20);
            this.IDFamille.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID de la Famille";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libellé";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LibFamille
            // 
            this.LibFamille.Location = new System.Drawing.Point(347, 198);
            this.LibFamille.Name = "LibFamille";
            this.LibFamille.Size = new System.Drawing.Size(100, 96);
            this.LibFamille.TabIndex = 6;
            this.LibFamille.Text = "";
            this.LibFamille.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // dbdFamille
            // 
            this.dbdFamille.DataSource = typeof(GestionOffreMedocs.famille);
            this.dbdFamille.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // AjoutFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LibFamille);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDFamille);
            this.Name = "AjoutFamille";
            this.Text = "AjoutFamille";
            this.Load += new System.EventHandler(this.AjoutFamille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbdFamille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDFamille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox LibFamille;
        private System.Windows.Forms.BindingSource dbdFamille;
    }
}