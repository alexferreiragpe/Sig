using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SGDB;

namespace SGVB
{
    public partial class FrmVendaPedido : Form
    {

        private SqlConnection conn = ConexaoBanco.sqlConnection;

        public FrmVendaPedido()
        {
            InitializeComponent();
        }

        string TotalProdutos;




        public class Cliente
        {
            public int IdCliente { get; set; }
            public string Nome { get; set; }
        }

        public class Produto
        {
            public string Descricao { get; set; }
            public string Codigo { get; set; }
            public double ValorUnit { get; set; }
            public int Estoque { get; set; }
        }


        private void CarregaClientes()
        {
            string sql = "SELECT Nome from Clientes";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                listBox1.Items.Add(leitor["Nome"].ToString());
            }
            conn.Close();
        }


        private Cliente ObterClientePorNome(string nome)
        {
            Cliente cliente = new Cliente();
            string sql = "SELECT * from Clientes WHERE Nome=@Nome";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nome", nome);
            conn.Open();
            SqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                cliente.IdCliente = Convert.ToInt32(leitor["Id_Cliente"].ToString());
                cliente.Nome = leitor["Nome"].ToString();
            }
            conn.Close();
            return cliente;
        }

        private void CarregaProduto()
        {
            string sql = "select Descricao from Produto ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                listBox2.Items.Add(leitor["Descri"].ToString());
            }
            conn.Close();
        }

        private Produto ObterProdutoPorDescri(string descri)
        {
            Produto produto = new Produto();
            string sql = "SELECT * from Produto WHERE Descricao=@Descri";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Descri", descri);
            conn.Open();
            SqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                produto.Descricao = leitor["Descri"].ToString();
                produto.Codigo = leitor["CodEAN"].ToString();
                produto.ValorUnit = Convert.ToDouble(leitor["PrecoVenda"]);
                produto.Estoque = Convert.ToInt32(leitor["Qtde"]);
            }
            conn.Close();
            return produto;
        }


        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if (listBox1.Enabled == false)
            {
                MessageBox.Show("Nenhuma Venda Realizada!", "Sig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnNovaCompra.Focus();
            }
            else
            {
                Cliente cliente = ObterClientePorNome(listBox1.SelectedItem.ToString());
                TxtCodCliente.Text = cliente.IdCliente.ToString();
                TxtNome.Text = cliente.Nome;
            }


        }


        private void listBox2_Click(object sender, EventArgs e)
        {

            if (listBox2.Enabled == false)
            {
                MessageBox.Show("Nenhuma Venda Aberta!", "Sig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnNovaCompra.Focus();
            }
            else
            {
                Produto produto = ObterProdutoPorDescri(listBox2.SelectedItem.ToString());
                TxtDescri.Text = produto.Descricao.ToString();
                TxtCodProduto.Text = produto.Codigo.ToString();
                TxtValorUnit.Text = produto.ValorUnit.ToString();
                TxtEstoque.Text = produto.Estoque.ToString();
            }
        }

        public void LimpaProduto()
        {
            TxtDescri.Clear();
            TxtCodProduto.Clear();
            TxtQtde.Clear();
            TxtEstoque.Clear();
            TxtValorUnit.Clear();
        }

        public void LimpaVenda()
        {
            TxtCodVenda.Clear();
            TxtNome.Clear();
            TxtCodCliente.Clear();
            CboFormaPag.Text = "Selecione";
            dataGridView1.Rows.Clear();
            listBox1.Enabled = false;
            listBox2.Enabled = false;
            CboFormaPag.Enabled = false;
            TxtQtde.Enabled = false;
            BtnAddProduto.Enabled = false;
            BtnRemoveItem.Enabled = false;
            LblValorTotal.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            BtnFimCompra.Enabled = false;
        }

        
        private void BtnConsProduto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmConsProduto>().Count() > 0)
            {
                MessageBox.Show("Consulta de Produtos já esta Aberta!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                FrmConsProduto ConsultaProduto = new FrmConsProduto();
                ConsultaProduto.Show();
            }
        }



        private void BtnNovaCompra_Click(object sender, EventArgs e)
        {
            CarregaClientes();
            CarregaProduto();
            listBox1.Enabled = true;
            listBox2.Enabled = true;
            BtnAddProduto.Enabled = true;
            BtnRemoveItem.Enabled = true;
            CboFormaPag.Enabled = true;
            BtnFimCompra.Enabled = true;
            BtnNovaCompra.Enabled = false;
            TxtQtde.Enabled = true;

            try
            {
                SqlCommand cmd = new SqlCommand(@"select max(Id_Venda) from Venda", conn);
                conn.Open();
                int codigo = 0;
                int novavenda = 0;
                codigo = Convert.ToInt32(cmd.ExecuteScalar());
                novavenda = codigo + 1;
                TxtCodVenda.Text = Convert.ToString(novavenda);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Sem Vendas para Exibir", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           

        }

        private void BtnAddProduto_Click(object sender, EventArgs e)
        {

            if (TxtDescri.Text == "")
            {
                MessageBox.Show("Selecione o Produto! Tente Novamente.", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listBox1.Focus();
            }
            else if (TxtQtde.Text == "")
            {


                MessageBox.Show("Digite a Quantidade! Tente Novamente.", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtQtde.Focus();
            }
            else
            {
                dataGridView1.Rows.Insert(0, TxtCodProduto.Text, TxtDescri.Text, Convert.ToDouble(TxtValorUnit.Text), Convert.ToInt32(TxtQtde.Text));

                double resultado = 0;
                double acumulador = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    resultado = (Convert.ToDouble(row.Cells["Valor_Unit"].Value) * Convert.ToDouble(row.Cells["Qtde"].Value));
                    row.Cells["Total_Item"].Value = Convert.ToDouble(resultado);
                    acumulador += Convert.ToDouble(resultado);

                }
                TotalProdutos = String.Format("{0:C}", acumulador);
                LblValorTotal.Text = TotalProdutos;
                LimpaProduto();
            }


        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Sua Lista esta Vazia! Adicione Primeiro.", "SGDB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);

            }

            double resultado = 0;
            double acumulador = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                resultado = (Convert.ToDouble(row.Cells["ValorUnitario"].Value) * Convert.ToDouble(row.Cells["Qtde"].Value));
                acumulador += Convert.ToDouble(resultado);

            }
            string TotalProdutos = String.Format("{0:C}", acumulador);
            LblValorTotal.Text = TotalProdutos;
        }

        private void BtnFimCompra_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Selecione o Cliente", "SGDB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNome.Focus();
            }
            else if (CboFormaPag.Text == "" || CboFormaPag.Text == "Selecione")
            {
                MessageBox.Show("Selecione a Forma de Pagamento!", "SGDB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CboFormaPag.Focus();
            }
            else if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Nenhum Item na Nota Fiscal!");
                listBox2.Focus();
            }

            else
            {


                try
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "INSERT INTO Venda(CodCliente,NomeCliente,Data,Valor,FormaPag) VALUES ('" + TxtCodCliente.Text + "','" + TxtNome.Text + "', '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "','" + TotalProdutos + "','" + CboFormaPag.Text + "')";
                    comando.Connection = conn;
                    comando.ExecuteNonQuery();
                    var sql = "INSERT INTO VendaItens(Id_Venda,Id_Cliente,ProdutoCodEan,Descricao,Valor_Unit,Qtde,Total_Item) VALUES ('" + TxtCodVenda.Text + "','" + TxtCodCliente.Text + "',@Codigo,@Descricao, @Valor_Unit,@Qtde, @Total_Item)";
                    SqlCommand comandos = new SqlCommand(sql, conn);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        comandos.Parameters.Clear();
                        comandos.Parameters.AddWithValue("@Codigo",
                            dataGridView1.Rows[i].Cells["Codigo"].Value);
                        comandos.Parameters.AddWithValue("@Descricao",
                            dataGridView1.Rows[i].Cells["Descricao"].Value);
                        comandos.Parameters.AddWithValue("@Valor_Unit".ToString(),
                            dataGridView1.Rows[i].Cells["Valor_Unit"].Value);
                        comandos.Parameters.AddWithValue("@Qtde",
                            dataGridView1.Rows[i].Cells["Qtde"].Value);
                        comandos.Parameters.AddWithValue("@Total_Item",
                            dataGridView1.Rows[i].Cells["Total_Item"].Value);
                        comandos.ExecuteNonQuery();

                    }

                    SqlCommand atualizaestoque = new SqlCommand();
                    atualizaestoque.CommandType = System.Data.CommandType.Text;
                    atualizaestoque.CommandText = (@"Update Produto set  Produto.Qtde=(Produto.Qtde-VendaItens.Qtde) from Produto inner join VendaItens on Produto.CodEAN=VendaItens.ProdutoCodEan");
                    atualizaestoque.Connection = conn;
                    atualizaestoque.ExecuteNonQuery();
                    conn.Close();
                    LimpaVenda();
                    MessageBox.Show("Venda Realizada com Sucesso", "SGDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erro ao Gravar Venda", "SGDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }

            BtnNovaCompra.Enabled = true;

        }

        private void TxtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }



        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaProduto();
            LimpaVenda();
            BtnNovaCompra.Enabled = true;
            BtnFimCompra.Enabled = false;
        }
    }

}

