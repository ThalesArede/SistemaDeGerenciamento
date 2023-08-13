namespace Omega
{
    partial class frmPaginaInicial
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.arrastarIcon = new System.Windows.Forms.TextBox();
            this.fecharIcone = new FontAwesome.Sharp.IconButton();
            this.maximizarIcon = new FontAwesome.Sharp.IconButton();
            this.minimizarIcon = new FontAwesome.Sharp.IconButton();
            this.btnHam = new FontAwesome.Sharp.IconButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnPaginaInicial = new FontAwesome.Sharp.IconButton();
            this.dropDownContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnMenu = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnSubMenu1 = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnSubMenu2 = new FontAwesome.Sharp.IconButton();
            this.configMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnConfiguracoes = new FontAwesome.Sharp.IconButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pnCustomizacao = new FontAwesome.Sharp.IconButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnBrilho = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnSobre = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toggleButton1 = new Omega.Utilidades.ToggleButton();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dropDownContainer.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.configMenu.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1052, 30);
            this.panelTitleBar.TabIndex = 4;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // arrastarIcon
            // 
            this.arrastarIcon.BackColor = System.Drawing.SystemColors.Control;
            this.arrastarIcon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrastarIcon.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.arrastarIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.arrastarIcon.Location = new System.Drawing.Point(0, 0);
            this.arrastarIcon.Multiline = true;
            this.arrastarIcon.Name = "arrastarIcon";
            this.arrastarIcon.Size = new System.Drawing.Size(1416, 27);
            this.arrastarIcon.TabIndex = 19;
            this.arrastarIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AreaDeArrasto_MouseDown);
            this.arrastarIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AreaDeArrasto_MouseMove);
            this.arrastarIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AreaDeArrasto_MouseUp);
            // 
            // fecharIcone
            // 
            this.fecharIcone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fecharIcone.BackColor = System.Drawing.SystemColors.Control;
            this.fecharIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fecharIcone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fecharIcone.FlatAppearance.BorderSize = 0;
            this.fecharIcone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fecharIcone.ForeColor = System.Drawing.Color.IndianRed;
            this.fecharIcone.IconChar = FontAwesome.Sharp.IconChar.X;
            this.fecharIcone.IconColor = System.Drawing.Color.Black;
            this.fecharIcone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.fecharIcone.IconSize = 15;
            this.fecharIcone.Location = new System.Drawing.Point(1319, 0);
            this.fecharIcone.Name = "fecharIcone";
            this.fecharIcone.Rotation = 90D;
            this.fecharIcone.Size = new System.Drawing.Size(31, 27);
            this.fecharIcone.TabIndex = 16;
            this.fecharIcone.UseVisualStyleBackColor = false;
            this.fecharIcone.Click += new System.EventHandler(this.fecharIcone_Click);
            // 
            // maximizarIcon
            // 
            this.maximizarIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizarIcon.BackColor = System.Drawing.SystemColors.Control;
            this.maximizarIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maximizarIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizarIcon.FlatAppearance.BorderSize = 0;
            this.maximizarIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizarIcon.ForeColor = System.Drawing.Color.IndianRed;
            this.maximizarIcon.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
            this.maximizarIcon.IconColor = System.Drawing.Color.Black;
            this.maximizarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizarIcon.IconSize = 20;
            this.maximizarIcon.Location = new System.Drawing.Point(1282, 0);
            this.maximizarIcon.Name = "maximizarIcon";
            this.maximizarIcon.Rotation = 90D;
            this.maximizarIcon.Size = new System.Drawing.Size(31, 27);
            this.maximizarIcon.TabIndex = 17;
            this.maximizarIcon.UseVisualStyleBackColor = false;
            this.maximizarIcon.Click += new System.EventHandler(this.maximizarIcon_Click);
            // 
            // minimizarIcon
            // 
            this.minimizarIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizarIcon.BackColor = System.Drawing.SystemColors.Control;
            this.minimizarIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizarIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizarIcon.FlatAppearance.BorderSize = 0;
            this.minimizarIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizarIcon.ForeColor = System.Drawing.Color.IndianRed;
            this.minimizarIcon.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimizarIcon.IconColor = System.Drawing.Color.Black;
            this.minimizarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizarIcon.IconSize = 20;
            this.minimizarIcon.Location = new System.Drawing.Point(1245, 0);
            this.minimizarIcon.Name = "minimizarIcon";
            this.minimizarIcon.Size = new System.Drawing.Size(31, 27);
            this.minimizarIcon.TabIndex = 18;
            this.minimizarIcon.UseVisualStyleBackColor = false;
            this.minimizarIcon.Click += new System.EventHandler(this.minimizarIcon_Click);
            // 
            // btnHam
            // 
            this.btnHam.BackColor = System.Drawing.SystemColors.Control;
            this.btnHam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHam.FlatAppearance.BorderSize = 0;
            this.btnHam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHam.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHam.ForeColor = System.Drawing.Color.White;
            this.btnHam.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.btnHam.IconColor = System.Drawing.Color.Black;
            this.btnHam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHam.IconSize = 20;
            this.btnHam.Location = new System.Drawing.Point(0, 0);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(35, 29);
            this.btnHam.TabIndex = 11;
            this.btnHam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHam.UseVisualStyleBackColor = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(90, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 19);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "INDUSTRY CHANGER";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.IndianRed;
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.dropDownContainer);
            this.sidebar.Controls.Add(this.configMenu);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 27);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(230, 874);
            this.sidebar.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnPaginaInicial);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 44);
            this.panel2.TabIndex = 23;
            // 
            // pnPaginaInicial
            // 
            this.pnPaginaInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnPaginaInicial.BackColor = System.Drawing.Color.IndianRed;
            this.pnPaginaInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnPaginaInicial.FlatAppearance.BorderSize = 0;
            this.pnPaginaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnPaginaInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPaginaInicial.ForeColor = System.Drawing.Color.White;
            this.pnPaginaInicial.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.pnPaginaInicial.IconColor = System.Drawing.Color.White;
            this.pnPaginaInicial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pnPaginaInicial.IconSize = 20;
            this.pnPaginaInicial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnPaginaInicial.Location = new System.Drawing.Point(3, 0);
            this.pnPaginaInicial.Margin = new System.Windows.Forms.Padding(0);
            this.pnPaginaInicial.Name = "pnPaginaInicial";
            this.pnPaginaInicial.Size = new System.Drawing.Size(218, 44);
            this.pnPaginaInicial.TabIndex = 1;
            this.pnPaginaInicial.Text = "     Página Inicial";
            this.pnPaginaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pnPaginaInicial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pnPaginaInicial.UseVisualStyleBackColor = false;
            // 
            // dropDownContainer
            // 
            this.dropDownContainer.Controls.Add(this.panel8);
            this.dropDownContainer.Controls.Add(this.panel7);
            this.dropDownContainer.Controls.Add(this.panel6);
            this.dropDownContainer.Location = new System.Drawing.Point(3, 47);
            this.dropDownContainer.MaximumSize = new System.Drawing.Size(218, 132);
            this.dropDownContainer.MinimumSize = new System.Drawing.Size(218, 44);
            this.dropDownContainer.Name = "dropDownContainer";
            this.dropDownContainer.Size = new System.Drawing.Size(218, 132);
            this.dropDownContainer.TabIndex = 34;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pnMenu);
            this.panel8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(218, 44);
            this.panel8.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnMenu.BackColor = System.Drawing.Color.IndianRed;
            this.pnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMenu.FlatAppearance.BorderSize = 0;
            this.pnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMenu.ForeColor = System.Drawing.Color.White;
            this.pnMenu.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            this.pnMenu.IconColor = System.Drawing.Color.White;
            this.pnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pnMenu.IconSize = 20;
            this.pnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(218, 44);
            this.pnMenu.TabIndex = 3;
            this.pnMenu.Text = "    Menu";
            this.pnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pnMenu.UseVisualStyleBackColor = false;
            this.pnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnSubMenu1);
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(0, 44);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(218, 44);
            this.panel7.TabIndex = 1;
            // 
            // pnSubMenu1
            // 
            this.pnSubMenu1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnSubMenu1.BackColor = System.Drawing.Color.IndianRed;
            this.pnSubMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnSubMenu1.FlatAppearance.BorderSize = 0;
            this.pnSubMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnSubMenu1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSubMenu1.ForeColor = System.Drawing.Color.White;
            this.pnSubMenu1.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.pnSubMenu1.IconColor = System.Drawing.Color.White;
            this.pnSubMenu1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pnSubMenu1.IconSize = 20;
            this.pnSubMenu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnSubMenu1.Location = new System.Drawing.Point(0, 0);
            this.pnSubMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.pnSubMenu1.Name = "pnSubMenu1";
            this.pnSubMenu1.Size = new System.Drawing.Size(218, 44);
            this.pnSubMenu1.TabIndex = 4;
            this.pnSubMenu1.Text = "    Sub Menu 1";
            this.pnSubMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pnSubMenu1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pnSubMenu1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pnSubMenu2);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(0, 88);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 44);
            this.panel6.TabIndex = 2;
            // 
            // pnSubMenu2
            // 
            this.pnSubMenu2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnSubMenu2.BackColor = System.Drawing.Color.IndianRed;
            this.pnSubMenu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnSubMenu2.FlatAppearance.BorderSize = 0;
            this.pnSubMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnSubMenu2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSubMenu2.ForeColor = System.Drawing.Color.White;
            this.pnSubMenu2.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.pnSubMenu2.IconColor = System.Drawing.Color.White;
            this.pnSubMenu2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pnSubMenu2.IconSize = 20;
            this.pnSubMenu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnSubMenu2.Location = new System.Drawing.Point(0, 0);
            this.pnSubMenu2.Margin = new System.Windows.Forms.Padding(0);
            this.pnSubMenu2.Name = "pnSubMenu2";
            this.pnSubMenu2.Size = new System.Drawing.Size(218, 44);
            this.pnSubMenu2.TabIndex = 27;
            this.pnSubMenu2.Text = "    Sub Menu 2";
            this.pnSubMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pnSubMenu2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pnSubMenu2.UseVisualStyleBackColor = false;
            // 
            // configMenu
            // 
            this.configMenu.Controls.Add(this.panel9);
            this.configMenu.Controls.Add(this.panel10);
            this.configMenu.Controls.Add(this.panel11);
            this.configMenu.Location = new System.Drawing.Point(0, 182);
            this.configMenu.Margin = new System.Windows.Forms.Padding(0);
            this.configMenu.MaximumSize = new System.Drawing.Size(218, 132);
            this.configMenu.MinimumSize = new System.Drawing.Size(218, 44);
            this.configMenu.Name = "configMenu";
            this.configMenu.Size = new System.Drawing.Size(218, 132);
            this.configMenu.TabIndex = 35;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pnConfiguracoes);
            this.panel9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(218, 44);
            this.panel9.TabIndex = 0;
            // 
            // pnConfiguracoes
            // 
            this.pnConfiguracoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnConfiguracoes.BackColor = System.Drawing.Color.IndianRed;
            this.pnConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.pnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.pnConfiguracoes.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.pnConfiguracoes.IconColor = System.Drawing.Color.White;
            this.pnConfiguracoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pnConfiguracoes.IconSize = 20;
            this.pnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnConfiguracoes.Location = new System.Drawing.Point(0, 0);
            this.pnConfiguracoes.Margin = new System.Windows.Forms.Padding(0);
            this.pnConfiguracoes.Name = "pnConfiguracoes";
            this.pnConfiguracoes.Size = new System.Drawing.Size(218, 44);
            this.pnConfiguracoes.TabIndex = 27;
            this.pnConfiguracoes.Text = "    Configurações";
            this.pnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pnConfiguracoes.UseVisualStyleBackColor = false;
            this.pnConfiguracoes.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pnCustomizacao);
            this.panel10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(0, 44);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(218, 44);
            this.panel10.TabIndex = 1;
            // 
            // pnCustomizacao
            // 
            this.pnCustomizacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnCustomizacao.BackColor = System.Drawing.Color.IndianRed;
            this.pnCustomizacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnCustomizacao.FlatAppearance.BorderSize = 0;
            this.pnCustomizacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnCustomizacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnCustomizacao.ForeColor = System.Drawing.Color.White;
            this.pnCustomizacao.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.pnCustomizacao.IconColor = System.Drawing.Color.White;
            this.pnCustomizacao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pnCustomizacao.IconSize = 20;
            this.pnCustomizacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnCustomizacao.Location = new System.Drawing.Point(0, 0);
            this.pnCustomizacao.Margin = new System.Windows.Forms.Padding(0);
            this.pnCustomizacao.Name = "pnCustomizacao";
            this.pnCustomizacao.Size = new System.Drawing.Size(218, 44);
            this.pnCustomizacao.TabIndex = 28;
            this.pnCustomizacao.Text = "    Customização";
            this.pnCustomizacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pnCustomizacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pnCustomizacao.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnBrilho);
            this.panel11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(0, 88);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(218, 44);
            this.panel11.TabIndex = 2;
            // 
            // btnBrilho
            // 
            this.btnBrilho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrilho.BackColor = System.Drawing.Color.IndianRed;
            this.btnBrilho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrilho.FlatAppearance.BorderSize = 0;
            this.btnBrilho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrilho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrilho.ForeColor = System.Drawing.Color.White;
            this.btnBrilho.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.btnBrilho.IconColor = System.Drawing.Color.White;
            this.btnBrilho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBrilho.IconSize = 20;
            this.btnBrilho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrilho.Location = new System.Drawing.Point(0, 0);
            this.btnBrilho.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrilho.Name = "btnBrilho";
            this.btnBrilho.Size = new System.Drawing.Size(218, 44);
            this.btnBrilho.TabIndex = 29;
            this.btnBrilho.Text = "    Brilho";
            this.btnBrilho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrilho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrilho.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnSobre);
            this.panel3.Location = new System.Drawing.Point(0, 314);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 44);
            this.panel3.TabIndex = 28;
            // 
            // pnSobre
            // 
            this.pnSobre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnSobre.BackColor = System.Drawing.Color.IndianRed;
            this.pnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnSobre.FlatAppearance.BorderSize = 0;
            this.pnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnSobre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSobre.ForeColor = System.Drawing.Color.White;
            this.pnSobre.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.pnSobre.IconColor = System.Drawing.Color.White;
            this.pnSobre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pnSobre.IconSize = 20;
            this.pnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnSobre.Location = new System.Drawing.Point(0, 0);
            this.pnSobre.Margin = new System.Windows.Forms.Padding(0);
            this.pnSobre.Name = "pnSobre";
            this.pnSobre.Size = new System.Drawing.Size(218, 44);
            this.pnSobre.TabIndex = 27;
            this.pnSobre.Text = "    Sobre";
            this.pnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pnSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pnSobre.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSair);
            this.panel4.Location = new System.Drawing.Point(0, 358);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 44);
            this.panel4.TabIndex = 24;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.IndianRed;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSair.IconColor = System.Drawing.Color.White;
            this.btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSair.IconSize = 20;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 0);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(218, 44);
            this.btnSair.TabIndex = 27;
            this.btnSair.Text = "    Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.SairIcon_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.toggleButton1);
            this.panel1.Controls.Add(this.sidebar);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Controls.Add(this.minimizarIcon);
            this.panel1.Controls.Add(this.maximizarIcon);
            this.panel1.Controls.Add(this.fecharIcone);
            this.panel1.Controls.Add(this.arrastarIcon);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1416, 901);
            this.panel1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // toggleButton1
            // 
            this.toggleButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toggleButton1.Checked = true;
            this.toggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton1.Location = new System.Drawing.Point(236, 27);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.LightGray;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.MidnightBlue;
            this.toggleButton1.OnBackColor = System.Drawing.Color.Silver;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.Black;
            this.toggleButton1.Size = new System.Drawing.Size(45, 22);
            this.toggleButton1.TabIndex = 25;
            this.toggleButton1.UseVisualStyleBackColor = true;
            this.toggleButton1.CheckedChanged += new System.EventHandler(this.btnToggleMode_Click);
            // 
            // frmPaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicial";
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.dropDownContainer.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.configMenu.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton pnPaginaInicial;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton pnSobre;
        private FontAwesome.Sharp.IconButton pnConfiguracoes;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnSair;
        private System.Windows.Forms.TextBox textBox3;
        private FontAwesome.Sharp.IconButton btnHam;
        private FontAwesome.Sharp.IconButton minimizarIcon;
        private FontAwesome.Sharp.IconButton maximizarIcon;
        private FontAwesome.Sharp.IconButton fecharIcone;
        private System.Windows.Forms.TextBox arrastarIcon;
        private System.Windows.Forms.FlowLayoutPanel dropDownContainer;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton pnMenu;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton pnSubMenu1;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton pnSubMenu2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FlowLayoutPanel configMenu;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private FontAwesome.Sharp.IconButton pnCustomizacao;
        private System.Windows.Forms.Panel panel11;
        private FontAwesome.Sharp.IconButton btnBrilho;
        private System.Windows.Forms.Timer timer2;
        private Utilidades.ToggleButton toggleButton1;
    }
}

