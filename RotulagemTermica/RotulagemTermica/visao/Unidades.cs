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
    public partial class Unidades : Form
    {
        modCliente modCliente = new modCliente();
        conCliente conCliente = new conCliente();
        int selecao = 0; // 0 cadastrar ou clonar
                         // 1 alterar
                         // 2 excluir
        public void carregar()
        {
            DataTable dados = new DataTable();
            dados = conCliente.selecionar("", 0);
            bindingSource1.DataSource = dados;


            modClienteDataGridView.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

        }
        public Unidades()
        {
            InitializeComponent();
        }

        private void Unidades_Load(object sender, EventArgs e)
        {
            try
            {
                carregar();
                modClienteDataGridView.Dock = DockStyle.Fill;
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
                modClienteDataGridView.Visible = false;
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
                modClienteDataGridView.Visible = false;

                int indice = modClienteDataGridView.CurrentRow.Index;
                iDTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[0].Value);
                tipodeClienteTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[1].Value);
                nomeFantasiaTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[2].Value);
                razaoSocialTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[3].Value);
                cNPJTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[4].Value);
                inscricaoEstadualTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[5].Value);
                atividadeeconomicaTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[6].Value);
                codigoSifTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[7].Value);
                siteTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[8].Value);
                emailTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[9].Value);
                telefone1TextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[10].Value);
                telefone2TextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[11].Value);
                logradouroTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[12].Value);
                numeroTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[13].Value);
                bairroTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[14].Value);
                complementoTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[15].Value);
                cepTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[16].Value);
                estadoTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[17].Value);
                cidadeTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[18].Value);
                nomeDoResponsavelTecnicoTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[19].Value);
                logoTextBox.Text = Convert.ToString(modClienteDataGridView.Rows[indice].Cells[20].Value);
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

                int indice = modClienteDataGridView.CurrentRow.Index;
                modCliente.ID = Convert.ToInt16(modClienteDataGridView.Rows[indice].Cells[0].Value);
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
                modClienteDataGridView.Visible = true;
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

                modCliente.TipodeCliente = tipodeClienteTextBox.Text;
                modCliente.NomeFantasia = nomeFantasiaTextBox.Text;
                modCliente.RazaoSocial = razaoSocialTextBox.Text;
                modCliente.CNPJ = cNPJTextBox.Text;
                modCliente.InscricaoEstadual = inscricaoEstadualTextBox.Text;
                modCliente.Atividadeeconomica = atividadeeconomicaTextBox.Text;
                modCliente.CodigoSif = codigoSifTextBox.Text;
                modCliente.Site = siteTextBox.Text;
                modCliente.Email = emailTextBox.Text;
                modCliente.Telefone1 = telefone1TextBox.Text;
                modCliente.Telefone2 = telefone2TextBox.Text;
                modCliente.Logradouro = logradouroTextBox.Text;
                modCliente.Numero = numeroTextBox.Text;
                modCliente.Bairro = bairroTextBox.Text;
                modCliente.Complemento = complementoTextBox.Text;
                modCliente.Cep = cepTextBox.Text;
                modCliente.Estado = estadoTextBox.Text;
                modCliente.Cidade = cidadeTextBox.Text;
                modCliente.NomeDoResponsavelTecnico = nomeDoResponsavelTecnicoTextBox.Text;
                modCliente.Logo = logoTextBox.Text;

                conCliente.Comando(modCliente, selecao);
                carregar();
                panel1.Visible = false;
                modClienteDataGridView.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
