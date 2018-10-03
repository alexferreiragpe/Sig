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

namespace SGVB
{
    public partial class FrmCompraPedido : Form
    {


        private SqlConnection conn = ConexaoBanco.sqlConnection;

        public FrmCompraPedido()
        {
            InitializeComponent();
        }

        double total, qtd, valor;

        private void LimpaCampos()
        {
            TxtNotaFiscal.Clear();
            TxtTotalNota.Clear();
            CboFornecedor.Text = "Selecione";
            dataGridView1.Rows.Clear();
            TxtNotaFiscal.Focus();
            BtnFechaNota.Enabled = true;
            LblTotalParcial.Text = "";
            CboFornecedor.Enabled = true;
            TxtProduto.Enabled = true;
            TxtQuant.Enabled = true;
            TxtPrecoCusto.Enabled = true;
            TxtTotalNota.Enabled = true;
            DataVencNF.Enabled = true;
        }



        private void LimpaProduto()
        {
            TxtDescricao.Clear();
            TxtQuant.Clear();
            TxtPrecoCusto.Clear();
            TxtFabricante.Clear();
            TxtProduto.Clear();
            TxtEAN.Clear();
            TxtProduto.Enabled = true;
            TxtProduto.Focus();
            total = 0;
        }

        private void CarregaGrid()
        {
            conn.Open();
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 6;
            var sql = "SELECT * from ItensNotaFiscal where NumeroNF='" + TxtNotaFiscal.Text + "'";
            var cmd = new SqlCommand(sql, conn);
            var leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                dataGridView1.Rows.Add(
                    leitor["Id_Produto"].ToString(),
                    leitor["Cod_EAN"].ToString(),
                    leitor["Descricao"].ToString(),
                    leitor["Quantidade"].ToString(),
                    leitor["PrecoUnitario"].ToString(),
                    leitor["Fabricante"].ToString());
            }
            leitor.Close();
            conn.Close();
            
        }



