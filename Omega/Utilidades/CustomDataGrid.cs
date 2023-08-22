using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega.Utilidades
{
    public partial class CustomDataGrid : UserControl
    {
        internal DataTable DataSource;

        public CustomDataGrid()
        {
            InitializeComponent();
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dataGridView1.CellPainting += DataGridView1_CellPainting;

            // Personalizar estilo dos títulos
            dataGridView1.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.IndianRed;
            headerStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;
        }

        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dataGridView1.RowCount && e.ColumnIndex < dataGridView1.ColumnCount)
            {
                e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Deixe o método base tratar o fundo
            base.OnPaintBackground(e);

            // Pinte o fundo com transparência
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
