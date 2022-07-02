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
    public partial class Rotulo : Form
    {
        modRotulo modCliente = new modRotulo();
        conRotulo conCliente = new conRotulo();
        int selecao = 0; // 0 cadastrar ou clonar
                         // 1 alterar
                         // 2 excluir
        public void carregar()
        {
            DataTable dados = new DataTable();
            dados = conCliente.selecionar("", 0);
            bindingSource1.DataSource = dados;

            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

        }
        public Rotulo()
        {
            InitializeComponent();
        }

        private void Rotulo_Load(object sender, EventArgs e)
        {
            try
            {
                carregar();
                dataGridView1.Dock = DockStyle.Fill;
                dataGridView1.Visible = true;
                panel1.Dock = DockStyle.Fill;
                panel1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdcionar_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = true;
                dataGridView1.Visible = false;
                selecao = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                selecao = 1;
                panel1.Visible = true;
                dataGridView1.Visible = false;

                int indice = dataGridView1.CurrentRow.Index;
                iDTextBox.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[0].Value);
                txtNome.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[1].Value);
                txtPrazoValidade.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[2].Value);
                txtModelo.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[3].Value);
                txtClassificacaoProduto.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[4].Value);
                txtComposicaoQualitativa.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[5].Value);
                txtEventuaisSubstitutivos.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[6].Value);
                txtNiveisGarantia.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[7].Value);
                txtModoGarantia.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[8].Value);
                txtindicacaoUso.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[9].Value);
                txtRestricaoRecomendacoes.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[10].Value);
                txtCondicoesConservacao.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[11].Value);

                String Milho = Convert.ToString(dataGridView1.Rows[indice].Cells[12].Value);
                if (Milho == "SIM")
                {
                    txtMilho.Checked = true;
                }
                else
                {
                    txtMilho.Checked = false;
                }

                String Soja = Convert.ToString(dataGridView1.Rows[indice].Cells[13].Value);
                if (Soja == "SIM")
                {
                    txtSoja.Checked = true;
                }
                else
                {
                    txtSoja.Checked = false;
                }

                String Algodao = Convert.ToString(dataGridView1.Rows[indice].Cells[14].Value);
                if (Algodao == "SIM")
                {
                    txtAlgodao.Checked = true;
                }
                else
                {
                    txtAlgodao.Checked = false;
                }

                txtTextoMinisterio.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[15].Value);

                String Tabela = Convert.ToString(dataGridView1.Rows[indice].Cells[16].Value);
                if (Tabela == "SIM")
                {
                    txtTabela.Checked = true;
                }
                else
                {
                    txtTabela.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClonar_Click(object sender, EventArgs e)
        {
            try
            {
                selecao = 0;
                panel1.Visible = true;
                dataGridView1.Visible = false;

                int indice = dataGridView1.CurrentRow.Index;
                iDTextBox.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[0].Value);
                txtNome.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[1].Value);
                txtPrazoValidade.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[2].Value);
                txtModelo.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[3].Value);
                txtClassificacaoProduto.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[4].Value);
                txtComposicaoQualitativa.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[5].Value);
                txtEventuaisSubstitutivos.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[6].Value);
                txtNiveisGarantia.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[7].Value);
                txtModoGarantia.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[8].Value);
                txtindicacaoUso.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[9].Value);
                txtRestricaoRecomendacoes.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[10].Value);
                txtCondicoesConservacao.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[11].Value);

                String Milho = Convert.ToString(dataGridView1.Rows[indice].Cells[12].Value);
                if (Milho == "SIM")
                {
                    txtMilho.Checked = true;
                }
                else
                {
                    txtMilho.Checked = false;
                }

                String Soja = Convert.ToString(dataGridView1.Rows[indice].Cells[13].Value);
                if (Soja == "SIM")
                {
                    txtSoja.Checked = true;
                }
                else
                {
                    txtSoja.Checked = false;
                }

                String Algodao = Convert.ToString(dataGridView1.Rows[indice].Cells[14].Value);
                if (Algodao == "SIM")
                {
                    txtAlgodao.Checked = true;
                }
                else
                {
                    txtAlgodao.Checked = false;
                }

                txtTextoMinisterio.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[15].Value);

                String Tabela = Convert.ToString(dataGridView1.Rows[indice].Cells[16].Value);
                if (Tabela == "SIM")
                {
                    txtTabela.Checked = true;
                }
                else
                {
                    txtTabela.Checked = false;
                }
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
                selecao = 2;
                int indice = dataGridView1.CurrentRow.Index;
                //indice = indice - 1;

                iDTextBox.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[0].Value);
                modCliente.ID = Convert.ToInt16(dataGridView1.Rows[indice].Cells[0].Value);
                conCliente.Comando(modCliente, selecao);
                carregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false;
                dataGridView1.Visible = true;
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
                if (iDTextBox.Text == "")
                {
                    modCliente.ID = 0;
                }
                else
                {
                    modCliente.ID = Convert.ToInt16(iDTextBox.Text);
                }


                modCliente.nome = txtNome.Text;
                modCliente.prazoValidade = txtPrazoValidade.Text;
                modCliente.modeloID = txtModelo.Text;
                modCliente.classificacaoProduto = txtClassificacaoProduto.Text;
                modCliente.composicaoQualitativa = txtComposicaoQualitativa.Text;
                modCliente.eventuaisSubistitutivos = txtEventuaisSubstitutivos.Text;
                modCliente.niveisGarantia = txtNiveisGarantia.Text;
                modCliente.modoUsar = txtModoGarantia.Text;
                modCliente.indicacaoUso = txtindicacaoUso.Text;
                modCliente.restricoesRecomendacoes = txtRestricaoRecomendacoes.Text;
                modCliente.condicaoConservacao = txtCondicoesConservacao.Text;
                if (txtMilho.Checked == true)
                {
                    modCliente.trangenicaMilho = "SIM";
                }
                else
                {
                    modCliente.trangenicaMilho = "NAO";
                }

                if (txtSoja.Checked == true)
                {
                    modCliente.trangenicaSoja = "SIM";
                }
                else
                {
                    modCliente.trangenicaSoja = "NAO";
                }

                if (txtAlgodao.Checked == true)
                {
                    modCliente.trangenicaAlgodão = "SIM";
                }
                else
                {
                    modCliente.trangenicaAlgodão = "NAO";
                }

                modCliente.textoMinisterio = txtTextoMinisterio.Text;


                if (txtTabela.Checked == true)
                {
                    modCliente.tabela = "SIM";
                }
                else
                {
                    modCliente.tabela = "NAO";
                }

                conCliente.Comando(modCliente, selecao);


                carregar();
                panel1.Visible = false;
                dataGridView1.Visible = true;

                ConteudoRotuloV ir = new ConteudoRotuloV();
                ir.Show();

                if (txtTabela.Checked == true)
                {
                    Tabela irs = new Tabela();
                    irs.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
