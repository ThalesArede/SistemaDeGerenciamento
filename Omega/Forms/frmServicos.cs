using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using FontAwesome.Sharp;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Omega
{
    public partial class frmServicos : Form
    {

        public frmServicos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        //MenuResponsivo
        //bool sidebarExpand = true;
        //private void sidebarTransition_Tick(object sender, EventArgs e)
        //{
        //    if (sidebarExpand)
        //    {
        //        sidebar.Width -= 10;
        //        if (sidebar.Width <= 45)
        //        {
        //            sidebarExpand = false;
        //            sidebarTransition.Stop();

        //            //pnPaginaInicial.Width = sidebar.Width;
        //            //pnSubMenu1.Width = sidebar.Width;
        //            //pnSubMenu2.Width = sidebar.Width;
        //            //pnCustomizacao.Width = sidebar.Width;
        //            //pnSobre.Width = sidebar.Width;
        //        }
        //    } else
        //    {
        //        sidebar.Width += 10;
        //        if (sidebar.Width >= 230)
        //        {
        //            sidebarExpand = true;
        //            sidebarTransition.Stop();

        //            //pnPaginaInicial.Width = sidebar.Width;
        //            //pnSubMenu1.Width = sidebar.Width;
        //            //pnSubMenu2.Width = sidebar.Width;
        //            //pnCustomizacao.Width = sidebar.Width;
        //            //pnSobre.Width = sidebar.Width;

        //        }
        //    }
        //}

        //private void btnHam_Click(object sender, EventArgs e)
        //{
        //    sidebarTransition.Start();
        //}

        //bool expand = false;
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (expand == false)
        //    {
        //        dropDownContainer.Height += 15;
        //        if (dropDownContainer.Height >= dropDownContainer.MaximumSize.Height)
        //        {
        //            timer1.Stop();
        //            expand = true;
        //        }
        //    } else
        //    {
        //        dropDownContainer.Height -= 15;
        //        if (dropDownContainer.Height <= dropDownContainer.MinimumSize.Height)
        //        {
        //            timer1.Stop();
        //            expand = false;
        //        }
        //    }
        //}

        //private void btnMenu_Click(object sender, EventArgs e)
        //{
        //    timer1.Start();
        //}

        //bool expandConfig = false;
        //private void timer2_Tick(object sender, EventArgs e)
        //{
        //    if (expandConfig == false)
        //    {
        //        configMenu.Height += 15;
        //        if (configMenu.Height >= configMenu.MaximumSize.Height)
        //        {
        //            timer2.Stop();
        //            expandConfig = true;
        //        }
        //    } else
        //    {
        //        configMenu.Height -= 15;
        //        if (configMenu.Height <= configMenu.MinimumSize.Height)
        //        {
        //            timer2.Stop();
        //            expandConfig = false;
        //        }
        //    }
        //}

        //private void btnConfig_Click(object sender, EventArgs e)
        //{
        //    timer2.Start();
        //}

        //DarkMode
        //private bool isDarkMode = false;

        //private void ToggleDarkMode()
        //{
        //    if (isDarkMode)
        //    {
        //        // Aplicar cores do modo claro
        //        this.BackColor = SystemColors.Control;

        //        panel1.BackColor = Color.FromArgb(245, 245, 245);

        //        textBox3.BackColor = SystemColors.Control;
        //        textBox3.ForeColor = Color.Black;

        //        btnHam.BackColor = SystemColors.Control;
        //        btnHam.IconColor = Color.Black;
        //        sidebar.BackColor = Color.FromArgb(205, 92, 92);

        //        btnPaginaInicial.BackColor = Color.FromArgb(205, 92, 92);
        //        pnMenu.BackColor = Color.FromArgb(205, 92, 92);
        //        btnConfiguracoes.BackColor = Color.FromArgb(205, 92, 92);
        //        btnSobre.BackColor = Color.FromArgb(205, 92, 92);
        //        btnFincanceiro.BackColor = Color.FromArgb(205, 92, 92);
        //        pnCustomizacao.BackColor = Color.FromArgb(205, 92, 92);
        //        btnBrilho.BackColor = Color.FromArgb(205, 92, 92);
        //        btnSair.BackColor = Color.FromArgb(205, 92, 92);


        //    } else
        //    {
        //        // Aplicar cores do modo escuro
        //        this.BackColor = Color.FromArgb(40, 40, 40);

        //        panel1.BackColor = Color.FromArgb(40, 40, 40);

        //        textBox3.BackColor = SystemColors.Control;
        //        textBox3.ForeColor = Color.Black;

        //        btnHam.BackColor = SystemColors.Control;
        //        btnHam.IconColor = Color.Black;
        //        sidebar.BackColor = Color.FromArgb(23, 24, 29);

        //        btnPaginaInicial.BackColor = Color.FromArgb(23, 24, 29);
        //        pnMenu.BackColor = Color.FromArgb(23, 24, 29);
        //        btnConfiguracoes.BackColor = Color.FromArgb(23, 24, 29);
        //        btnSobre.BackColor = Color.FromArgb(23, 24, 29);
        //        btnFincanceiro.BackColor = Color.FromArgb(23, 24, 29);
        //        pnCustomizacao.BackColor = Color.FromArgb(23, 24, 29);
        //        btnBrilho.BackColor = Color.FromArgb(23, 24, 29);
        //        btnSair.BackColor = Color.FromArgb(23, 24, 29);
        //    }

        //    // Inverter o modo
        //    isDarkMode = !isDarkMode;
        //}

        //private void btnToggleMode_Click(object sender, EventArgs e)
        //{
        //    ToggleDarkMode();
        //}      
    }
}
