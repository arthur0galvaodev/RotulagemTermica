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
    public partial class usuarios : Form
    {
        modUsuarioSis modUsuario = new modUsuarioSis();
        comUsuarioSis conUsuario = new comUsuarioSis();
        conCliente conCliente = new conCliente();
        modCliente modCliente = new modCliente();

        int selecao = 0; // 0 cadastrar ou clonar
                         // 1 alterar
                         // 2 excluir
        public void carregar()
        {
            DataTable dados = new DataTable();
            dados = conUsuario.selecionar("", 0);

            dataGridView1.DataSource = dados;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }
        public void carregarCliente()
        {
            DataTable dados = new DataTable();
            dados = conCliente.selecionar("", 0);
            bindingSource1.DataSource = dados;

            cbxCliente.DataSource = bindingSource1;
            cbxCliente.DisplayMember = "NomeFantasia";
            cbxCliente.ValueMember = "ID";

        }
        public usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                carregar();
                carregarCliente();

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
                selecao = 0;
                modUsuario.nome = txtNome.Text;
                modUsuario.email = txtEmail.Text;
                modUsuario.senha = txtSenha.Text;
                modUsuario.nivel = cbxNivel.Text;
                modUsuario.idCliente = Convert.ToInt16(cbxCliente.SelectedValue);
                conUsuario.Comando(modUsuario, selecao);
                carregar();
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
                modUsuario.id = Convert.ToInt16(dataGridView1.Rows[indice].Cells[0].Value);
                conUsuario.Comando(modUsuario, selecao);
                carregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
