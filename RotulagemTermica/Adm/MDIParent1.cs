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
using RotulagemTermica.visao;
using Imp;
namespace Adm
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        
        ///
        String ClienteDados;
        String SIF;
        conCliente Cliente = new conCliente();
        modUsuarioSis modUsuario = new modUsuarioSis();
        comUsuarioSis conUsuario = new comUsuarioSis();
        public MDIParent1()
        {
            InitializeComponent();
        }
        public void carregarCliente(String idCliente)
        {
            DataTable dados = new DataTable();
            // Matriz //     
            dados = Cliente.selecionar(idCliente);
            // terra //      dados = Cliente.selecionar("4");
            // pantanal //   dados = Cliente.selecionar("2");
            dgCliente.DataSource = dados;
            ClienteDados = "Razão Social: " + this.dgCliente.Rows[0].Cells[3].Value.ToString();
            ClienteDados = ClienteDados + "- CNPJ: " + this.dgCliente.Rows[0].Cells[4].Value.ToString();

            SIF = this.dgCliente.Rows[0].Cells[7].Value.ToString();

        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dados = new DataTable();
                dados = conUsuario.selecionar(txtUsuario.Text, 2);
                bindingSource1.DataSource = dados;

                cbUsuario.DataSource = bindingSource1;
                cbUsuario.DisplayMember = "nome";
                cbUsuario.ValueMember = "nome";

                cbSenha.DataSource = bindingSource1;
                cbSenha.DisplayMember = "senha";
                cbSenha.ValueMember = "senha";

                cbClienteLogado.DataSource = bindingSource1;
                cbClienteLogado.DisplayMember = "idCliente";
                cbClienteLogado.ValueMember = "idCliente";

                cbNivelUser.DataSource = bindingSource1;
                cbNivelUser.DisplayMember = "nivel";
                cbNivelUser.ValueMember = "nivel";

                ///////////////////////////////////////////////////////////////////////////
                ///
                string datetime = DateTime.Now.ToString("hh:mm:ss tt");

                if (txtSenha.Text == cbSenha.Text)
                {
                    if (cbNivelUser.Text == "Administrativo")
                    {
                        carregarCliente(cbClienteLogado.Text);

                        MessageBox.Show("Seja bem vindo: " + cbUsuario.Text + "!" + "\n" + "\n" + "Unidade: " + ClienteDados + "\n" + "\n" + "Hora do login: " + datetime, "Solicitação de Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        panelLogin.Visible = false;
                        menuStrip.Enabled = true;

                        lbUnidadeLogin.Text = ClienteDados;
                        lbUsuarioLogado.Text = cbUsuario.Text;
                    }
                    else
                    {
                        MessageBox.Show("Atenção: Verificar nível de acesso!", "Solicitação de Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos, favor verificar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message  + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void UnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unidades ir = new Unidades();
            ir.MdiParent = this;
            ir.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void UsuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarios ir = new usuarios();
            ir.MdiParent = this;
            ir.Show();
        }

        private void ConteúdoDaEtiquetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConteudoRotuloV ir = new ConteudoRotuloV();
            ir.MdiParent = this;
            ir.Show();
        }

        private void TabelaEtiquetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabela ir = new Tabela();
            ir.MdiParent = this;
            ir.Show();
        }

        private void RoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotulagemTermica.visao.Rotulo ir = new RotulagemTermica.visao.Rotulo();
            ir.MdiParent = this;
            ir.Show();
        }

        private void ToolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            Imp.Imp ir = new Imp.Imp();
            ir.Show();
        }

        private void CadastrosEtiquestasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
