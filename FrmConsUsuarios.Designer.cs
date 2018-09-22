namespace SGDB
{
    partial class FrmConsultaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaUsuarios));
            this.DGVConsUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVConsUsuarios
            // 
            this.DGVConsUsuarios.AllowUserToAddRows = false;
            this.DGVConsUsuarios.AllowUserToDeleteRows = false;
            this.DGVConsUsuarios.AllowUserToOrderColumns = true;
            this.DGVConsUsuarios.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGVConsUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVConsUsuarios.Location = new System.Drawing.Point(0, 0);
            this.DGVConsUsuarios.Name = "DGVConsUsuarios";
            this.DGVConsUsuarios.ReadOnly = true;
            this.DGVConsUsuarios.Size = new System.Drawing.Size(978, 445);
            this.DGVConsUsuarios.TabIndex = 0;
            // 
            // FrmConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 445);
            this.Controls.Add(this.DGVConsUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIG - Consulta Usuários";
            this.Load += new System.EventHandler(this.FrConsultaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVConsUsuarios;

    }
}