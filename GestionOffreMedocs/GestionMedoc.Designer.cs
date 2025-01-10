namespace GestionOffreMedocs
{
    partial class GestionMedoc
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
            this.tabMed = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offrirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnModif = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMed
            // 
            this.tabMed.AllowUserToOrderColumns = true;
            this.tabMed.AutoGenerateColumns = false;
            this.tabMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.nomCommercialDataGridViewTextBoxColumn,
            this.colFam,
            this.compositionDataGridViewTextBoxColumn,
            this.effetsDataGridViewTextBoxColumn,
            this.contreIndicationsDataGridViewTextBoxColumn,
            this.offrirDataGridViewTextBoxColumn});
            this.tabMed.DataSource = this.medicamentBindingSource;
            this.tabMed.Location = new System.Drawing.Point(24, 39);
            this.tabMed.Name = "tabMed";
            this.tabMed.ReadOnly = true;
            this.tabMed.Size = new System.Drawing.Size(744, 335);
            this.tabMed.TabIndex = 0;
            this.tabMed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabMed_CellContentClick);
            this.tabMed.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabMed_CellValueChanged);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "id";
            this.colID.HeaderText = "id";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // nomCommercialDataGridViewTextBoxColumn
            // 
            this.nomCommercialDataGridViewTextBoxColumn.DataPropertyName = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.HeaderText = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.Name = "nomCommercialDataGridViewTextBoxColumn";
            this.nomCommercialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colFam
            // 
            this.colFam.DataPropertyName = "idFamille";
            this.colFam.HeaderText = "idFamille";
            this.colFam.Name = "colFam";
            this.colFam.ReadOnly = true;
            // 
            // compositionDataGridViewTextBoxColumn
            // 
            this.compositionDataGridViewTextBoxColumn.DataPropertyName = "composition";
            this.compositionDataGridViewTextBoxColumn.HeaderText = "composition";
            this.compositionDataGridViewTextBoxColumn.Name = "compositionDataGridViewTextBoxColumn";
            this.compositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // effetsDataGridViewTextBoxColumn
            // 
            this.effetsDataGridViewTextBoxColumn.DataPropertyName = "effets";
            this.effetsDataGridViewTextBoxColumn.HeaderText = "effets";
            this.effetsDataGridViewTextBoxColumn.Name = "effetsDataGridViewTextBoxColumn";
            this.effetsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contreIndicationsDataGridViewTextBoxColumn
            // 
            this.contreIndicationsDataGridViewTextBoxColumn.DataPropertyName = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.HeaderText = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.Name = "contreIndicationsDataGridViewTextBoxColumn";
            this.contreIndicationsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // offrirDataGridViewTextBoxColumn
            // 
            this.offrirDataGridViewTextBoxColumn.DataPropertyName = "offrir";
            this.offrirDataGridViewTextBoxColumn.HeaderText = "offrir";
            this.offrirDataGridViewTextBoxColumn.Name = "offrirDataGridViewTextBoxColumn";
            this.offrirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataSource = typeof(GestionOffreMedocs.medicament);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(195, 410);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 1;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(488, 410);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.button2_Click);
            // 
            // GestionMedoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.tabMed);
            this.Name = "GestionMedoc";
            this.Text = "GestionMedoc";
            this.Load += new System.EventHandler(this.GestionMedoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabMed;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFam;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrirDataGridViewTextBoxColumn;
    }
}