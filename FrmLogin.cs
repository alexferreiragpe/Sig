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
    public partial class FrmLogin : Form
    {

        private SqlConnection sqlConn = ConexaoBanco.sqlConnection;

        private string _Sql = string.Empty;

        public bool logado = false;



        public FrmLogin()
        {
            InitializeComponent();
        }

        public void logar()
        {
            string usu, pwd;

            try
            {

                usu = TxtUsuario.Text;
                pwd = TxtSenha.Text;
                sqlConn.Open();
                _Sql = "SELECT COUNT(Id_Usuario) FROM Usuario WHERE usuario=@Usuario AND senha=@Senha";
                SqlCommand cmd = new SqlCommand(_Sql, sqlConn);
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usu;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = pwd;


                int v = (int)cmd.ExecuteScalar();

                if (v > 0)
                {
                    logado = true;
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("Erro ao Logar! Usuário ou Senha Inválidos.", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logado = false;
                }
                sqlConn.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro + "Erro ao Conectar com o Banco de Dados");

            }

        }



        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtUsuario.Focus();

        }



        private void BtnEntrar_Click(object sender, EventArgs e)
        {

            logar();
            TxtUsuario.Text = "";
            TxtSenha.Text = "";
            TxtUsuario.Focus();
        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private void TxtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnEntrar.PerformClick();
            }

        }

        private void LblEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEsqueciSenha frmEsqueci = new FrmEsqueciSenha();
            frmEsqueci.Show();
        }
    }
}