        private void BtnInserirProduto_Click(object sender, EventArgs e)
        {
            
        if (TxtPrecoCusto.Text == "")
            {
                MessageBox.Show("Falta Preço de Custo!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPrecoCusto.Focus();
            }
            else if (TxtQuant.Text == "")
            {
                MessageBox.Show("Falta Quantidade!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtQuant.Focus();
            }

            else
            {

                dataGridView1.Rows.Insert(0, TxtProduto.Text, TxtEAN.Text, TxtDescricao.Text,  TxtQuant.Text, Convert.ToDouble(TxtPrecoCusto.Text), TxtFabricante.Text);
                qtd = Convert.ToDouble(TxtQuant.Text);
                valor = Convert.ToDouble(TxtPrecoCusto.Text);
                total=total+(qtd * valor);
                LblTotalParcial.Text="R$ "+Convert.ToString(total);
                LimpaProduto();
            }



            double resultado = 0;
            double acumulador = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                resultado = (Convert.ToDouble(row.Cells["PrecoCusto"].Value) * Convert.ToDouble(row.Cells["Qtde"].Value));
                acumulador += Convert.ToDouble(resultado);

            }
            string TotalProdutos = String.Format("{0:C}", acumulador);
            LblTotalParcial.Text = TotalProdutos;
            TxtProduto.Enabled = true;

        }


        private void BtnRemoverItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);

            }

            double resultado = 0;
            double acumulador = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                resultado = (Convert.ToDouble(row.Cells["PrecoCusto"].Value) * Convert.ToDouble(row.Cells["Qtde"].Value));
                acumulador += Convert.ToDouble(resultado);

            }
            string TotalProdutos = String.Format("{0:C}", acumulador);
            LblTotalParcial.Text = TotalProdutos;
        }



        private void BtnFechaNota_Click(object sender, EventArgs e)
        {

            if (TxtNotaFiscal.Text == "")
            {
                MessageBox.Show("Falta Número Nota Fiscal!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNotaFiscal.Focus();
            }
            else if (TxtTotalNota.Text == "")
            {
                MessageBox.Show("Falta Total da Nota Fiscal!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTotalNota.Focus();
            }
            else if (CboFornecedor.Text == "" || CboFornecedor.Text == "Selecione")
            {
                MessageBox.Show("Selecione o Fornecedor!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboFornecedor.Focus();
            }
            else if (CmbCadPor.Text == "Selecione")
            {
                MessageBox.Show("Selecione o Usuário", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbCadPor.Focus();
            }
            else if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Nenhum Item na Nota Fiscal!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtFabricante.Focus();            }

            else
            {
                try
                {
                    conn.Open();
                    SqlCommand INSERIR = new SqlCommand
                    {
                        //SqlCommand UPDATEESTOQUE = new SqlCommand();

                        Connection = conn,
                        // UPDATEESTOQUE.Connection = conn;

                        CommandType = CommandType.Text,
                        //UPDATEESTOQUE.CommandType = CommandType.Text;

                        CommandText = "INSERT INTO NotaFiscal(NotaFiscalNumero,TotalNota,DataLanc,DataVenc,Id_Fornecedor,Id_Usuario) VALUES ('" +TxtNotaFiscal.Text+ "','" +TxtTotalNota.Text.Replace(',', '.') + "','" + DateTime.Now + "','" + DataVencNF.Value.ToString("dd/MM/yyyy") + "',(select Id_Fornecedor from Fornecedor where fornecedor.RazaoSocial='" + CboFornecedor.Text + "'),(select id_usuario from usuario where usuario.usuario='" + CmbCadPor.Text + "'))"
                    };

                    INSERIR.ExecuteNonQuery();
                   
                    MessageBox.Show("Nota Fiscal Gravada com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    


                }
                catch
                {
                    MessageBox.Show("Erro ao Gravar Nota Fiscal! Verifique.","SIG",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                   }
                conn.Close();
                LimpaCampos();
            }
        }




        private void CboFornecedor_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"select Id_Fornecedor,RazaoSocial from Fornecedor order by RazaoSocial")
            {
                Connection = conn
            };
            try
            {
                conn.Open();
                CboFornecedor.Items.Clear();
                SqlDataReader Ler = cmd.ExecuteReader();
                while (Ler.Read())
                {
                    CboFornecedor.Items.Add(Ler.GetValue(1));
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SIG.FrmConsNotaEntrada>().Count() > 0)
            {
                MessageBox.Show("Consulta Nota Fiscal já está Aberto!");

            }
            else
            {
                SIG.FrmConsNotaEntrada ConsNotaFiscalEntrada = new SIG.FrmConsNotaEntrada();
                ConsNotaFiscalEntrada.Show();
            }

        }


        private void TxtNotaFiscal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtNotaFiscal.Text == "")
                {
                    //TxtNotaFiscal.Focus();
                    //MessageBox.Show("Nenhum Código Digitado!");
                }
                else
                {
                    string cadSql = "SELECT * from NotaFiscal where NotaFiscalNumero='" + TxtNotaFiscal.Text + "'";
                    SqlCommand comand = new SqlCommand(cadSql, conn);
                    conn.Open();
                    SqlDataReader ler = comand.ExecuteReader();
                    if (ler.Read() == true)
                    {
                        TxtTotalNota.Text = ler["TotalNota"].ToString();
                        CboFornecedor.Text = ler["Id_Fornecedor"].ToString();
                        DataVencNF.Text = ler["DataVenc"].ToString();
                        ler.Close();
                        CarregaGrid();
                        BtnFechaNota.Enabled = false;
                        BtnDeletar.Enabled = true;
                        BtnRemoverItem.Enabled = false;
                        BtnInserirProduto.Enabled = false;
                        CboFornecedor.Enabled = false;
                        TxtProduto.Enabled = false;
                        TxtQuant.Enabled = false;
                        TxtPrecoCusto.Enabled = false;
                        TxtTotalNota.Enabled = false;
                        DataVencNF.Enabled = false;

                    }

                    else
                    {

                        TxtNotaFiscal.Clear();
                        LimpaCampos();
                        MessageBox.Show("Nota Fiscal Não Encontrada!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    conn.Close();

                }

            }
        }




        private void BtnConsultaProduto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SGDB.FrmConsProduto>().Count() > 0)
            {
                MessageBox.Show("Consulta Produto já está Aberto!");

            }
            else
            {
                SGDB.FrmConsProduto ConsProduto = new SGDB.FrmConsProduto();
                ConsProduto.Show();
            }
        }





        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (TxtNotaFiscal.Text == "")
            {
                MessageBox.Show("Favor Digitar Nº Nota Fiscal!");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand(@"DELETE FROM NotaFiscal  where (NotaFiscal='" + TxtNotaFiscal.Text + "')", conn);
                    SqlCommand comandos = new SqlCommand(@"DELETE FROM ItensNotaFiscal  where (NumeroNF='" + TxtNotaFiscal.Text + "')", conn);
                    comando.CommandType = System.Data.CommandType.Text;
                    comandos.CommandType = System.Data.CommandType.Text;
                    comando.ExecuteNonQuery();
                    comandos.ExecuteNonQuery();
                    MessageBox.Show("Nota Fiscal Deletada com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch
                {
                    MessageBox.Show("Erro ao Deletar Nota Fiscal! Tente Novamente.", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
            LimpaCampos();
            BtnFechaNota.Enabled = true;
            BtnInserirProduto.Enabled = true;
            BtnRemoverItem.Enabled = true;
            BtnDeletar.Enabled = false;
            TxtNotaFiscal.Focus();

        }




        private void TxtProduto_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (TxtProduto.Text == "")
                {

                    TxtProduto.Focus();
                    MessageBox.Show("Nenhum Código Digitado!");
                }
                else
                {

                    string cadSql = "SELECT * from Produto where Id_Produto='" + TxtProduto.Text + "'";
                    SqlCommand comand = new SqlCommand(cadSql, conn);
                    conn.Open();
                    SqlDataReader ler = comand.ExecuteReader();
                    if (ler.Read() == true)
                    {
                        TxtDescricao.Text = ler["Descricao"].ToString();
                        TxtEAN.Text = ler["EAN"].ToString();
                        TxtFabricante.Text = ler["Fabricante"].ToString();
                        TxtProduto.Enabled = false;
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        LimpaProduto();
                        MessageBox.Show("Produto não Encontrado!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
        }



        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            BtnDeletar.Enabled = false;
            BtnInserirProduto.Enabled = true;
            BtnRemoverItem.Enabled = true;
        }



        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TxtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void CmbCadPor_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"select Id_usuario,Usuario from Usuario order by Usuario")
            {
                Connection = conn
            };
            try
            {
                conn.Open();
                CmbCadPor.Items.Clear();
                SqlDataReader Ler = cmd.ExecuteReader();
                while (Ler.Read())
                {
                    CmbCadPor.Items.Add(Ler.GetValue(1));
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtQuant_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void TxtNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

           }
}
