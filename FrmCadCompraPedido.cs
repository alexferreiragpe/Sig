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

namespace SIG
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
            dgvProdutos.Rows.Clear();
            TxtNotaFiscal.Focus();
            BtnFechaNota.Enabled = true;
            LblTotalParcial.Text = "";
            CboFornecedor.Enabled = true;
            TxtProduto.Enabled = true;
            TxtQuant.Enabled = true;
            TxtPrecoCusto.Enabled = true;
            TxtTotalNota.Enabled = true;
            DataVencNF.Enabled = true;
            CmbCadPor.Text = "Selecione";
            CmbCadPor.Enabled = true;
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
            DataVencNF.Show();
        }

        private void CarregaGrid()
        {
            //conn.Open();
            dgvProdutos.Rows.Clear();
            dgvProdutos.ColumnCount = 6;
            string sql = "SELECT * from NotaFiscalItens where NFNumero='" + TxtNotaFiscal.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                dgvProdutos.Rows.Add(
                    leitor["Id_Produto"].ToString(),
                    leitor["Qtd"].ToString(),
                    leitor["Descricao"].ToString(),
                    leitor["PrecoUnitario"].ToString(),
                    leitor["NFNumero"].ToString(),
                    leitor["Id_NotaFiscal"].ToString());
            }
            leitor.Close();
            //conn.Close();

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
                qtd = Convert.ToDouble(TxtQuant.Text);
                valor = Convert.ToDouble(TxtPrecoCusto.Text);
                total = total + (qtd * valor);
                dgvProdutos.Rows.Insert(0, TxtProduto.Text, TxtEAN.Text, TxtDescricao.Text, TxtQuant.Text, Convert.ToDouble(TxtPrecoCusto.Text), qtd * valor, TxtFabricante.Text);
                LblTotalParcial.Text = "R$ " + Convert.ToString(total);
                LimpaProduto();
            }



            double resultado = 0;
            double acumulador = 0;

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                resultado = (Convert.ToDouble(row.Cells["PrecoUnitario"].Value) * Convert.ToDouble(row.Cells["Qtde"].Value));
                acumulador += Convert.ToDouble(resultado);

            }
            string TotalProdutos = string.Format("{0:C}", acumulador);
            LblTotalParcial.Text = TotalProdutos;
            TxtProduto.Enabled = true;

        }


        private void BtnRemoverItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvProdutos.SelectedRows)
            {
                dgvProdutos.Rows.RemoveAt(item.Index);

            }

            double resultado = 0;
            double acumulador = 0;

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                resultado = (Convert.ToDouble(row.Cells["PrecoUnitario"].Value) * Convert.ToDouble(row.Cells["Qtde"].Value));
                acumulador += Convert.ToDouble(resultado);

            }
            string TotalProdutos = string.Format("{0:C}", acumulador);
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
            else if (dgvProdutos.RowCount == 0)
            {
                MessageBox.Show("Nenhum Item na Nota Fiscal!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtFabricante.Focus();
            }

            else
            {
                
                try
                {
                    conn.Open();
                    SqlCommand INSERIRNOTAFISCAL = new SqlCommand
                    {
                        Connection = conn,
                        CommandType = CommandType.Text,
                        CommandText = "INSERT INTO NotaFiscal(NotaFiscalNumero,TotalNota,DataLanc,DataVenc,Id_Fornecedor,Id_Usuario) VALUES ('" + TxtNotaFiscal.Text + "','" + TxtTotalNota.Text.Replace(',', '.') + "','" + DateTime.Now + "','" + DataVencNF.Value.ToString("dd/MM/yyyy") + "',(select Id_Fornecedor from Fornecedor where fornecedor.RazaoSocial='" + CboFornecedor.Text + "'),(select id_usuario from usuario where usuario.usuario='" + CmbCadPor.Text + "'))",

                    };
                    INSERIRNOTAFISCAL.ExecuteNonQuery();
                   
                    SqlCommand INSERIRNOTAFISCALITENS = new SqlCommand
                    {
                        Connection = conn,
                        CommandType = CommandType.Text,
                        //CommandText = "insert into NotaFiscalItens values(1, 555, 'c#', 5.55, 1, 3)"
                        CommandText = "INSERT INTO NotaFiscalItens VALUES (@Id_Produto,@Qtd,@Descricao,@PrecoUnitario,'" +Convert.ToInt16(TxtNotaFiscal.Text) + "',select notafiscal.id_notafiscal from NotaFiscal inner join notafiscalitens on notafiscal.Id_NotaFiscal=notafiscalitens.Id_NotaFiscal)",
                    };

                    for (int i = 0; i < dgvProdutos.Rows.Count; i++)
                    {
                        INSERIRNOTAFISCALITENS.Parameters.Clear();
                        INSERIRNOTAFISCALITENS.Parameters.AddWithValue("@Id_Produto",
                            dgvProdutos.Rows[i].Cells[0].Value);
                        INSERIRNOTAFISCALITENS.Parameters.AddWithValue("@Qtd",
                            dgvProdutos.Rows[i].Cells[4].Value);
                        INSERIRNOTAFISCALITENS.Parameters.AddWithValue("@Descricao",
                            dgvProdutos.Rows[i].Cells[2].Value);
                        INSERIRNOTAFISCALITENS.Parameters.AddWithValue("@Precounitario",
                            dgvProdutos.Rows[i].Cells[3].Value);
                        INSERIRNOTAFISCALITENS.ExecuteNonQuery();
                    }

                    INSERIRNOTAFISCALITENS.ExecuteNonQuery();
                    MessageBox.Show("Nota Fiscal Gravada com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    LimpaCampos();

                }
                catch
                {
                    MessageBox.Show("Erro ao Gravar Nota Fiscal! Verifique.", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
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
            if (Application.OpenForms.OfType<FrmConsNotaEntrada>().Count() > 0)
            {
                MessageBox.Show("Consulta Nota Fiscal já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmConsNotaEntrada ConsNotaFiscalEntrada = new FrmConsNotaEntrada
                {
                    MdiParent = FrmPrincipal.ActiveForm
                };
                ConsNotaFiscalEntrada.Show();
            }
            
            

        }


        private void TxtNotaFiscal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conn.Open();
                if (TxtNotaFiscal.Text == "")
                {
                    //TxtNotaFiscal.Focus();
                    //MessageBox.Show("Nenhum Código Digitado!");
                }
                else
                {
                    string cadSql = "SELECT totalnota,datalanc,datavenc,razaosocial,usuario from NotaFiscal inner join usuario on notafiscal.id_usuario=usuario.id_usuario inner join fornecedor on notafiscal.id_fornecedor=fornecedor.id_fornecedor where NotaFiscalNumero='" + TxtNotaFiscal.Text + "'";
                    SqlCommand comand = new SqlCommand(cadSql, conn);

                    SqlDataReader ler = comand.ExecuteReader();
                    if (ler.Read() == true)
                    {
                        TxtTotalNota.Text = ler["TotalNota"].ToString();
                        CboFornecedor.Text = ler["razaosocial"].ToString();
                        DataVencNF.Text = ler["DataVenc"].ToString();
                        CmbCadPor.Text = ler["Usuario"].ToString();
                        ler.Close();
                        CarregaGrid();
                        BtnFechaNota.Enabled = false;
                        BtnDeletar.Enabled = true;
                        BtnRemoverItem.Enabled = false;
                        BtnInserirProduto.Enabled = false;
                        CboFornecedor.Enabled = false;
                        CmbCadPor.Enabled = false;
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



                }
                conn.Close();
            }
        }




        private void BtnConsultaProduto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SGDB.FrmConsProduto>().Count() > 0)
            {
                MessageBox.Show("Consulta Produto já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                MessageBox.Show("Favor Digitar Nº Nota Fiscal!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand(@"DELETE FROM NotaFiscal  where (NotaFiscalNumero='" + TxtNotaFiscal.Text + "')", conn);
                    SqlCommand comandos = new SqlCommand(@"DELETE FROM NotaFiscalItens  where (NFNumero='" + TxtNotaFiscal.Text + "')", conn);
                    comando.CommandType = CommandType.Text;
                    comandos.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                    comandos.ExecuteNonQuery();
                    MessageBox.Show("Nota Fiscal Deletada com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch
                {
                    MessageBox.Show("Erro ao Deletar Nota Fiscal! Tente Novamente", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CmbCadPor_Enter(object sender, EventArgs e)
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

        private void CboFornecedor_Enter(object sender, EventArgs e)
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
