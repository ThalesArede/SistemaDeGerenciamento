using System;
using System.Data;
using Omega.Classes;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Omega
{
    public partial class frmFinanceiro : Form
    {

        private DataTable originalDataTable;

        public frmFinanceiro()
        {
            InitializeComponent();
        }

        private void PreencherDataGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT numero_registro, " +
                                                "positivo, " +
                                                "debito, " +
                                                "saldo " +
                                                "FROM dados_iniciais";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Substitua dgvFinanceiro pelo nome do seu DataGridView
                        dgvFinanceiro.DataSource = dataTable;
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
                }
            }
        }

        private void frmFinanceiro_Load(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }

        public void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            txtPesquisa.Focus();
            PesquisaAssinatura();
        }
        public void PesquisaAssinatura()
        {
            GridHelper.Filtrar(txtPesquisa.Text, dgvFinanceiro);
        }
    }
}
