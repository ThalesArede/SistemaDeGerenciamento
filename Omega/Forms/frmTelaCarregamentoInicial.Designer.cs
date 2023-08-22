namespace Omega
{
    partial class frmTelaCarregamentoInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaCarregamentoInicial));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureCarregamento = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarregamento)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.IndianRed;
            this.panelMenu.Controls.Add(this.pictureCarregamento);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(827, 524);
            this.panelMenu.TabIndex = 9;
            // 
            // pictureCarregamento
            // 
            this.pictureCarregamento.Image = ((System.Drawing.Image)(resources.GetObject("pictureCarregamento.Image")));
            this.pictureCarregamento.Location = new System.Drawing.Point(0, 3);
            this.pictureCarregamento.Name = "pictureCarregamento";
            this.pictureCarregamento.Size = new System.Drawing.Size(827, 523);
            this.pictureCarregamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureCarregamento.TabIndex = 23;
            this.pictureCarregamento.TabStop = false;
            // 
            // frmTelaCarregamentoInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 523);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelaCarregamentoInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCarregamentoInicial";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarregamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureCarregamento;
    }
}