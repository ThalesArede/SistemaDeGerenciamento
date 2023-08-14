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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaginaInicial));
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
            this.btnPaginaInicial = new FontAwesome.Sharp.IconButton();
            this.dropDownContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnMenu = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnConfiguracoes = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSubMenu2 = new FontAwesome.Sharp.IconButton();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.arrastarIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.arrastarIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.arrastarIcon.Location = new System.Drawing.Point(0, 0);
            this.arrastarIcon.Multiline = true;
            this.arrastarIcon.Name = "arrastarIcon";
            this.arrastarIcon.Size = new System.Drawing.Size(1416, 54);
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
            this.btnHam.Location = new System.Drawing.Point(0, 13);
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
            this.textBox3.Location = new System.Drawing.Point(89, 19);
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
            this.sidebar.Location = new System.Drawing.Point(0, 54);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(230, 847);
            this.sidebar.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPaginaInicial);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 44);
            this.panel2.TabIndex = 23;
            // 
            // btnPaginaInicial
            // 
            this.btnPaginaInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPaginaInicial.BackColor = System.Drawing.Color.IndianRed;
            this.btnPaginaInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaginaInicial.FlatAppearance.BorderSize = 0;
            this.btnPaginaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaginaInicial.ForeColor = System.Drawing.Color.White;
            this.btnPaginaInicial.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.btnPaginaInicial.IconColor = System.Drawing.Color.White;
            this.btnPaginaInicial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPaginaInicial.IconSize = 20;
            this.btnPaginaInicial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaginaInicial.Location = new System.Drawing.Point(3, 0);
            this.btnPaginaInicial.Margin = new System.Windows.Forms.Padding(0);
            this.btnPaginaInicial.Name = "btnPaginaInicial";
            this.btnPaginaInicial.Size = new System.Drawing.Size(218, 44);
            this.btnPaginaInicial.TabIndex = 1;
            this.btnPaginaInicial.Text = "     Novidades";
            this.btnPaginaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaginaInicial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaginaInicial.UseVisualStyleBackColor = false;
            this.btnPaginaInicial.Click += new System.EventHandler(this.btnPaginaInicial_Click);
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
            this.panel7.Controls.Add(this.btnConfiguracoes);
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(0, 44);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(218, 44);
            this.panel7.TabIndex = 1;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfiguracoes.BackColor = System.Drawing.Color.IndianRed;
            this.btnConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracoes.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnConfiguracoes.IconColor = System.Drawing.Color.White;
            this.btnConfiguracoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguracoes.IconSize = 20;
            this.btnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 0);
            this.btnConfiguracoes.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(218, 44);
            this.btnConfiguracoes.TabIndex = 4;
            this.btnConfiguracoes.Text = "    Configurações";
            this.btnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSubMenu2);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(0, 88);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 44);
            this.panel6.TabIndex = 2;
            // 
            // btnSubMenu2
            // 
            this.btnSubMenu2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubMenu2.BackColor = System.Drawing.Color.IndianRed;
            this.btnSubMenu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubMenu2.FlatAppearance.BorderSize = 0;
            this.btnSubMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenu2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenu2.ForeColor = System.Drawing.Color.White;
            this.btnSubMenu2.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnSubMenu2.IconColor = System.Drawing.Color.White;
            this.btnSubMenu2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubMenu2.IconSize = 20;
            this.btnSubMenu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenu2.Location = new System.Drawing.Point(0, 0);
            this.btnSubMenu2.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenu2.Name = "btnSubMenu2";
            this.btnSubMenu2.Size = new System.Drawing.Size(218, 44);
            this.btnSubMenu2.TabIndex = 27;
            this.btnSubMenu2.Text = "    Sobre";
            this.btnSubMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubMenu2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubMenu2.UseVisualStyleBackColor = false;
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
            this.pnConfiguracoes.Text = "    TextBox";
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
            this.pnCustomizacao.Text = "    TextBox1";
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
            this.btnBrilho.Text = "    TextBox2";
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
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBox2);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(690, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Gray;
            this.textBox6.Location = new System.Drawing.Point(554, 231);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(382, 28);
            this.textBox6.TabIndex = 61;
            this.textBox6.Text = "Ao nosso programa, o Industry Changer";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(665, 182);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(170, 43);
            this.textBox5.TabIndex = 60;
            this.textBox5.Text = "Bem-vindo";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(498, 294);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(492, 95);
            this.textBox4.TabIndex = 59;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox2.Location = new System.Drawing.Point(1172, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 56;
            this.textBox2.Text = "thales22";
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Menu",
            "Conta",
            "Sair"});
            this.comboBox1.Location = new System.Drawing.Point(1255, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 63;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(1140, 15);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(29, 26);
            this.iconButton1.TabIndex = 28;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // toggleButton1
            // 
            this.toggleButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toggleButton1.Checked = true;
            this.toggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton1.Location = new System.Drawing.Point(1293, 716);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnPaginaInicial;
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
        private FontAwesome.Sharp.IconButton btnConfiguracoes;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton btnSubMenu2;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

