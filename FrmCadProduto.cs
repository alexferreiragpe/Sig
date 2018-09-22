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
    public partial class FrmCadProduto : Form
    {

        private SqlConnection conn = ConexaoBanco.sqlConnection;

        public FrmCadProduto()
        {
            InitializeComponent();
        }

        public void LimpaDados()
        {
            TxtCodProduto.Clear();
            TxtDescri.Clear();
            TxtCodEan.Clear();
            CboCategoria.Text = "Selecione";
            TxtPrecoCompra.Clear();
            TxtLucro.Clear();
            TxtPrecoVenda.Clear();
            CboSubCat.Text = "Selecione";
            TxtEstoqueMin.Clear();
            TxtEstoqueMax.Clear();
            CboFabricante.Text = "Selecione";
            TxtICMS.Clear();
            TxtIPI.Clear();
            CboUnidade.Text = "Selecione";
            CboCadPor.Text = "Selecione";
            DataCad.Text = "";
            CboCadPor.Enabled = true;
        }



        private void CboCadPor_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"select Id_usuario,Usuario from Usuario order by Usuario")
            {
                Connection = conn
            };
            try
            {
                conn.Open();
                CboCadPor.Items.Clear();
                SqlDataReader Ler = cmd.ExecuteReader();
                while (Ler.Read())
                {
                    CboCadPor.Items.Add(Ler.GetValue(1));
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

            if (TxtDescri.Text == "")
            {
                MessageBox.Show("Preencher Descrição do Produto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDescri.Focus();
            }
            else if (TxtCodEan.Text == "" || TxtCodEan.TextLength < 13)
            {
                MessageBox.Show("Preencher Código EAN!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCodEan.Focus();
            }
            else if (CboFabricante.Text == "Selecione")
            {
                MessageBox.Show("Selecione Fabricante!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboFabricante.Focus();
            }
            else if (CboCategoria.Text == "Selecione")
            {
                MessageBox.Show("Selecione Categoria!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboCategoria.Focus();
            }
            else if (TxtPrecoCompra.Text == "")
            {
                MessageBox.Show("Preencher Preço Compra!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPrecoCompra.Focus();
            }
            else if (TxtPrecoVenda.Text == "")
            {
                MessageBox.Show("Preencher Preço de Venda!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPrecoVenda.Focus();
            }
            else if (CboSubCat.Text == "Selecione")
            {
                MessageBox.Show("Selecione Sub-Categoria!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboSubCat.Focus();
            }      

            else if (TxtEstoqueMin.Text == "")
            {
                MessageBox.Show("Preencher Estoque Mínimo!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEstoqueMin.Focus();
            }
            else if (TxtEstoqueMax.Text == "")
            {
                MessageBox.Show("Preencher Estoque Máximo", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEstoqueMax.Focus();
            }

            else if (CboUnidade.Text == "Selecione")
            {
                MessageBox.Show("Selecione Unidade!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboUnidade.Focus();
            }
           
            else if (TxtICMS.Text == "")
            {
                MessageBox.Show("Preencher ICMS!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtICMS.Focus();
            }
            else if (TxtIPI.Text == "")
            {
                MessageBox.Show("Preencher IPI!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtIPI.Focus();
            }
            else if (TxtLucro.Text == "")
            {
                MessageBox.Show("Preencher Lucro!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtLucro.Focus();
            }
            else if (CboCadPor.Text == "Selecione")
            {
                MessageBox.Show("Selecione Usuário!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboCadPor.Focus();
            }
            else
            {
                conn.Open();
                try
                {

                    SqlCommand comando = new SqlCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "INSERT INTO Produto(Descricao,Qtd,EAN,Categoria,PrecoCompra,Lucro,PrecoVenda,SubCateg,EstoqueMin,EstoqueMax,Fabricante,ICMS,IPI,Unidade,DataCad,Id_Usuario) VALUES ('" + TxtDescri.Text + "','" + 0 + "','" + TxtCodEan.Text + "','" + CboCategoria.Text + "','" + TxtPrecoCompra.Text + "','" + TxtLucro.Text + "','" + TxtPrecoVenda.Text + "','" + CboSubCat.Text + "','" + TxtEstoqueMin.Text + "','" + TxtEstoqueMax.Text + "','" + CboFabricante.Text + "','" + TxtICMS.Text + "','" + TxtIPI.Text + "','" + CboUnidade.Text + "','" + DateTime.Now + "',(select id_usuario from usuario where usuario.usuario='" + CboCadPor.Text + "'))",
                        Connection = conn
                    };
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto Cadastrado com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erro ao Cadastrar Produto! Tente Novamente.", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                LimpaDados();
                TxtDescri.Focus();
                

            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnCadastrar.Enabled = false;
            TxtCodProduto.Enabled = true;
            TxtCodProduto.Clear();
            LimpaDados();
            TxtCodProduto.Focus();
        }



        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TxtCodEan.TextLength < 13)
            {
                MessageBox.Show("Digite um Código EAN Válido!");
                TxtCodProduto.Focus();
            }
            else
            {
                conn.Open();
                try
                {
                    Double P;
                    P= Convert.ToDouble(TxtPrecoCompra.Text);

                    SqlCommand comando = new SqlCommand(@"UPDATE Produto SET Descricao='" + TxtDescri.Text + "', EAN='" + TxtCodEan.Text + "',Categoria='" + CboCategoria.Text + "',PrecoCompra='" + P + "',Lucro='" + TxtLucro.Text + "',PrecoVenda='" + TxtPrecoVenda.Text + "',SubCateg='" + CboSubCat.Text + "',EstoqueMin='" + TxtEstoqueMin.Text + "',EstoqueMax='" + TxtEstoqueMax.Text + "',Fabricante='" + CboFabricante.Text + "',ICMS='" + TxtICMS.Text + "',IPI='" + TxtIPI.Text + "',Unidade='" + CboUnidade.Text + "' where (Id_Produto='" + TxtCodProduto.Text + "')", conn)
                    {
                        CommandType = CommandType.Text
                    };
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto Atualizado com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erro ao Atualizar Produto! Tente Novamente, Use Separador(.) em Preço!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            LimpaDados();
            TxtCodProduto.Enabled = false;
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnDeletar.Enabled = false;
            TxtDescri.Focus();
            conn.Close();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (TxtCodProduto.Text == "")
            {
                MessageBox.Show("Favor Digitar Código Produto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                try
                {

                    SqlCommand comando = new SqlCommand(@"DELETE FROM Produto  where (Id_Produto='" + TxtCodProduto.Text + "')", conn)
                    {
                        CommandType = CommandType.Text
                    };
                    comando.ExecuteNonQuery();
                    LimpaDados();
                    MessageBox.Show("Produto Deletado com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                catch
                {
                    MessageBox.Show("Erro ao Deletar Produto! Tente Novamente.", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }

            LimpaDados();
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnDeletar.Enabled = false;
            TxtCodProduto.Enabled = false;
            TxtDescri.Focus();
            conn.Close();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SGDB.FrmConsProduto>().Count() > 0)
            {
                MessageBox.Show("Consulta Produto já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                SGDB.FrmConsProduto ConsultaProduto = new SGDB.FrmConsProduto();
                ConsultaProduto.Show();
            }
        }

        private void TxtCodProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtCodProduto.Text == "")
                {

                    TxtDescri.Focus();
                    TxtCodProduto.Enabled = false;
                    BtnDeletar.Enabled = false;
                    BtnAlterar.Enabled = false;
                    BtnCadastrar.Enabled = true;

                    MessageBox.Show("Nenhum Código Digitado!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Open();
                    string cadSql = "SELECT * from Produto inner join usuario on Produto.id_Usuario=usuario.Id_usuario where Id_Produto='" + TxtCodProduto.Text + "'";
                    SqlCommand comand = new SqlCommand(cadSql, conn);
                    SqlDataReader ler = comand.ExecuteReader();
                    if (ler.Read() == true)
                    {
                        TxtDescri.Text = ler["Descricao"].ToString();
                        TxtCodEan.Text = ler["EAN"].ToString();
                        CboCategoria.Text = ler["Categoria"].ToString();
                        TxtPrecoCompra.Text = ler["PrecoCompra"].ToString();
                        TxtLucro.Text = ler["Lucro"].ToString();
                        TxtPrecoVenda.Text = ler["PrecoVenda"].ToString();
                        CboSubCat.Text = ler["SubCateg"].ToString();
                        TxtEstoqueMin.Text = ler["EstoqueMin"].ToString();
                        TxtEstoqueMax.Text = ler["EstoqueMax"].ToString();
                        CboFabricante.Text = ler["Fabricante"].ToString();
                        TxtICMS.Text = ler["ICMS"].ToString();
                        TxtIPI.Text = ler["IPI"].ToString();
                        CboUnidade.Text = ler["Unidade"].ToString();
                        CboCadPor.Text = ler["Usuario"].ToString();
                        DataCad.Text = ler["DataCad"].ToString();
                        TxtCodProduto.Enabled = false;
                        BtnAlterar.Enabled = true;
                        BtnDeletar.Enabled = true;
                        CboCadPor.Enabled = false;
                    }
                    else
                    {

                        LimpaDados();
                        TxtCodProduto.Enabled = false;
                        BtnAlterar.Enabled = false;
                        BtnDeletar.Enabled = false;
                        BtnCadastrar.Enabled = true;
                        MessageBox.Show("Cadastro de Produto Não Encontrado!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    conn.Close();

                }

            }
        }

        private void TxtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void TxtCodEan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void TxtLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void TxtEstoqueMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }



        private void TxtICMS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void TxtEstoqueMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void TxtIPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

       /* private void TxtPrecoCompra_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(TxtPrecoCompra.Text, out value))
                TxtPrecoCompra.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                TxtPrecoCompra.Text = String.Empty;
        }*/
    }
}
