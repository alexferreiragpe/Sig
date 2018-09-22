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
    public partial class FrmCadCliente : Form
    {

        public void LimpaDados()
        {
            TxtCodCliente.Clear();
            TxtNome.Clear();
            CboSexo.Text = "Selecione";
            TxtEndereco.Clear();
            TxtBairro.Clear();
            TxtCidade.Clear();
            MktCep.Clear();
            CmbEstado.Text = "Selecione";
            MktFoneFixo.Clear();
            MkFoneComercial.Clear();
            MktCelular.Clear();
            TxtRG.Clear();
            TxtEmail.Clear();
            MktCPF.Clear();
            dataNasc.Text = "";
            CboCadPor.Text = "Selecione";
            CboCadPor.Enabled = true;
        }

        private SqlConnection conn = ConexaoBanco.sqlConnection;

        public FrmCadCliente()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Preencher Nome!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
            }
            else if (TxtEndereco.Text == "")
            {
                MessageBox.Show("Preencher Endereço!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEndereco.Focus();
            }
            else if (CboSexo.Text == "Selecione")
            {
                MessageBox.Show("Selecione Sexo!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboSexo.Focus();
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
            else if (CmbEstado.Text == "Selecione")
            {
                MessageBox.Show("Selecione Estado!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbEstado.Focus();
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
            else if (!MkFoneComercial.MaskCompleted)
            {
                MessageBox.Show("Preencher Telefone Comercial!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MkFoneComercial.Focus();
            }
            else if (!MktCelular.MaskCompleted)
            {
                MessageBox.Show("Preencher Telefone Celular!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MktCelular.Focus();
            }
            else if (TxtRG.Text == "")
            {
                MessageBox.Show("Preencher RG!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRG.Focus();
            }
           
            else if (!MktCPF.MaskCompleted)
            {
                MessageBox.Show("Preencher CPF/CNPJ!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MktCPF.Focus();
            }
            else if (TxtEmail.Text == "")
            {
                MessageBox.Show("Preencher E-mail!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEmail.Focus();
            }
            else if (CboCadPor.Text == "Selecione")
            {
                MessageBox.Show("Selecione o Usuário!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbEstado.Focus();
            }
            else
            {
                conn.Open();
                try
                {          
                    SqlCommand comando = new SqlCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "INSERT INTO Clientes(Nome,Sexo,Endereco,Bairro,Cidade,Cep,Estado,FoneFixo,FoneComercial,Celular,RG,Email,CPF,DataNascimento,DataCad,Id_Usuario) VALUES ('" + TxtNome.Text + "','" + CboSexo.Text + "','" + TxtEndereco.Text + "','" + TxtBairro.Text + "','" + TxtCidade.Text + "','" + MktCep.Text + "','" + CmbEstado.Text + "','" + MktFoneFixo.Text + "','" + MkFoneComercial.Text + "','" + MktCelular.Text + "','" + TxtRG.Text + "','" + TxtEmail.Text + "','" + MktCPF.Text + "','" + dataNasc.Value.ToString("dd/MM/yyyy") + "','" + DateTime.Now + "',(select id_usuario from usuario where usuario.usuario='"+CboCadPor.Text+"'))",
                        Connection = conn
                    };
                    comando.ExecuteNonQuery();                    
                    MessageBox.Show("Cliente Cadastrado com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {

                    MessageBox.Show("Erro ao Cadastrar Cliente!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LimpaDados();
                TxtNome.Focus();
                conn.Close();

            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnCadastrar.Enabled = false;
            TxtCodCliente.Enabled = true;
            LimpaDados();
            TxtCodCliente.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConsultar_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmConsClientes>().Count() > 0)
            {
                MessageBox.Show("Consulta Clientes já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmConsClientes ConsultaCliente = new FrmConsClientes();
                ConsultaCliente.Show();
            }
        }

        private void BtnAlterar_Click_1(object sender, EventArgs e)
        {
            if (TxtCodCliente.Text == "")
            {
                MessageBox.Show("Digite um Código Válido!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodCliente.Focus();
            }
            else
            {

                try
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand(@"UPDATE CLIENTES SET Nome='" + TxtNome.Text + "',Sexo='" + CboSexo.Text + "',Endereco='" + TxtEndereco.Text + "',Bairro='" + TxtBairro.Text + "',Cidade='" + TxtCidade.Text + "',Cep='" + MktCep.Text + "',Estado='" + CmbEstado.Text + "',FoneFixo='" + MktFoneFixo.Text + "',FoneComercial='" + MkFoneComercial.Text + "',Celular='" + MktCelular.Text + "',Rg='" + TxtRG.Text + "',Email='" + TxtEmail.Text + "',CPF='" + MktCPF.Text + "',DataNascimento='" + dataNasc.Value.ToString("dd/MM/yyyy") + "'  where (Id_Cliente='" + TxtCodCliente.Text + "')", conn)
                    {
                        CommandType = CommandType.Text
                    };
                    comando.ExecuteNonQuery();
                    LimpaDados();
                    CboCadPor.Enabled = true;
                    MessageBox.Show("Cliente Atualizado Com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch
                {
                    MessageBox.Show("Erro ao Atualizar Cliente!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            conn.Close();
            LimpaDados();
            TxtCodCliente.Enabled = false;
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnDeletar.Enabled = false;
            TxtNome.Focus();
            CboCadPor.Enabled = true;

        }

        private void BtnDeletar_Click_1(object sender, EventArgs e)
        {
            if (TxtCodCliente.Text == "")
            {
                MessageBox.Show("Favor Digitar Código Cliente!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand(@"DELETE FROM CLIENTES  where (Id_Cliente='" + TxtCodCliente.Text + "')", conn)
                    {
                        CommandType = CommandType.Text
                    };
                    comando.ExecuteNonQuery();
                    TxtCodCliente.Clear();
                    MessageBox.Show("Cliente Excluído com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch
                {
                    MessageBox.Show("Erro ao Excluir Cliente", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
            LimpaDados();
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnDeletar.Enabled = false;
            TxtCodCliente.Enabled = false;
            TxtNome.Focus();
        }

        private void TxtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void TxtCodCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtCodCliente.Text == "")
                {

                    TxtNome.Focus();
                    TxtCodCliente.Enabled = false;
                    BtnDeletar.Enabled = false;
                    BtnAlterar.Enabled = false;
                    BtnCadastrar.Enabled = true;
                    TxtCodCliente.Enabled = false;
                    MessageBox.Show("Nenhum Código Digitado!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conn.Open();
                    string cadSql = "SELECT * from Clientes inner join usuario on clientes.id_usuario=usuario.Id_usuario where Id_Cliente='" + TxtCodCliente.Text + "'";
                    SqlCommand comand = new SqlCommand(cadSql, conn);                    
                    SqlDataReader ler = comand.ExecuteReader();
                    if (ler.Read() == true)
                    {
                        TxtNome.Text = ler["Nome"].ToString();
                        CboSexo.Text = ler["Sexo"].ToString();
                        TxtEndereco.Text = ler["Endereco"].ToString();
                        TxtBairro.Text = ler["Bairro"].ToString();
                        TxtCidade.Text = ler["Cidade"].ToString();
                        MktCep.Text = ler["Cep"].ToString();
                        CmbEstado.Text = ler["Estado"].ToString();
                        MktFoneFixo.Text = ler["FoneFixo"].ToString();
                        MkFoneComercial.Text = ler["FoneComercial"].ToString();
                        MktCelular.Text = ler["Celular"].ToString();
                        TxtRG.Text = ler["Rg"].ToString();
                        TxtEmail.Text = ler["Email"].ToString();
                        MktCPF.Text = ler["CPF"].ToString();
                        dataNasc.Text = ler["DataNascimento"].ToString();
                        CboCadPor.Text = ler["Usuario"].ToString();
                        DataCad.Text = ler["DataCad"].ToString();
                        TxtCodCliente.Enabled = false;
                        BtnAlterar.Enabled = true;
                        BtnDeletar.Enabled = true;
                        CboCadPor.Enabled = false;
                    }
                    else
                    {

                        LimpaDados();
                        TxtCodCliente.Enabled = false;
                        BtnAlterar.Enabled = false;
                        BtnDeletar.Enabled = false;
                        BtnCadastrar.Enabled = true;
                        MessageBox.Show("Cadastro de Cliente não Encontrado!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    conn.Close();

                }

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
        
    }
}
