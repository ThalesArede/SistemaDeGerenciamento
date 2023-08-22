namespace Omega
{
    partial class frmPrincipal
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
            this.arrastarIcon = new System.Windows.Forms.TextBox();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.icMinimizar = new FontAwesome.Sharp.IconButton();
            this.icFechar = new FontAwesome.Sharp.IconButton();
            this.icMaximizar = new FontAwesome.Sharp.IconButton();
            this.pnSubPrincipal = new System.Windows.Forms.Panel();
            this.toggleButton1 = new Omega.Utilidades.ToggleButton();
            this.pnSubPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // arrastarIcon
            // 
            this.arrastarIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.arrastarIcon.BackColor = System.Drawing.SystemColors.Control;
            this.arrastarIcon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrastarIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.arrastarIcon.Location = new System.Drawing.Point(0, 348);
            this.arrastarIcon.MaximumSize = new System.Drawing.Size(1350, 54);
            this.arrastarIcon.Multiline = true;
            this.arrastarIcon.Name = "arrastarIcon";
            this.arrastarIcon.Size = new System.Drawing.Size(1350, 54);
            this.arrastarIcon.TabIndex = 21;
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelPrincipal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.painelPrincipal.Location = new System.Drawing.Point(0, 56);
            this.painelPrincipal.MinimumSize = new System.Drawing.Size(1350, 696);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(1350, 696);
            this.painelPrincipal.TabIndex = 26;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrincipal.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipal.ForeColor = System.Drawing.Color.Black;
            this.txtPrincipal.Location = new System.Drawing.Point(63, 17);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(140, 19);
            this.txtPrincipal.TabIndex = 21;
            this.txtPrincipal.Text = "INDUSTRY CHANGER";
            // 
            // icMinimizar
            // 
            this.icMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icMinimizar.BackColor = System.Drawing.SystemColors.Control;
            this.icMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icMinimizar.FlatAppearance.BorderSize = 0;
            this.icMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icMinimizar.ForeColor = System.Drawing.Color.IndianRed;
            this.icMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.icMinimizar.IconColor = System.Drawing.Color.Black;
            this.icMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icMinimizar.IconSize = 20;
            this.icMinimizar.Location = new System.Drawing.Point(1243, 1);
            this.icMinimizar.Name = "icMinimizar";
            this.icMinimizar.Size = new System.Drawing.Size(31, 27);
            this.icMinimizar.TabIndex = 68;
            this.icMinimizar.UseVisualStyleBackColor = false;
            this.icMinimizar.Click += new System.EventHandler(this.minimizarIcon_Click);
            // 
            // icFechar
            // 
            this.icFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icFechar.BackColor = System.Drawing.SystemColors.Control;
            this.icFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icFechar.FlatAppearance.BorderSize = 0;
            this.icFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icFechar.ForeColor = System.Drawing.Color.IndianRed;
            this.icFechar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.icFechar.IconColor = System.Drawing.Color.Black;
            this.icFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icFechar.IconSize = 15;
            this.icFechar.Location = new System.Drawing.Point(1317, 1);
            this.icFechar.Name = "icFechar";
            this.icFechar.Rotation = 90D;
            this.icFechar.Size = new System.Drawing.Size(31, 27);
            this.icFechar.TabIndex = 67;
            this.icFechar.UseVisualStyleBackColor = false;
            this.icFechar.Click += new System.EventHandler(this.fecharIcone_Click);
            // 
            // icMaximizar
            // 
            this.icMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icMaximizar.BackColor = System.Drawing.SystemColors.Control;
            this.icMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icMaximizar.FlatAppearance.BorderSize = 0;
            this.icMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icMaximizar.ForeColor = System.Drawing.Color.IndianRed;
            this.icMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.icMaximizar.IconColor = System.Drawing.Color.Black;
            this.icMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icMaximizar.IconSize = 20;
            this.icMaximizar.Location = new System.Drawing.Point(1280, 1);
            this.icMaximizar.Name = "icMaximizar";
            this.icMaximizar.Rotation = 90D;
            this.icMaximizar.Size = new System.Drawing.Size(31, 27);
            this.icMaximizar.TabIndex = 66;
            this.icMaximizar.UseVisualStyleBackColor = false;
            this.icMaximizar.Click += new System.EventHandler(this.maximizarIcon_Click);
            // 
            // pnSubPrincipal
            // 
            this.pnSubPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSubPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.pnSubPrincipal.Controls.Add(this.toggleButton1);
            this.pnSubPrincipal.Controls.Add(this.txtPrincipal);
            this.pnSubPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnSubPrincipal.Name = "pnSubPrincipal";
            this.pnSubPrincipal.Size = new System.Drawing.Size(1350, 54);
            this.pnSubPrincipal.TabIndex = 0;
            this.pnSubPrincipal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.arrastarIcon_MouseDoubleClick);
            this.pnSubPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AreaDeArrasto_MouseDown);
            this.pnSubPrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AreaDeArrasto_MouseMove);
            this.pnSubPrincipal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AreaDeArrasto_MouseUp);
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.Location = new System.Drawing.Point(12, 14);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(45, 22);
            this.toggleButton1.TabIndex = 0;
            this.toggleButton1.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.icMinimizar);
            this.Controls.Add(this.icFechar);
            this.Controls.Add(this.icMaximizar);
            this.Controls.Add(this.painelPrincipal);
            this.Controls.Add(this.arrastarIcon);
            this.Controls.Add(this.pnSubPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1350, 750);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.pnSubPrincipal.ResumeLayout(false);
            this.pnSubPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arrastarIcon;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.TextBox txtPrincipal;
        private FontAwesome.Sharp.IconButton icMinimizar;
        private FontAwesome.Sharp.IconButton icFechar;
        private FontAwesome.Sharp.IconButton icMaximizar;
        private System.Windows.Forms.Panel pnSubPrincipal;
        private Utilidades.ToggleButton toggleButton1;
    }
}