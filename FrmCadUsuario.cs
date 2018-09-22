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


    public partial class FrmCadUsuario : Form
    {
        private SqlConnection conn = ConexaoBanco.sqlConnection;


        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {


            if (TxtNome.Text == "")
            {
                MessageBox.Show("Preencher Nome Completo!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
            }
            else if (TxtEmail.Text == "")
            {
                MessageBox.Show("Preencher E-mail!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEmail.Focus();
            }
            else if (TxtUsuario.Text == "")
            {
                MessageBox.Show("Preencher Usuário!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUsuario.Focus();
            }
            else if (TxtSenha.Text == "")
            {
                MessageBox.Show("Preencher Senha!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtSenha.Focus();
            }
            else if (TxtRepeteSenha.Text == "")
            {
                MessageBox.Show("Repita a Senha!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRepeteSenha.Focus();
            }
            else if (CboTipoUsuario.Text == "Selecione")
            {
                MessageBox.Show("Selecione o Tipo de Usuário!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboTipoUsuario.Focus();
            }
            else if (CboCadPor.Text == "Selecione")
            {
                MessageBox.Show("Selecione Usuário que está realizando a Operação!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboCadPor.Focus();
            }
            else if (TxtSenha.Text != TxtRepeteSenha.Text)
            {
                MessageBox.Show("Senhas Não Conferem! Digite Novamente", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtSenha.Text = "";
                TxtRepeteSenha.Text = "";
                TxtSenha.Focus();
            }
            else
            {
                conn.Open();
                try
                {
                    SqlCommand comando = new SqlCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "INSERT INTO Usuario(Nome,Email,Usuario,Senha,Tipo,Id_User,DataCad) VALUES ('" + TxtNome.Text + "','" + TxtEmail.Text + "','" + TxtUsuario.Text + "','" + TxtSenha.Text + "','" + CboTipoUsuario.Text + "',(select id_usuario from usuario where usuario.usuario='" + CboCadPor.Text + "'),'" + DateTime.Now + "')",
                        Connection = conn
                    };
                    comando.ExecuteNonQuery();                   
                    MessageBox.Show("Usuário Cadastrado com Sucesso!!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                catch
                {
                    MessageBox.Show("Erro ao Cadastrar Usuário! Tente Novamente.", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    

                }
                conn.Close();
                LimpaDados();
            }

        }

      

        private void RepeteSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnCadastrar.PerformClick();
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmConsultaUsuarios>().Count() > 0)
            {
                MessageBox.Show("Consulta Usuário já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmConsultaUsuarios ConsUsuario = new FrmConsultaUsuarios();
                ConsUsuario.Show();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnCadastrar.Enabled = false;
            TxtIdUsuario.Enabled = true;
            LimpaDados();
            TxtIdUsuario.Focus();
        }

        public void LimpaDados()
        {
            TxtIdUsuario.Clear();
            TxtNome.Clear();
            CboTipoUsuario.Text = "Selecione";
            TxtEmail.Clear();
            TxtUsuario.Clear();
            TxtSenha.Clear();
            TxtRepeteSenha.Clear();
            CboCadPor.Text = "Selecione";
            BtnCadastrar.Enabled = true;
            CboCadPor.Enabled = true;
        }


        private void TxtIdUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void TxtIdUsuario_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtIdUsuario.Text == "")
                {

                    TxtNome.Focus();
                    TxtIdUsuario.Enabled = false;
                    BtnDeletar.Enabled = false;
                    BtnAlterar.Enabled = false;
                    BtnCadastrar.Enabled = true;
                    MessageBox.Show("Nenhum Código Digitado!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string cadSql = "SELECT * from Usuario where Id_Usuario='" + TxtIdUsuario.Text + "'";
                    SqlCommand comand = new SqlCommand(cadSql, conn);
                    conn.Open();
                    SqlDataReader ler = comand.ExecuteReader();
                    if (ler.Read() == true)
                    {
                        TxtNome.Text = ler["Nome"].ToString();
                        TxtEmail.Text = ler["Email"].ToString();
                        TxtUsuario.Text = ler["Usuario"].ToString();
                        TxtSenha.Text = ler["Senha"].ToString();
                        CboTipoUsuario.Text = ler["Tipo"].ToString();
                        CboCadPor.Text = ler["Id_User"].ToString();
                        DataCad.Text = ler["DataCad"].ToString();
                        TxtIdUsuario.Enabled = false;
                        BtnAlterar.Enabled = true;
                        BtnDeletar.Enabled = true;
                        BtnCadastrar.Enabled = false;
                        CboCadPor.Enabled = false;
                    }
                    else
                    {

                        LimpaDados();
                        TxtIdUsuario.Enabled = false;
                        BtnAlterar.Enabled = false;
                        BtnDeletar.Enabled = false;
                        CboCadPor.Enabled = true;
                        MessageBox.Show("Cadastro de Usuário não Encontrado!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    conn.Close();

                }

            }

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TxtIdUsuario.Text == "")
            {
                MessageBox.Show("Digite ID Válido!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtIdUsuario.Clear();
                TxtIdUsuario.Focus();
            }
            else if (TxtSenha.Text != TxtRepeteSenha.Text)
            {
                MessageBox.Show("Senhas Não Conferem! Digite Novamente", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSenha.Text = "";
                TxtRepeteSenha.Text = "";
                TxtSenha.Focus();
            }
            else
            {

                try
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand(@"UPDATE Usuario SET Nome='" + TxtNome.Text + "',Email='" + TxtEmail.Text + "',Usuario='" + TxtUsuario.Text + "',Senha='" + TxtSenha.Text + "',Tipo='" + CboTipoUsuario.Text + "' where (Id_Usuario='" + TxtIdUsuario.Text + "')", conn);
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.ExecuteNonQuery();
                    LimpaDados();
                    TxtIdUsuario.Clear();
                    MessageBox.Show("Usuário Atualizado Com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erro ao Atualizar Usuário!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                   }
            }
            conn.Close();
            LimpaDados();
            TxtIdUsuario.Enabled = false;
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnDeletar.Enabled = false;
            TxtNome.Focus();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (TxtIdUsuario.Text == "")
            {
                MessageBox.Show("Favor Digitar Id Usuário!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand(@"DELETE FROM Usuario  where (Id_Usuario='" + TxtIdUsuario.Text + "')", conn);
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.ExecuteNonQuery();
                    LimpaDados();
                    TxtIdUsuario.Clear();
                    MessageBox.Show("Usuário Excluído com Sucesso!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch
                {
                    MessageBox.Show("Erro ao Excluir Usuário", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            conn.Close();
            LimpaDados();
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnDeletar.Enabled = false;
            TxtIdUsuario.Enabled = false;
            TxtNome.Focus();
        }

        private void CboCadPor_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"select Id_usuario,Usuario from Usuario order by Usuario")
            {
                Connection = conn
            };
            conn.Open();
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