namespace GestionOffreMedocs
{
    partial class GestionFamille
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
            this.tabFamille = new System.Windows.Forms.DataGridView();
            this.colLib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBFamille = new System.Windows.Forms.BindingSource(this.components);
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabFamille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBFamille)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFamille
            // 
            this.tabFamille.AllowUserToOrderColumns = true;
            this.tabFamille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabFamille.AutoGenerateColumns = false;
            this.tabFamille.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabFamille.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabFamille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabFamille.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLib,
            this.colID});
            this.tabFamille.DataSource = this.DBFamille;
            this.tabFamille.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabFamille.Location = new System.Drawing.Point(103, 74);
            this.tabFamille.Name = "tabFamille";
            this.tabFamille.Size = new System.Drawing.Size(586, 287);
            this.tabFamille.TabIndex = 1;
            this.tabFamille.DataMemberChanged += new System.EventHandler(this.tabFamille_DataMemberChanged);
            this.tabFamille.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colLib
            // 
            this.colLib.DataPropertyName = "libelle";
            this.colLib.HeaderText = "libelle";
            this.colLib.MinimumWidth = 10;
            this.colLib.Name = "colLib";
            this.colLib.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "id";
            this.colID.HeaderText = "id";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DBFamille
            // 
            this.DBFamille.DataSource = typeof(GestionOffreMedocs.famille);
            this.DBFamille.CurrentChanged += new System.EventHandler(this.DBFamille_CurrentChanged);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(199, 418);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(471, 418);
            this.btnValider.Name = "btnValider";
            this.btnValider.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // GestionFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tabFamille);
            this.Name = "GestionFamille";
            this.Text = "GestionFamille";
            this.Load += new System.EventHandler(this.GestionFamille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFamille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBFamille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DBFamille;
        private System.Windows.Forms.DataGridView tabFamille;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLib;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
    }
}