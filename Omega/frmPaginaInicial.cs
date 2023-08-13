﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.IO;

namespace Omega
{
    public partial class frmPaginaInicial : Form
    {

        frmBoasVindas boasVindas;
        frmCustomizacao configuracoes;
        frmSobre sobre;
        frmSubMenu1 subMenu1;
        frmSubMenu2 subMenu2;

        public frmPaginaInicial()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }      
            
        //MenuResponsivo
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 45)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    //pnPaginaInicial.Width = sidebar.Width;
                    //pnSubMenu1.Width = sidebar.Width;
                    //pnSubMenu2.Width = sidebar.Width;
                    //pnCustomizacao.Width = sidebar.Width;
                    //pnSobre.Width = sidebar.Width;
                }
            } 
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 230)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    //pnPaginaInicial.Width = sidebar.Width;
                    //pnSubMenu1.Width = sidebar.Width;
                    //pnSubMenu2.Width = sidebar.Width;
                    //pnCustomizacao.Width = sidebar.Width;
                    //pnSobre.Width = sidebar.Width;

                }
            }           
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        bool expand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                dropDownContainer.Height += 15;
                if (dropDownContainer.Height >= dropDownContainer.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            } else
            {
                dropDownContainer.Height -= 15;
                if (dropDownContainer.Height <= dropDownContainer.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        bool expandConfig = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (expandConfig == false)
            {
                configMenu.Height += 15;
                if (configMenu.Height >= configMenu.MaximumSize.Height)
                {
                    timer2.Stop();
                    expandConfig = true;
                }
            } else
            {
                configMenu.Height -= 15;
                if (configMenu.Height <= configMenu.MinimumSize.Height)
                {
                    timer2.Stop();
                    expandConfig = false;
                }
            }
        }
        
        private void btnConfig_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }


        //MinimizarMaximizar
        private void minimizarIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }  
        private bool isMaximized = false;
        private void maximizarIcon_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            } else
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
        }


        //ArrastarTela
        private bool isDragging = false;
        private Point startPoint;
        private void AreaDeArrasto_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }
        private void AreaDeArrasto_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newPoint = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(newPoint.X - startPoint.X, newPoint.Y - startPoint.Y);
            }
        }
        private void AreaDeArrasto_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }


        //DarkMode
        private bool isDarkMode = false;
        private void ToggleDarkMode()
        {
            if (isDarkMode)
            {
                // Aplicar cores do modo claro
                this.BackColor = SystemColors.Control;
                
                panel1.BackColor = Color.FromArgb(245, 245, 245);
                
                textBox3.BackColor = SystemColors.Control;
                textBox3.ForeColor = Color.Black;

                btnHam.BackColor = SystemColors.Control;
                btnHam.IconColor = Color.Black;
                sidebar.BackColor = Color.FromArgb(205, 92, 92);
                
                pnPaginaInicial.BackColor = Color.FromArgb(205, 92, 92);               
                pnMenu.BackColor = Color.FromArgb(205, 92, 92);
                pnSubMenu1.BackColor = Color.FromArgb(205, 92, 92);
                pnSubMenu2.BackColor = Color.FromArgb(205, 92, 92);
                pnConfiguracoes.BackColor = Color.FromArgb(205, 92, 92);
                pnCustomizacao.BackColor = Color.FromArgb(205, 92, 92);
                btnBrilho.BackColor = Color.FromArgb(205, 92, 92);
                pnSobre.BackColor = Color.FromArgb(205, 92, 92);
                btnSair.BackColor = Color.FromArgb(205, 92, 92);

                
            } else
            {
                // Aplicar cores do modo escuro
                this.BackColor = Color.FromArgb(40, 40, 40);
                
                panel1.BackColor = Color.FromArgb(40, 40, 40);
                
                textBox3.BackColor = SystemColors.Control;
                textBox3.ForeColor = Color.Black;

                btnHam.BackColor = SystemColors.Control;
                btnHam.IconColor = Color.Black;
                sidebar.BackColor = Color.FromArgb(23, 24, 29);
                
                pnPaginaInicial.BackColor = Color.FromArgb(23, 24, 29);               
                pnMenu.BackColor = Color.FromArgb(23, 24, 29);                
                pnSubMenu1.BackColor = Color.FromArgb(23, 24, 29);
                pnSubMenu2.BackColor = Color.FromArgb(23, 24, 29);
                pnConfiguracoes.BackColor = Color.FromArgb(23, 24, 29);
                pnCustomizacao.BackColor = Color.FromArgb(23, 24, 29);
                btnBrilho.BackColor = Color.FromArgb(23, 24, 29);
                pnSobre.BackColor = Color.FromArgb(23, 24, 29);
                btnSair.BackColor = Color.FromArgb(23, 24, 29);          
            }

            // Inverter o modo
            isDarkMode = !isDarkMode;
        }
        private void btnToggleMode_Click(object sender, EventArgs e)
        {
            ToggleDarkMode();
        }

        //SairFechar
        private void fecharIcone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SairIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pnBoasVindas_Click(object sender, EventArgs e)
        {
            if (boasVindas == null)
            {
                boasVindas = new frmBoasVindas();
                boasVindas.FormClosed += BoasVindas_FormClosed;
                boasVindas.MdiParent = this;
                boasVindas.Show();
            } 
            else
            {
                boasVindas.Activate();
            }
        }   
        private void BoasVindas_FormClosed(object sender, FormClosedEventArgs e)
        {
            boasVindas = null;
        }

        private void pnSubMenu1_Click(object sender, EventArgs e)
        {
            if(subMenu1 == null)
            {
                subMenu1 = new frmSubMenu1();
                subMenu1.FormClosed += subMenu1_FormClosed;
                subMenu1.MdiParent = this;
                subMenu1.Dock = DockStyle.Fill;
                subMenu1.Show();
            }
            else
            {
                subMenu1.Activate();
            }
        }
        private void subMenu1_FormClosed(object sender, FormClosedEventArgs e)
        {
            subMenu1 = null;
        }
    }
}
