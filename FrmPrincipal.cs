using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGDB;

namespace SGVB
{
    public partial class FrmPrincipal : Form
    {
        private SqlConnection conn = ConexaoBanco.sqlConnection;


        public FrmPrincipal()
        {
            InitializeComponent();
        }



        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<FrmCadCliente>().Count() > 0)
            {
                MessageBox.Show("Cadastro de Cliente já está Aberto!");

            }
            else
            {
                FrmCadCliente CadCliente = new FrmCadCliente();
                CadCliente.MdiParent = this;
                CadCliente.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadFornecedor>().Count() > 0)
            {
                MessageBox.Show("Cadastro de Fornecedor já está Aberto!");

            }
            else
            {
                FrmCadFornecedor CadFornecedor = new FrmCadFornecedor();
                CadFornecedor.MdiParent = this;
                CadFornecedor.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadProduto>().Count() > 0)
            {
                MessageBox.Show("Cadastro de Produto já está Aberto!");

            }
            else
            {
                FrmCadProduto CadProduto = new FrmCadProduto();
                CadProduto.MdiParent = this;
                CadProduto.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadUsuario>().Count() > 0)
            {
                MessageBox.Show("Cadastro de Usuário já está Aberto!");

            }
            else
            {
                FrmCadUsuario CadUsuario = new FrmCadUsuario();
                CadUsuario.MdiParent = this;
                CadUsuario.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCompraPedido>().Count() > 0)
            {
                MessageBox.Show("Pedido de Compra já está Aberto!");

            }
            else
            {
                FrmCompraPedido CompraPedido = new FrmCompraPedido();
                CompraPedido.MdiParent = this;
                CompraPedido.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCompraOrcamento>().Count() > 0)
            {
                MessageBox.Show("Consulta Compras já está Aberto!");

            }
            else
            {
                FrmCompraOrcamento CompraOrcamento = new FrmCompraOrcamento();
                CompraOrcamento.MdiParent = this;
                CompraOrcamento.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmVendaPedido>().Count() > 0)
            {
                MessageBox.Show("Vendas já está Aberto!");

            }
            else
            {
                FrmVendaPedido VendaPedido = new FrmVendaPedido();
                VendaPedido.MdiParent = this;
                VendaPedido.Show();
            }
        }



        private void button10_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmEstoqueConsultar>().Count() > 0)
            {
                MessageBox.Show("Consulta de Estoque já está Aberto!");

            }
            else
            {
                FrmEstoqueConsultar EstoqueConsultar = new FrmEstoqueConsultar();
                EstoqueConsultar.MdiParent = this;
                EstoqueConsultar.Show();
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Deseja Fechar o Sistema?", "Fechar", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.No)
                e.Cancel = true;
        }



        private void button19_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("NotePad");
        }



        private void button21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Excel");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToShortTimeString();
        }


        private void button23_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmSobre>().Count() > 0)
            {
                MessageBox.Show("Sobre já está Aberto!");

            }
            else
            {
                FrmSobre Sobre = new FrmSobre();
                Sobre.MdiParent = this;
                Sobre.Show();

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FrmPrincipal prin = new FrmPrincipal();
            FrmLogin Logout = new FrmLogin();
            Logout.Show();
            this.Hide();
            this.Show();


        }

        private void BtnVendaConsulta_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmConsItemVenda>().Count() > 0)
            {
                MessageBox.Show("Consulta de Vendas já esta Aberta!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmConsItemVenda VendaConsulta = new FrmConsItemVenda();
                VendaConsulta.MdiParent = this;
                VendaConsulta.Show();

            }
            

        }
    }
}
