namespace GestionOffreMedocs
{
    partial class OffreMedoc
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
            this.GridMedoc = new System.Windows.Forms.DataGridView();
            this.offrirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idRapportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridMedoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offrirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridMedoc
            // 
            this.GridMedoc.AllowUserToAddRows = false;
            this.GridMedoc.AllowUserToDeleteRows = false;
            this.GridMedoc.AutoGenerateColumns = false;
            this.GridMedoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMedoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRapportDataGridViewTextBoxColumn,
            this.idMedicamentDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn});
            this.GridMedoc.DataSource = this.offrirBindingSource;
            this.GridMedoc.Location = new System.Drawing.Point(229, 116);
            this.GridMedoc.Name = "GridMedoc";
            this.GridMedoc.ReadOnly = true;
            this.GridMedoc.Size = new System.Drawing.Size(344, 186);
            this.GridMedoc.TabIndex = 0;
            // 
            // offrirBindingSource
            // 
            this.offrirBindingSource.DataSource = typeof(GestionOffreMedocs.offrir);
            // 
            // idRapportDataGridViewTextBoxColumn
            // 
            this.idRapportDataGridViewTextBoxColumn.DataPropertyName = "idRapport";
            this.idRapportDataGridViewTextBoxColumn.HeaderText = "idRapport";
            this.idRapportDataGridViewTextBoxColumn.Name = "idRapportDataGridViewTextBoxColumn";
            this.idRapportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMedicamentDataGridViewTextBoxColumn
            // 
            this.idMedicamentDataGridViewTextBoxColumn.DataPropertyName = "idMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.HeaderText = "idMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.Name = "idMedicamentDataGridViewTextBoxColumn";
            this.idMedicamentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "quantite";
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            this.quantiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OffreMedoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridMedoc);
            this.Name = "OffreMedoc";
            this.Text = "OffreMedoc";
            this.Load += new System.EventHandler(this.OffreMedoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMedoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offrirBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMedoc;
        private System.Windows.Forms.BindingSource offrirBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRapportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
    }
}