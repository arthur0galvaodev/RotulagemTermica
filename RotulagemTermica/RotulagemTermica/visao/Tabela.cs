using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RotulagemTermica.com;
using RotulagemTermica.mod;

namespace RotulagemTermica.visao
{
    public partial class Tabela : Form
    {
        modRotulo modCliente = new modRotulo();
        conRotulo conCliente = new conRotulo();

        modTabela modtabela = new modTabela();
        conTabela contabela = new conTabela();
        int selecao;     // 0 cadastrar ou clonar
                         // 1 alterar
                         // 2 excluir
        public void carregar()
        {
            DataTable dados = new DataTable();
            dados = conCliente.selecionar("SIM", 2);

            dataGridView1.DataSource = dados;
            comboBoxRotulo.DataSource = dados;
            comboBoxRotulo.DisplayMember = "nome";
            comboBoxRotulo.ValueMember = "ID";

        }

        public void carregarTabela()
        {
            DataTable dados = new DataTable();
            dados = contabela.selecionar("SIM", 0);

            dataGridView2.DataSource = dados;
            //this.dataGridView2.Columns["CustomerID"].Visible = false;

        }
        public Tabela()
        {
            InitializeComponent();
        }

        private void Tabela_Load(object sender, EventArgs e)
        {
            try
            {
                carregar();
                carregarTabela();
                dataGridView2.Dock = DockStyle.Fill;
                richTextBox1.Dock = DockStyle.Fill;
                richTextBox1.Visible = false;
                panel2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Visible = false;
                richTextBox1.Visible = true;
                panel2.Enabled = true;

                int indice = dataGridView1.CurrentRow.Index;
                richTextBox1.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[7].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = dataGridView2.CurrentRow.Index;
                modtabela.ID = Convert.ToInt16(dataGridView2.Rows[indice].Cells[0].Value);
                contabela.Comando(modtabela, 2);

                carregar();
                carregarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                modtabela.ID_Rotulo = Convert.ToInt16(comboBoxRotulo.SelectedValue.ToString());
                modtabela.A1 = a1.Text;
                modtabela.A2 = a2.Text;
                modtabela.A3 = a3.Text;
                modtabela.A4 = a4.Text;
                modtabela.A5 = a5.Text;
                modtabela.A6 = a6.Text;
                modtabela.A7 = a7.Text;
                modtabela.A8 = a8.Text;
                modtabela.A9 = a9.Text;
                modtabela.A10 = a10.Text;
                modtabela.A11 = a11.Text;
                modtabela.A12 = a12.Text;
                modtabela.A13 = a13.Text;
                modtabela.A14 = a14.Text;
                modtabela.A15 = a15.Text;
                modtabela.A16 = a16.Text;
                modtabela.A17 = a17.Text;
                modtabela.A18 = a18.Text;

                modtabela.B1 = b1.Text;
                modtabela.B2 = b2.Text;
                modtabela.B3 = b3.Text;
                modtabela.B4 = b4.Text;
                modtabela.B5 = b5.Text;
                modtabela.B6 = b6.Text;
                modtabela.B7 = b7.Text;
                modtabela.B8 = b8.Text;
                modtabela.B9 = b9.Text;
                modtabela.B10 = b10.Text;
                modtabela.B11 = b11.Text;
                modtabela.B12 = b12.Text;
                modtabela.B13 = b13.Text;
                modtabela.B14 = b14.Text;
                modtabela.B15 = b15.Text;
                modtabela.B16 = b16.Text;
                modtabela.B17 = b17.Text;
                modtabela.B18 = b18.Text;

                modtabela.C1 = c1.Text;
                modtabela.C2 = c2.Text;
                modtabela.B3 = c3.Text;
                modtabela.C4 = c4.Text;
                modtabela.C5 = c5.Text;
                modtabela.C6 = c6.Text;
                modtabela.C7 = c7.Text;
                modtabela.C8 = c8.Text;
                modtabela.C9 = c9.Text;
                modtabela.C10 = c10.Text;
                modtabela.C11 = c11.Text;
                modtabela.C12 = c12.Text;
                modtabela.C13 = c13.Text;
                modtabela.C14 = c14.Text;
                modtabela.C15 = c15.Text;
                modtabela.C16 = c16.Text;
                modtabela.C17 = c17.Text;
                modtabela.C18 = c18.Text;

                modtabela.D1 = d1.Text;
                modtabela.D2 = d2.Text;
                modtabela.D3 = d3.Text;
                modtabela.D4 = d4.Text;
                modtabela.D5 = d5.Text;
                modtabela.D6 = d6.Text;
                modtabela.D7 = d7.Text;
                modtabela.D8 = d8.Text;
                modtabela.D9 = d9.Text;
                modtabela.D10 = d10.Text;
                modtabela.D11 = d11.Text;
                modtabela.D12 = d12.Text;
                modtabela.D13 = d13.Text;
                modtabela.D14 = d14.Text;
                modtabela.D15 = d15.Text;
                modtabela.D16 = d16.Text;
                modtabela.D17 = d17.Text;
                modtabela.D18 = d18.Text;

                contabela.Comando(modtabela, 0);


                carregar();
                carregarTabela();
                dataGridView2.Dock = DockStyle.Fill;
                dataGridView2.Visible = true;
                richTextBox1.Dock = DockStyle.Fill;
                richTextBox1.Visible = false;
                panel2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l1.Text);
                    decimal valor02 = Convert.ToDecimal(a1.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b1.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void A2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l2.Text);
                    decimal valor02 = Convert.ToDecimal(a2.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b2.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l3.Text);
                    decimal valor02 = Convert.ToDecimal(a3.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b3.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A4_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l4.Text);
                    decimal valor02 = Convert.ToDecimal(a4.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b4.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A5_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l5.Text);
                    decimal valor02 = Convert.ToDecimal(a5.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b5.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A6_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l6.Text);
                    decimal valor02 = Convert.ToDecimal(a6.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b6.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A7_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l7.Text);
                    decimal valor02 = Convert.ToDecimal(a7.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b7.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A8_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l8.Text);
                    decimal valor02 = Convert.ToDecimal(a8.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b8.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A9_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l9.Text);
                    decimal valor02 = Convert.ToDecimal(a9.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b9.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A10_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l10.Text);
                    decimal valor02 = Convert.ToDecimal(a10.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b10.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A11_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l11.Text);
                    decimal valor02 = Convert.ToDecimal(a11.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b11.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A12_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l12.Text);
                    decimal valor02 = Convert.ToDecimal(a12.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b12.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A13_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l13.Text);
                    decimal valor02 = Convert.ToDecimal(a13.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b13.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A14_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l14.Text);
                    decimal valor02 = Convert.ToDecimal(a14.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b14.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A15_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l15.Text);
                    decimal valor02 = Convert.ToDecimal(a15.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b15.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A16_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l16.Text);
                    decimal valor02 = Convert.ToDecimal(a16.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b16.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A17_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l17.Text);
                    decimal valor02 = Convert.ToDecimal(a17.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b17.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A18_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Tab)
                {
                    decimal valor01 = Convert.ToDecimal(l18.Text);
                    decimal valor02 = Convert.ToDecimal(a18.Text);
                    decimal valorResultado;

                    valorResultado = (valor02 * 100) / valor01;
                    b18.Text = Convert.ToString(valorResultado.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
