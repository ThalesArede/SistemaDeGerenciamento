namespace Omega
{
    partial class dropDownMenu
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confIcon = new FontAwesome.Sharp.IconButton();
            this.dropDownContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dropDownContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconButton2);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 44);
            this.panel3.TabIndex = 2;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.BackColor = System.Drawing.Color.IndianRed;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(218, 44);
            this.iconButton2.TabIndex = 27;
            this.iconButton2.Text = "    Sub Menu 2";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.confIcon);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 44);
            this.panel2.TabIndex = 1;
            // 
            // confIcon
            // 
            this.confIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confIcon.BackColor = System.Drawing.Color.IndianRed;
            this.confIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confIcon.FlatAppearance.BorderSize = 0;
            this.confIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confIcon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confIcon.ForeColor = System.Drawing.Color.White;
            this.confIcon.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.confIcon.IconColor = System.Drawing.Color.White;
            this.confIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.confIcon.IconSize = 25;
            this.confIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confIcon.Location = new System.Drawing.Point(0, 0);
            this.confIcon.Margin = new System.Windows.Forms.Padding(0);
            this.confIcon.Name = "confIcon";
            this.confIcon.Size = new System.Drawing.Size(218, 44);
            this.confIcon.TabIndex = 4;
            this.confIcon.Text = "    Sub Menu 1";
            this.confIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.confIcon.UseVisualStyleBackColor = false;
            // 
            // dropDownContainer
            // 
            this.dropDownContainer.Controls.Add(this.panel1);
            this.dropDownContainer.Controls.Add(this.panel2);
            this.dropDownContainer.Controls.Add(this.panel3);
            this.dropDownContainer.Location = new System.Drawing.Point(0, 0);
            this.dropDownContainer.MaximumSize = new System.Drawing.Size(218, 132);
            this.dropDownContainer.MinimumSize = new System.Drawing.Size(218, 44);
            this.dropDownContainer.Name = "dropDownContainer";
            this.dropDownContainer.Size = new System.Drawing.Size(218, 132);
            this.dropDownContainer.TabIndex = 33;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenu.BackColor = System.Drawing.Color.IndianRed;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 25;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(218, 44);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "    Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 44);
            this.panel1.TabIndex = 0;
            // 
            // dropDownMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dropDownContainer);
            this.Name = "dropDownMenu";
            this.Size = new System.Drawing.Size(218, 132);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.dropDownContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton confIcon;
        private System.Windows.Forms.FlowLayoutPanel dropDownContainer;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMenu;
    }
}
