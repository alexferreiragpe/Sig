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
    public partial class FrmCadFornecedor : Form
    {

        private SqlConnection conn = ConexaoBanco.sqlConnection;

        public FrmCadFornecedor()
        {
            InitializeComponent();
        }

        public void LimpaDados()
        {
            TxtCodFornecedor.Clear();
            TxtRazao.Clear();
            MktCNPJ.Clear();
            TxtNomeFan.Clear();
            MktIE.Clear();
            TxtEndereco.Clear();
            CboTipoPessoa.Text = "Selecione";
            TxtCidade.Clear();
            TxtBairro.Clear();
            CboEstado.Text = "Selecione";
            MktCep.Clear();
            MktFoneFixo.Clear();
            MktFoneComercial.Clear();
            MktCelular.Clear();
            TxtHomePage.Clear();
            CboCadPor.Text = "Selecione";
            TxtEmail.Clear();
            DataCad.Text = "";
            CboCadPor.Enabled = true;

        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TxtRazao.Text == "")
            {
                MessageBox.Show("Preencher Razão Social!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRazao.Focus();
            }
            else if (!MktCNPJ.MaskCompleted)
            {
                MessageBox.Show("Preencher CNPJ!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MktCNPJ.Focus();
            }
            else if (TxtNomeFan.Text == "")
            {
                MessageBox.Show("Preencher Nome Fantasia!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNomeFan.Focus();
            }
            
            else if (!MktIE.MaskCompleted)
            {
                MessageBox.Show("Preencher Inscrição Estadual!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MktIE.Focus();
            }
            else if (TxtEndereco.Text == "")
            {
                MessageBox.Show("Preencher Endereço!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEndereco.Focus();
            }
            else if (CboTipoPessoa.Text == "Selecione")
            {
                MessageBox.Show("Selecione Tipo Pessoa!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboTipoPessoa.Focus();
            }
            else if (TxtCidade.Text == "")
            {
                MessageBox.Show("Preencher Cidade!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCidade.Focus();
            }
            else if (TxtBairro.Text == "")
            {
                MessageBox.Show("Preencher Bairro!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtBairro.Focus();
            }
            else if (CboEstado.Text == "Selecione")
            {
                MessageBox.Show("Selecione o Estado!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboEstado.Focus();
            }

            else if (!MktCep.MaskCompleted)
            {
                MessageBox.Show("Preencher Cep!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MktCep.Focus();
            }

            else if (!MktFoneFixo.MaskCompleted)
            {
                MessageBox.Show("Preencher Telefone Fixo!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MktFoneFixo.Focus();
            }
            else if (!MktFoneComercial.MaskCompleted)
            {
                MessageBox.Show("Preencher Telefone Comercial!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MktFoneComercial.Focus();
            }
            else if (!MktCelular.MaskCompleted)
            {
                MessageBox.Show("Preencher Telefone Celular!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MktCelular.Focus();
            }
            else if (TxtHomePage.Text == "")
            {
                MessageBox.Show("Preencher Site!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtHomePage.Focus();
            }
            else if (CboCadPor.Text == "Selecione")
            {
                MessageBox.Show("Selecione Cadastrado Por!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboCadPor.Focus();
            }

            else if (TxtEmail.Text == "")
            {
                MessageBox.Show("Preencher E-mail!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEmail.Focus();
            }
            else
            {
                conn.Open();
                try
                {

                    SqlCommand comando = new SqlCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "INSERT INTO Fornecedor(RazaoSocial,CNPJ,NomeFantasia,IE,Endereco,TipoPessoa,Cidade,Bairro,Estado,Cep,FoneFixo,FoneComercial,Celular,Site,Email,DataCad,Id_Usuario) VALUES ('" + TxtRazao.Text + "','" + MktCNPJ.Text + "','" + TxtNomeFan.Text + "','" + MktIE.Text + "','" + TxtEndereco.Text + "','" + CboTipoPessoa.Text + "','" + TxtCidade.Text + "','" + TxtBairro.Text + "','" + CboEstado.Text + "','" + MktCep.Text + "','" + MktFoneFixo.Text + "','" + MktFoneComercial.Text + "','" + MktCelular.Text + "','" + TxtHomePage.Text + "','" + TxtEmail.Text + "','" + DateTime.Now + "',(select id_usuario from usuario where usuario.usuario='" + CboCadPor.Text + "'))",
                        Connection = conn
                    };
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor Cadastrado com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                catch
                {
                    MessageBox.Show("Erro ao Cadastrar Fornecedor! Tente Novamente.", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LimpaDados();
                TxtRazao.Focus();
                conn.Close();

            }
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnCadastrar.Enabled = false;
            TxtCodFornecedor.Enabled = true;
            LimpaDados();
            TxtCodFornecedor.Focus();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TxtCodFornecedor.Text == "")
            {
                MessageBox.Show("Digite um Código Válido!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCodFornecedor.Focus();
            }
            else
            {
                conn.Open();
                try
                {

                    SqlCommand comando = new SqlCommand(@"UPDATE Fornecedor SET RazaoSocial='" + TxtRazao.Text + "',CNPJ='" + MktCNPJ.Text + "',NomeFantasia='" + TxtNomeFan.Text + "',IE='" + MktIE.Text + "',Endereco='" + TxtEndereco.Text + "',TipoPessoa='" + CboTipoPessoa.Text + "',Cidade='" + TxtCidade.Text + "',Bairro='" + TxtBairro.Text + "',Estado='" + CboEstado.Text + "',Cep='" + MktCep.Text + "',FoneFixo='" + MktFoneFixo.Text + "',FoneComercial='" + MktFoneComercial.Text + "',Celular='" + MktCelular.Text + "',Site='" + TxtHomePage.Text + "',Email='" + TxtEmail.Text + "',DataCad='" + DateTime.Now + "' where (Id_Fornecedor='" + TxtCodFornecedor.Text + "')", conn)
                    {
                        CommandType = CommandType.Text
                    };
                    comando.ExecuteNonQuery();
                    LimpaDados();
                    TxtCodFornecedor.Clear();
                    MessageBox.Show("Fornecedor Atualizado com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch
                {
                    MessageBox.Show("Erro ao Atualizar Fornecedor! Tente Novamente.", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                       }
            }
            conn.Close();
            LimpaDados();
            TxtCodFornecedor.Enabled = false;
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnDeletar.Enabled = false;
            TxtRazao.Focus();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (TxtCodFornecedor.Text == "")
            {
                MessageBox.Show("Favor Digitar Código Fornecedor!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand(@"DELETE FROM Fornecedor  where (Id_Fornecedor='" + TxtCodFornecedor.Text + "')", conn)
                    {
                        CommandType = CommandType.Text
                    };
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor Deletado com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CboCadPor.Enabled = true;                    
                }

                catch
                {
                    MessageBox.Show("Erro ao Deletar Fornecedor! Tente Novamente.", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
            LimpaDados();
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnDeletar.Enabled = false;
            TxtCodFornecedor.Enabled = false;
            TxtRazao.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SGDB.FrmConsFornecedor>().Count() > 0)
            {
                MessageBox.Show("Consulta Fornecedor já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                SGDB.FrmConsFornecedor ConsultaFornecedor = new SGDB.FrmConsFornecedor();
                ConsultaFornecedor.Show();
            }
        }



        private void CboCadPor_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"select Id_usuario,Usuario from Usuario order by Usuario")
            {
                Connection = conn
            };
            try
            {
                CboCadPor.Items.Clear();
                SqlDataReader Ler = cmd.ExecuteReader();
                while (Ler.Read())
                {
                    CboCadPor.Items.Add(Ler.GetValue(1));
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        

        private void TxtCodFornecedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtCodFornecedor.Text == "")
                {

                    TxtRazao.Focus();
                    TxtCodFornecedor.Enabled = false;
                    BtnDeletar.Enabled = false;
                    BtnAlterar.Enabled = false;
                    BtnCadastrar.Enabled = true;
                    MessageBox.Show("Nenhum Código Digitado!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Open();
                    string cadSql = "SELECT * from Fornecedor inner join usuario on fornecedor.id_usuario=usuario.id_usuario where Id_Fornecedor='" + TxtCodFornecedor.Text + "'";
                    SqlCommand comand = new SqlCommand(cadSql, conn);                    
                    SqlDataReader ler = comand.ExecuteReader();
                    if (ler.Read() == true)
                    {
                        TxtRazao.Text = ler["RazaoSocial"].ToString();
                        MktCNPJ.Text = ler["CNPJ"].ToString();
                        TxtNomeFan.Text = ler["NomeFantasia"].ToString();
                        MktIE.Text = ler["IE"].ToString();
                        TxtEndereco.Text = ler["Endereco"].ToString();
                        CboTipoPessoa.Text = ler["TipoPessoa"].ToString();
                        TxtCidade.Text = ler["Cidade"].ToString();
                        TxtBairro.Text = ler["Bairro"].ToString();
                        CboEstado.Text = ler["Estado"].ToString();
                        MktCep.Text = ler["Cep"].ToString();
                        MktFoneFixo.Text = ler["FoneFixo"].ToString();
                        MktFoneComercial.Text = ler["FoneComercial"].ToString();
                        MktCelular.Text = ler["Celular"].ToString();
                        TxtHomePage.Text = ler["Site"].ToString();
                        TxtEmail.Text = ler["Email"].ToString();
                        DataCad.Text = ler["DataCad"].ToString();
                        CboCadPor.Text = ler["usuario"].ToString();
                        TxtCodFornecedor.Enabled = false;
                        BtnAlterar.Enabled = true;
                        BtnDeletar.Enabled = true;
                        CboCadPor.Enabled = false;
                        DataCad.Enabled = false;
                    }
                    else
                    {

                        LimpaDados();
                        TxtCodFornecedor.Enabled = false;
                        BtnAlterar.Enabled = false;
                        BtnDeletar.Enabled = false;
                        BtnCadastrar.Enabled = true;
                        CboCadPor.Enabled = true;
                        MessageBox.Show("Cadastro de Fornecedor Não Encontrado!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    conn.Close();

                }

            }
        }

        private void TxtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

    }


}
