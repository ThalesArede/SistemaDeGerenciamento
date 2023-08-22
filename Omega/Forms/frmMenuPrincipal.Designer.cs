namespace Omega
{
    partial class frmMenuPrincipal
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
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.btnConfiguracoes = new FontAwesome.Sharp.IconButton();
            this.btnServicos = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSair.IconColor = System.Drawing.Color.Black;
            this.btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSair.Location = new System.Drawing.Point(947, 279);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 91);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfiguracoes.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnConfiguracoes.IconColor = System.Drawing.Color.Black;
            this.btnConfiguracoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguracoes.Location = new System.Drawing.Point(597, 279);
            this.btnConfiguracoes.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(145, 91);
            this.btnConfiguracoes.TabIndex = 7;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnServicos.BackColor = System.Drawing.SystemColors.Control;
            this.btnServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicos.FlatAppearance.BorderSize = 0;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.btnServicos.IconColor = System.Drawing.Color.Black;
            this.btnServicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServicos.Location = new System.Drawing.Point(307, 279);
            this.btnServicos.Margin = new System.Windows.Forms.Padding(0);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(89, 91);
            this.btnServicos.TabIndex = 6;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServicos.UseVisualStyleBackColor = false;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 696);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfiguracoes);
            this.Controls.Add(this.btnServicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1350, 696);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnConfiguracoes;
        private FontAwesome.Sharp.IconButton btnServicos;
    }
}