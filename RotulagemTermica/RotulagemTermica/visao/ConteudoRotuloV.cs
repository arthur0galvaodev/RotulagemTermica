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
    public partial class ConteudoRotuloV : Form
    {
        modConteudoRotulo modCliente = new modConteudoRotulo();
        conConteudoRotulo conCliente = new conConteudoRotulo();

        modRotulo modRotulo = new modRotulo();
        conRotulo conRotulo = new conRotulo();

        modPeso modPeso = new modPeso();
        conPeso conPeso = new conPeso();

        modFormaFisica modFormaFisica = new modFormaFisica();
        conFormaFisica conFormaFisica = new conFormaFisica();
        int selecao = 0; // 0 cadastrar ou clonar
                         // 1 alterar
                         // 2 excluir
        public void carregar()
        {
            DataTable dados = new DataTable();
            dados = conCliente.selecionar("", 0);
            bindingSource1.DataSource = dados;

            dataGridView1.DataSource = bindingSource1;


        }
        public void carregarRotulo()
        {
            DataTable dados = new DataTable();
            dados = conRotulo.selecionar("", 0);

            cbRotulo.DataSource = dados;
            cbRotulo.DisplayMember = "nome";
            cbRotulo.ValueMember = "ID";

        }
        public void carregarPeso()
        {
            DataTable dados = new DataTable();
            dados = conPeso.selecionar("", 0);

            cbPeso.DataSource = dados;
            cbPeso.DisplayMember = "Descricao";
            cbPeso.ValueMember = "ID";


        }
        public void carregarFormaFisicao()
        {
            DataTable dados = new DataTable();
            dados = conFormaFisica.selecionar("", 0);

            cbFormaFisica.DataSource = dados;
            cbFormaFisica.DisplayMember = "Nome";
            cbFormaFisica.ValueMember = "ID";


        }
        public ConteudoRotuloV()
        {
            InitializeComponent();
        }

        private void ConteudoRotuloV_Load(object sender, EventArgs e)
        {
            try
            {
                carregar();
                carregarRotulo();
                carregarPeso();
                carregarFormaFisicao();
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
                modCliente.ID = Convert.ToInt16(dataGridView1.Rows[indice].Cells[0].Value);
                conCliente.Comando(modCliente, selecao);
                carregar();
                carregarRotulo();
                carregarPeso();
                carregarFormaFisicao();
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
                selecao = 0;
                modCliente.RotuloID = Convert.ToInt16(cbRotulo.SelectedValue.ToString());
                modCliente.PesoID = Convert.ToInt16(cbPeso.SelectedValue.ToString());
                modCliente.FormaFisicaID = Convert.ToInt16(cbFormaFisica.SelectedValue.ToString());
                conCliente.Comando(modCliente, selecao);
                carregar();
                carregarRotulo();
                carregarPeso();
                carregarFormaFisicao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
