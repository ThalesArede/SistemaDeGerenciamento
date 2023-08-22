using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Omega.Utilidades
{
    public enum TabTextAlignment
    {
        Left,
        Center,
        Right
    }

    public partial class CustomFlatTabControl : TabControl
    {
        public CustomFlatTabControl()
        {
            // Define algumas propriedades para melhorar a aparência
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(120, 40);
            Font = new Font("Segoe UI", 10, FontStyle.Regular);
            Appearance = TabAppearance.FlatButtons;
        }

        public TabTextAlignment TabTextAlignment { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Pinte a área de fundo
            e.Graphics.Clear(BackColor);

            // Desenhe as guias personalizadas
            for (int tabIndex = 0; tabIndex < TabCount; tabIndex++)
            {
                Rectangle tabRect = GetTabRect(tabIndex);
                bool isSelected = SelectedIndex == tabIndex;

                // Defina a cor de fundo com base no estado da guia
                Color backColor = isSelected ? Color.DodgerBlue : Color.LightGray;

                using (SolidBrush brush = new SolidBrush(backColor))
                {
                    e.Graphics.FillRectangle(brush, tabRect);
                }

                // Desenhe o texto da guia com alinhamento personalizado
                using (StringFormat sf = new StringFormat())
                {
                    sf.LineAlignment = StringAlignment.Center;

                    if (isSelected)
                    {
                        sf.Alignment = StringAlignment.Center;
                        using (SolidBrush textBrush = new SolidBrush(Color.White))
                        {
                            e.Graphics.DrawString(TabPages[tabIndex].Text, Font, textBrush, tabRect, sf);
                        }
                    } else
                    {
                        switch (TabTextAlignment)
                        {
                            case TabTextAlignment.Left:
                                sf.Alignment = StringAlignment.Near;
                                break;
                            case TabTextAlignment.Center:
                                sf.Alignment = StringAlignment.Center;
                                break;
                            case TabTextAlignment.Right:
                                sf.Alignment = StringAlignment.Far;
                                break;
                        }

                        using (SolidBrush textBrush = new SolidBrush(Color.Black))
                        {
                            e.Graphics.DrawString(TabPages[tabIndex].Text, Font, textBrush, tabRect, sf);
                        }
                    }
                }
            }
        }
    }
}
