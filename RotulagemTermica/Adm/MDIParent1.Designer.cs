namespace Adm
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosEtiquestasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conteúdoDaEtiquetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaEtiquetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.lbUnidadeLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.lbUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbNivelUser = new System.Windows.Forms.ComboBox();
            this.cbClienteLogado = new System.Windows.Forms.ComboBox();
            this.cbSenha = new System.Windows.Forms.ComboBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Enabled = false;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrosEtiquestasToolStripMenuItem,
            this.roToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 38);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.modelosToolStripMenuItem});
            this.arquivoToolStripMenuItem.Image = global::Adm.Properties.Resources.janelas;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(120, 34);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unidadesToolStripMenuItem,
            this.usuToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Image = global::Adm.Properties.Resources.novo_arquivo;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.cadastrosToolStripMenuItem.Text = "Registros";
            // 
            // unidadesToolStripMenuItem
            // 
            this.unidadesToolStripMenuItem.Name = "unidadesToolStripMenuItem";
            this.unidadesToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.unidadesToolStripMenuItem.Text = "Unidades";
            this.unidadesToolStripMenuItem.Click += new System.EventHandler(this.UnidadesToolStripMenuItem_Click);
            // 
            // usuToolStripMenuItem
            // 
            this.usuToolStripMenuItem.Name = "usuToolStripMenuItem";
            this.usuToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.usuToolStripMenuItem.Text = "Usuários";
            this.usuToolStripMenuItem.Click += new System.EventHandler(this.UsuToolStripMenuItem_Click);
            // 
            // modelosToolStripMenuItem
            // 
            this.modelosToolStripMenuItem.Enabled = false;
            this.modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.modelosToolStripMenuItem.Text = "Modelos";
            // 
            // cadastrosEtiquestasToolStripMenuItem
            // 
            this.cadastrosEtiquestasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conteúdoDaEtiquetaToolStripMenuItem,
            this.tabelaEtiquetaToolStripMenuItem});
            this.cadastrosEtiquestasToolStripMenuItem.Image = global::Adm.Properties.Resources.marcado;
            this.cadastrosEtiquestasToolStripMenuItem.Name = "cadastrosEtiquestasToolStripMenuItem";
            this.cadastrosEtiquestasToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.cadastrosEtiquestasToolStripMenuItem.Text = "Cadastros Etiquetas";
            this.cadastrosEtiquestasToolStripMenuItem.Click += new System.EventHandler(this.CadastrosEtiquestasToolStripMenuItem_Click);
            // 
            // conteúdoDaEtiquetaToolStripMenuItem
            // 
            this.conteúdoDaEtiquetaToolStripMenuItem.Image = global::Adm.Properties.Resources.marcado;
            this.conteúdoDaEtiquetaToolStripMenuItem.Name = "conteúdoDaEtiquetaToolStripMenuItem";
            this.conteúdoDaEtiquetaToolStripMenuItem.Size = new System.Drawing.Size(283, 36);
            this.conteúdoDaEtiquetaToolStripMenuItem.Text = "Conteúdo da Etiqueta";
            this.conteúdoDaEtiquetaToolStripMenuItem.Click += new System.EventHandler(this.ConteúdoDaEtiquetaToolStripMenuItem_Click);
            // 
            // tabelaEtiquetaToolStripMenuItem
            // 
            this.tabelaEtiquetaToolStripMenuItem.Image = global::Adm.Properties.Resources.marcado;
            this.tabelaEtiquetaToolStripMenuItem.Name = "tabelaEtiquetaToolStripMenuItem";
            this.tabelaEtiquetaToolStripMenuItem.Size = new System.Drawing.Size(283, 36);
            this.tabelaEtiquetaToolStripMenuItem.Text = "Tabela Etiqueta";
            this.tabelaEtiquetaToolStripMenuItem.Click += new System.EventHandler(this.TabelaEtiquetaToolStripMenuItem_Click);
            // 
            // roToolStripMenuItem
            // 
            this.roToolStripMenuItem.Image = global::Adm.Properties.Resources.etiqueta;
            this.roToolStripMenuItem.Name = "roToolStripMenuItem";
            this.roToolStripMenuItem.Size = new System.Drawing.Size(131, 34);
            this.roToolStripMenuItem.Text = "Etiquetas";
            this.roToolStripMenuItem.Click += new System.EventHandler(this.RoToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.lbUnidadeLogin,
            this.toolStripDropDownButton1,
            this.lbUsuarioLogado,
            this.toolStripSplitButton1});
            this.statusStrip.Location = new System.Drawing.Point(0, 517);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 41);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.Image = global::Adm.Properties.Resources.uni11;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(49, 39);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // lbUnidadeLogin
            // 
            this.lbUnidadeLogin.Name = "lbUnidadeLogin";
            this.lbUnidadeLogin.Size = new System.Drawing.Size(27, 36);
            this.lbUnidadeLogin.Text = "---";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = global::Adm.Properties.Resources.use11;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 39);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // lbUsuarioLogado
            // 
            this.lbUsuarioLogado.Name = "lbUsuarioLogado";
            this.lbUsuarioLogado.Size = new System.Drawing.Size(27, 36);
            this.lbUsuarioLogado.Text = "---";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = global::Adm.Properties.Resources.imp;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(54, 39);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.ToolStripSplitButton1_ButtonClick);
            // 
            // panelLogin
            // 
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogin.Controls.Add(this.panel4);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtSenha);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogin.Location = new System.Drawing.Point(0, 38);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(843, 153);
            this.panelLogin.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbNivelUser);
            this.panel4.Controls.Add(this.cbClienteLogado);
            this.panel4.Controls.Add(this.cbSenha);
            this.panel4.Controls.Add(this.cbUsuario);
            this.panel4.Location = new System.Drawing.Point(4, 145);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 39);
            this.panel4.TabIndex = 5;
            // 
            // cbNivelUser
            // 
            this.cbNivelUser.FormattingEnabled = true;
            this.cbNivelUser.Location = new System.Drawing.Point(122, 11);
            this.cbNivelUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNivelUser.Name = "cbNivelUser";
            this.cbNivelUser.Size = new System.Drawing.Size(35, 24);
            this.cbNivelUser.TabIndex = 3;
            // 
            // cbClienteLogado
            // 
            this.cbClienteLogado.FormattingEnabled = true;
            this.cbClienteLogado.Location = new System.Drawing.Point(81, 11);
            this.cbClienteLogado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbClienteLogado.Name = "cbClienteLogado";
            this.cbClienteLogado.Size = new System.Drawing.Size(35, 24);
            this.cbClienteLogado.TabIndex = 2;
            // 
            // cbSenha
            // 
            this.cbSenha.FormattingEnabled = true;
            this.cbSenha.Location = new System.Drawing.Point(41, 11);
            this.cbSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSenha.Name = "cbSenha";
            this.cbSenha.Size = new System.Drawing.Size(35, 24);
            this.cbSenha.TabIndex = 1;
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(4, 11);
            this.cbUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(31, 24);
            this.cbUsuario.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(176, 119);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(5, 79);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(245, 22);
            this.txtSenha.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(5, 30);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(245, 22);
            this.txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // dgCliente
            // 
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Location = new System.Drawing.Point(5, 207);
            this.dgCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.RowHeadersWidth = 51;
            this.dgCliente.Size = new System.Drawing.Size(169, 172);
            this.dgCliente.TabIndex = 42;
            this.dgCliente.Visible = false;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.dgCliente);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIParent1";
            this.Text = "Sistema ADM - Etiquetas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosEtiquestasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conteúdoDaEtiquetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaEtiquetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roToolStripMenuItem;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbClienteLogado;
        private System.Windows.Forms.ComboBox cbSenha;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripStatusLabel lbUnidadeLogin;
        private System.Windows.Forms.ToolStripStatusLabel lbUsuarioLogado;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ComboBox cbNivelUser;
    }
}



