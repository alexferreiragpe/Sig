using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
                MessageBox.Show("Cadastro de Cliente já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmCadCliente CadCliente = new FrmCadCliente
                {
                    MdiParent = this
                };
                CadCliente.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadFornecedor>().Count() > 0)
            {
                MessageBox.Show("Cadastro de Fornecedor já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmCadFornecedor CadFornecedor = new FrmCadFornecedor
                {
                    MdiParent = this
                };
                CadFornecedor.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadProduto>().Count() > 0)
            {
                MessageBox.Show("Cadastro de Produto já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmCadProduto CadProduto = new FrmCadProduto
                {
                    MdiParent = this
                };
                CadProduto.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadUsuario>().Count() > 0)
            {
                MessageBox.Show("Cadastro de Usuário já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmCadUsuario CadUsuario = new FrmCadUsuario
                {
                    MdiParent = this
                };
                CadUsuario.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCompraPedido>().Count() > 0)
            {
                MessageBox.Show("Pedido de Compra já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmCompraPedido CompraPedido = new FrmCompraPedido
                {
                    MdiParent = this
                };
                CompraPedido.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCompraOrcamento>().Count() > 0)
            {
                MessageBox.Show("Consulta Compras já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmCompraOrcamento CompraOrcamento = new FrmCompraOrcamento
                {
                    MdiParent = this
                };
                CompraOrcamento.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmVendaPedido>().Count() > 0)
            {
                MessageBox.Show("Vendas já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmVendaPedido VendaPedido = new FrmVendaPedido
                {
                    MdiParent = this
                };
                VendaPedido.Show();
            }
        }



        private void button10_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmEstoqueConsultar>().Count() > 0)
            {
                MessageBox.Show("Consulta de Estoque já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmEstoqueConsultar EstoqueConsultar = new FrmEstoqueConsultar
                {
                    MdiParent = this
                };
                EstoqueConsultar.Show();
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Deseja Fechar o Sistema?", "SIG", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
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
                MessageBox.Show("Sobre já está Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmSobre Sobre = new FrmSobre
                {
                    MdiParent = this
                };
                Sobre.Show();

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Restart();
            this.Close();
           
        }

        private void BtnVendaConsulta_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmConsItemVenda>().Count() > 0)
            {
                MessageBox.Show("Consulta de Vendas já esta Aberto!", "SIG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                FrmConsItemVenda VendaConsulta = new FrmConsItemVenda
                {
                    MdiParent = this
                };
                VendaConsulta.Show();

            }
            

        }

        private void BtnConsultaNF_Click(object sender, EventArgs e)
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
    }
}
