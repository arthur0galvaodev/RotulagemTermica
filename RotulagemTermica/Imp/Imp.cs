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

namespace Imp
{
    public partial class Imp : Form
    {

        // declaração de variaveis
        //
        /// 
        /// 
        /// 
        modUsuarioSis modUsuario = new modUsuarioSis();
        comUsuarioSis conUsuario = new comUsuarioSis();
        ///
        modRelatorio modRotulo = new modRelatorio();
        conRotulo conRotulo = new conRotulo();
        ///
        modConteudoRotulo modConteudo = new modConteudoRotulo();
        conConteudoRotulo conConteudo = new conConteudoRotulo();
        ///
        conCliente Cliente = new conCliente();
        ///
        conTabela Tabela = new conTabela();
        modTabela modTabela = new modTabela();
        String ClienteDados;
        String SIF;

        /// 
        /// 
        /// 
        /// 
        /// 
        /// 

        // Funções
        //
        /// 
        /// 
        /// //////////////////////////////////////////////////////////////////

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
            ClienteDados = ClienteDados + "- Inscrição Estadual: " + this.dgCliente.Rows[0].Cells[5].Value.ToString();
            ClienteDados = ClienteDados + "- Endereço: " + this.dgCliente.Rows[0].Cells[12].Value.ToString();
            ClienteDados = ClienteDados + " Nº " + this.dgCliente.Rows[0].Cells[13].Value.ToString();
            ClienteDados = ClienteDados + " Bairro: " + this.dgCliente.Rows[0].Cells[14].Value.ToString();
            ClienteDados = ClienteDados + " CEP: " + this.dgCliente.Rows[0].Cells[16].Value.ToString();
            ClienteDados = ClienteDados + " Cidade: " + this.dgCliente.Rows[0].Cells[18].Value.ToString();
            ClienteDados = ClienteDados + " - Estado:  " + this.dgCliente.Rows[0].Cells[17].Value.ToString();

            SIF = this.dgCliente.Rows[0].Cells[7].Value.ToString();
            //MessageBox.Show(ClienteDados + CID);

        }
        /// <summary>
        /// Função carregamento dados Rotulo
        /// </summary>
        /// 
        public void carregarRotulo(String Busca, int Opcao)
        {
            DataTable dados = new DataTable();
            dados = conRotulo.selecionar(Busca, Opcao);
            dgRotulo.DataSource = dados;
            cbEtiqueta.DataSource = dados;
            cbEtiqueta.DisplayMember = "nome";
            cbEtiqueta.ValueMember = "ID";
            cbPrazoValidade.DataSource = dados;
            cbPrazoValidade.DisplayMember = "prazoValidade";
            cbPrazoValidade.ValueMember = "prazoValidade";

        }
        /// <summary>
        /// Função carregamento dados Conteudo Rotulo
        /// </summary>
        /// 
        public void carregarConteudoRotulo(String Busca, int Opcao)
        {
            DataTable dados = new DataTable();
            dados = conConteudo.selecionar(Busca, Opcao);
            dgConteudoRotulo.DataSource = dados;
            cbFormaFisica.DataSource = dados;
            cbFormaFisica.DisplayMember = "Forma";
            cbFormaFisica.ValueMember = "Forma";
            cbPeso.DataSource = dados;
            cbPeso.DisplayMember = "Peso";
            cbPeso.ValueMember = "Peso";

        }
        /// <summary>
        /// Função carregamento dados tabela do rotulo quando existente
        /// </summary>
        /// 
        public void carregarTabela(String Busca, int Opcao)
        {
            DataTable dados = new DataTable();
            dados = Tabela.selecionar(Busca, Opcao);
            dgTabela.DataSource = dados;

        }

        ///////////////////////////////////////////
        ///
        public void carregarData()
        {
            try
            {
                // Pega data de Hoje
                DateTime data = Convert.ToDateTime(txtDataFabricacao.Text);

                // Data capturada + 5 dias
                DateTime data2 = data.AddDays(Convert.ToDouble(txtPrazovalidade.Text));
                txtDataValidade.Text = Convert.ToString(data2);
            }
            catch
            {

            }
        }
        ///////////////////////////////////////////
        ///
        public void GerarRelatorio()
        {

            ///
            /// Variaveis de controle da geração dos dados do relatorio
            /// 
            Boolean controleTransgenia = false;
            /////////////////////////////////////////////////////
            ///
            ////////////////////////////////////////////////////
            ///
            /// Primeira parte dados do Rotulo
            /// NOME -  CLASSIFICAÇÃO PRODUTO - COMPOSIÇÃO QUALITATIVO - EVENTUAIS SUBISTITUTIVOS
            /// NIVEIS DE GARANTIAS - MODO USAR - INDICAÇÃO DE USO - RESTRICAO E RECOMENDAÇÃO - CONDIÇAO CONSERVAÇÃO
            /// SISTEMA PARA VERIFICAR SE A TRANSGENIA
            /// SISTEMA PARA GERAR TEXTO SE HOUVER TRANGEVIA
            /// VARIAVEL DE CONTROLE SE A OU NAO TRANSGENIA
            int indice = dgRotulo.CurrentRow.Index; //Busca indice do rotulo selecionado
            modRotulo.nome = Convert.ToString(dgRotulo.Rows[indice].Cells[1].Value);
            modRotulo.classificacaoProduto = "CLASSIFICAÇÃO DO PRODUTO: " + Convert.ToString(dgRotulo.Rows[indice].Cells[4].Value);
            modRotulo.composicaoQualitativa = "COMPOSIÇÃO QUALITATIVA: " + Convert.ToString(dgRotulo.Rows[indice].Cells[5].Value);
            modRotulo.eventuaisSubistitutivos = "EVENTUAIS SUBSTITUTIVOS: " + Convert.ToString(dgRotulo.Rows[indice].Cells[6].Value);
            modRotulo.niveisGarantia = "NÍVEIS DE GARANTIA: " + Convert.ToString(dgRotulo.Rows[indice].Cells[7].Value);
            modRotulo.modoUsar = "MODO DE USAR: " + Convert.ToString(dgRotulo.Rows[indice].Cells[8].Value);
            modRotulo.indicacaoUso = "INDICAÇÃO DE USO: " + Convert.ToString(dgRotulo.Rows[indice].Cells[9].Value);
            modRotulo.restricoesRecomendacoes = "RESTRIÇÕES E OUTRAS RECOMENDAÇÕES: " + Convert.ToString(dgRotulo.Rows[indice].Cells[10].Value);
            modRotulo.condicaoConservacao = "CONDIÇÃO DE CONSERVAÇÃO: " + Convert.ToString(dgRotulo.Rows[indice].Cells[11].Value);
            /////////////////////////////////////////////////////
            ///SISTEMA DE VERIFICAÇÃO DE TRANSGENIA
            ////////////////////////////////////////////////////
            String milho = Convert.ToString(dgRotulo.Rows[indice].Cells[12].Value);
            String soja = Convert.ToString(dgRotulo.Rows[indice].Cells[13].Value);
            String Algodao = Convert.ToString(dgRotulo.Rows[indice].Cells[14].Value);
            String Textomilho = "";
            String Textosoja = "";
            String TextoAlgodao = "";
            String TextoTransgenia = "";
            if (milho == "SIM")
            {
                controleTransgenia = true;
                Textomilho = "1 - Agrobacterium tumefaciens, Bacillus thuringiensis, Streptomyces viridochromogenes, Zea mays.";
            }
            if (soja == "SIM")
            {
                controleTransgenia = true;
                Textosoja = " 2 - Agrobacterium tumefaciens, Bacillus thuringiensis,  Streptomyces viridochromogenes,   Arabidopsis thaliana. ";
            }
            if (Algodao == "SIM")
            {
                controleTransgenia = true;
                TextoAlgodao = " 3 - Agrobacterium tumefaciens, Bacillus thuringiensis, Streptomyces hygroscopicus, Streptomyces viridochromogenes, Zea mays.";
            }
            /////////////////////////////////////////////////////
            ///SISTEMA DE GERAR TEXTO TRANSGENIA
            ////////////////////////////////////////////////////
            if (controleTransgenia == true)
            {
                //são 8 opcoes de combinação de textos
                //milho sim, soja sim, algodao sim.
                //milho sim, soja sim, algodao nao.
                //milho sim, soja nao, algodao nao.
                //milho nao, soja nao, algodao nao.
                //milho nao, soja sim, algodao sim.
                //milho nao, soja nao, algodao sim.
                //milho nao, soja sim, algodao nao.
                //milho sim, soja nao, algodao sim.

                //gerar 1 opcao
                if (milho == "SIM")
                {
                    if (soja == "SIM")
                    {
                        if (Algodao == "SIM")
                        {
                            TextoTransgenia = "PRODUTO PRODUZIDO A PARTIR DE MILHO¹, SOJA² e ALGODÃO³ TRANSGÊNICOS(AS):";
                            TextoTransgenia = TextoTransgenia + Textomilho + Textosoja + TextoAlgodao;
                        }
                    }
                }

            }
            //gerar 2 opcao
            if (milho == "SIM")
            {
                if (soja == "SIM")
                {
                    if (Algodao == "NAO")
                    {
                        TextoTransgenia = "PRODUTO PRODUZIDO A PARTIR DE MILHO¹ e SOJA² TRANSGÊNICOS(AS):";
                        TextoTransgenia = TextoTransgenia + Textomilho + Textosoja;
                    }
                }
            }

            //gerar 3 opcao
            if (milho == "SIM")
            {
                if (soja == "NAO")
                {
                    if (Algodao == "NAO")
                    {
                        TextoTransgenia = "PRODUTO PRODUZIDO A PARTIR DE MILHO¹ TRANSGÊNICO(A):";
                        TextoTransgenia = TextoTransgenia + Textomilho;
                    }
                }
            }
            //gerar 4 opcao
            if (milho == "NAO")
            {
                if (soja == "NAO")
                {
                    if (Algodao == "NAO")
                    {
                        TextoTransgenia = "";
                        TextoTransgenia = "";
                    }
                }
            }
            //gerar 5 opcao
            if (milho == "NAO")
            {
                if (soja == "SIM")
                {
                    if (Algodao == "SIM")
                    {
                        TextoTransgenia = "PRODUTO PRODUZIDO A PARTIR DE SOJA² e ALGODÃO³ TRANSGÊNICOS(AS):";
                        TextoTransgenia = TextoTransgenia + Textosoja + TextoAlgodao;
                    }
                }
            }
            //gerar 6 opcao
            if (milho == "NAO")
            {
                if (soja == "NAO")
                {
                    if (Algodao == "SIM")
                    {
                        TextoTransgenia = "PRODUTO PRODUZIDO A PARTIR DE ALGODÃO³ TRANSGÊNICO(A):";
                        TextoTransgenia = TextoTransgenia + TextoAlgodao;
                    }
                }
            }
            //gerar 7 opcao
            if (milho == "NAO")
            {
                if (soja == "SIM")
                {
                    if (Algodao == "NAO")
                    {
                        TextoTransgenia = "PRODUTO PRODUZIDO A PARTIR DE SOJA² TRANSGÊNICOS(AS):";
                        TextoTransgenia = TextoTransgenia + Textosoja;
                    }
                }
            }
            //gerar 8 opcao
            if (milho == "SIM")
            {
                if (soja == "NAO")
                {
                    if (Algodao == "SIM")
                    {
                        TextoTransgenia = "PRODUTO PRODUZIDO A PARTIR DE MILHO¹ e ALGODÃO³ TRANSGÊNICOS(AS):";
                        TextoTransgenia = TextoTransgenia + Textomilho + TextoAlgodao;
                    }
                }
            }


            modRotulo.textoTransgenia = TextoTransgenia;
            /////////////////////////////////////////////////////
            ///
            ////////////////////////////////////////////////////
            ///
            /// Segunda parte parte dados do conteudo rotrulo
            /// PESO - FORMA FISICA
            /// 
            modRotulo.PesoDescricao = cbPeso.SelectedValue.ToString();
            modRotulo.FormaFisicaDescricao = cbFormaFisica.SelectedValue.ToString();


            /////////////////////////////////////////////////////
            ///
            ////////////////////////////////////////////////////
            ///
            /// terceira parte parte dados manuais
            /// DATA FABRICAÇÃO - DATA VALIDADE - LOTE
            /// 
            modRotulo.dataFabricacao = txtDataFabricacao.Text;
            modRotulo.dataValidade = txtDataValidade.Text;
            modRotulo.lote = txtLote.Text;

            /////////////////////////////////////////////////////
            ///
            ////////////////////////////////////////////////////
            ///
            /// quarta parte parte parte fabricante
            /// 
            /// 
            //modRotulo.textoTransgenia = Convert.ToString(dgRotulo.Rows[indice].Cells[12].Value);
            modRotulo.tabela = Convert.ToString(dgRotulo.Rows[indice].Cells[16].Value);
            /// <summary>
            /// Função vericar e carregar os dados da tabele que esta no datagrid para as variaveis do objeto rotulo
            /// </summary>
            /// 
            if (modRotulo.tabela == "SIM")
            {
                int indiceT = dgTabela.CurrentRow.Index;

                modRotulo.A1 = Convert.ToString(dgTabela.Rows[indiceT].Cells[2].Value);
                modRotulo.A2 = Convert.ToString(dgTabela.Rows[indiceT].Cells[3].Value);
                modRotulo.A3 = Convert.ToString(dgTabela.Rows[indiceT].Cells[4].Value);
                modRotulo.A4 = Convert.ToString(dgTabela.Rows[indiceT].Cells[5].Value);
                modRotulo.A5 = Convert.ToString(dgTabela.Rows[indiceT].Cells[6].Value);
                modRotulo.A6 = Convert.ToString(dgTabela.Rows[indiceT].Cells[7].Value);
                modRotulo.A7 = Convert.ToString(dgTabela.Rows[indiceT].Cells[8].Value);
                modRotulo.A8 = Convert.ToString(dgTabela.Rows[indiceT].Cells[9].Value);
                modRotulo.A9 = Convert.ToString(dgTabela.Rows[indiceT].Cells[10].Value);
                modRotulo.A10 = Convert.ToString(dgTabela.Rows[indiceT].Cells[11].Value);
                modRotulo.A11 = Convert.ToString(dgTabela.Rows[indiceT].Cells[12].Value);
                modRotulo.A12 = Convert.ToString(dgTabela.Rows[indiceT].Cells[13].Value);
                modRotulo.A13 = Convert.ToString(dgTabela.Rows[indiceT].Cells[14].Value);
                modRotulo.A14 = Convert.ToString(dgTabela.Rows[indiceT].Cells[15].Value);
                modRotulo.A15 = Convert.ToString(dgTabela.Rows[indiceT].Cells[16].Value);
                modRotulo.A16 = Convert.ToString(dgTabela.Rows[indiceT].Cells[17].Value);
                modRotulo.A17 = Convert.ToString(dgTabela.Rows[indiceT].Cells[18].Value);
                modRotulo.A18 = Convert.ToString(dgTabela.Rows[indiceT].Cells[19].Value);

                modRotulo.B1 = Convert.ToString(dgTabela.Rows[indiceT].Cells[20].Value);
                modRotulo.B2 = Convert.ToString(dgTabela.Rows[indiceT].Cells[21].Value);
                modRotulo.B3 = Convert.ToString(dgTabela.Rows[indiceT].Cells[22].Value);
                modRotulo.B4 = Convert.ToString(dgTabela.Rows[indiceT].Cells[23].Value);
                modRotulo.B5 = Convert.ToString(dgTabela.Rows[indiceT].Cells[24].Value);
                modRotulo.B6 = Convert.ToString(dgTabela.Rows[indiceT].Cells[25].Value);
                modRotulo.B7 = Convert.ToString(dgTabela.Rows[indiceT].Cells[26].Value);
                modRotulo.B8 = Convert.ToString(dgTabela.Rows[indiceT].Cells[27].Value);
                modRotulo.B9 = Convert.ToString(dgTabela.Rows[indiceT].Cells[28].Value);
                modRotulo.B10 = Convert.ToString(dgTabela.Rows[indiceT].Cells[29].Value);
                modRotulo.B11 = Convert.ToString(dgTabela.Rows[indiceT].Cells[30].Value);
                modRotulo.B12 = Convert.ToString(dgTabela.Rows[indiceT].Cells[31].Value);
                modRotulo.B13 = Convert.ToString(dgTabela.Rows[indiceT].Cells[32].Value);
                modRotulo.B14 = Convert.ToString(dgTabela.Rows[indiceT].Cells[33].Value);
                modRotulo.B15 = Convert.ToString(dgTabela.Rows[indiceT].Cells[34].Value);
                modRotulo.B16 = Convert.ToString(dgTabela.Rows[indiceT].Cells[35].Value);
                modRotulo.B17 = Convert.ToString(dgTabela.Rows[indiceT].Cells[36].Value);
                modRotulo.B18 = Convert.ToString(dgTabela.Rows[indiceT].Cells[37].Value);

                modRotulo.C1 = Convert.ToString(dgTabela.Rows[indiceT].Cells[38].Value);
                modRotulo.C2 = Convert.ToString(dgTabela.Rows[indiceT].Cells[39].Value);
                modRotulo.C3 = Convert.ToString(dgTabela.Rows[indiceT].Cells[40].Value);
                modRotulo.C4 = Convert.ToString(dgTabela.Rows[indiceT].Cells[41].Value);
                modRotulo.C5 = Convert.ToString(dgTabela.Rows[indiceT].Cells[42].Value);
                modRotulo.C6 = Convert.ToString(dgTabela.Rows[indiceT].Cells[43].Value);
                modRotulo.C7 = Convert.ToString(dgTabela.Rows[indiceT].Cells[44].Value);
                modRotulo.C8 = Convert.ToString(dgTabela.Rows[indiceT].Cells[45].Value);
                modRotulo.C9 = Convert.ToString(dgTabela.Rows[indiceT].Cells[46].Value);
                modRotulo.C10 = Convert.ToString(dgTabela.Rows[indiceT].Cells[47].Value);
                modRotulo.C11 = Convert.ToString(dgTabela.Rows[indiceT].Cells[48].Value);
                modRotulo.C12 = Convert.ToString(dgTabela.Rows[indiceT].Cells[49].Value);
                modRotulo.C13 = Convert.ToString(dgTabela.Rows[indiceT].Cells[50].Value);
                modRotulo.C14 = Convert.ToString(dgTabela.Rows[indiceT].Cells[51].Value);
                modRotulo.C15 = Convert.ToString(dgTabela.Rows[indiceT].Cells[52].Value);
                modRotulo.C16 = Convert.ToString(dgTabela.Rows[indiceT].Cells[53].Value);
                modRotulo.C17 = Convert.ToString(dgTabela.Rows[indiceT].Cells[54].Value);
                modRotulo.C18 = Convert.ToString(dgTabela.Rows[indiceT].Cells[55].Value);

                modRotulo.D1 = Convert.ToString(dgTabela.Rows[indiceT].Cells[56].Value);
                modRotulo.D2 = Convert.ToString(dgTabela.Rows[indiceT].Cells[57].Value);
                modRotulo.D3 = Convert.ToString(dgTabela.Rows[indiceT].Cells[58].Value);
                modRotulo.D4 = Convert.ToString(dgTabela.Rows[indiceT].Cells[59].Value);
                modRotulo.D5 = Convert.ToString(dgTabela.Rows[indiceT].Cells[60].Value);
                modRotulo.D6 = Convert.ToString(dgTabela.Rows[indiceT].Cells[61].Value);
                modRotulo.D7 = Convert.ToString(dgTabela.Rows[indiceT].Cells[62].Value);
                modRotulo.D8 = Convert.ToString(dgTabela.Rows[indiceT].Cells[63].Value);
                modRotulo.D9 = Convert.ToString(dgTabela.Rows[indiceT].Cells[64].Value);
                modRotulo.D10 = Convert.ToString(dgTabela.Rows[indiceT].Cells[65].Value);
                modRotulo.D11 = Convert.ToString(dgTabela.Rows[indiceT].Cells[66].Value);
                modRotulo.D12 = Convert.ToString(dgTabela.Rows[indiceT].Cells[67].Value);
                modRotulo.D13 = Convert.ToString(dgTabela.Rows[indiceT].Cells[68].Value);
                modRotulo.D14 = Convert.ToString(dgTabela.Rows[indiceT].Cells[69].Value);
                modRotulo.D15 = Convert.ToString(dgTabela.Rows[indiceT].Cells[70].Value);
                modRotulo.D16 = Convert.ToString(dgTabela.Rows[indiceT].Cells[71].Value);
                modRotulo.D17 = Convert.ToString(dgTabela.Rows[indiceT].Cells[72].Value);
                modRotulo.D18 = Convert.ToString(dgTabela.Rows[indiceT].Cells[73].Value);

            }



            /////////////////////////////////////////////////////
            ///
            ////////////////////////////////////////////////////
            ///
            /// quinta parte parte parte fabricante
            /// DADOS DO FABRICANTE
            /// 

            int indiceCL = dgCliente.CurrentRow.Index;
            ClienteDados = "Razão Social: " + this.dgCliente.Rows[indiceCL].Cells[3].Value.ToString();
            ClienteDados = ClienteDados + "- CNPJ: " + this.dgCliente.Rows[indiceCL].Cells[4].Value.ToString();
            ClienteDados = ClienteDados + "- Inscrição Estadual: " + this.dgCliente.Rows[indiceCL].Cells[5].Value.ToString();
            ClienteDados = ClienteDados + "- Endereço: " + this.dgCliente.Rows[indiceCL].Cells[12].Value.ToString();
            ClienteDados = ClienteDados + " Nº " + this.dgCliente.Rows[indiceCL].Cells[13].Value.ToString();
            ClienteDados = ClienteDados + " Bairro: " + this.dgCliente.Rows[indiceCL].Cells[14].Value.ToString();
            ClienteDados = ClienteDados + " CEP: " + this.dgCliente.Rows[indiceCL].Cells[16].Value.ToString();
            ClienteDados = ClienteDados + " Cidade: " + this.dgCliente.Rows[indiceCL].Cells[18].Value.ToString();
            ClienteDados = ClienteDados + " - Estado:  " + this.dgCliente.Rows[indiceCL].Cells[17].Value.ToString();

            SIF = this.dgCliente.Rows[indiceCL].Cells[7].Value.ToString();
            //MessageBox.Show(ClienteDados + CID);



            modRotulo.Sif = SIF;
            modRotulo.Fabricante = ClienteDados;

            /////////////////////////////////////////////////////
            ///
            ////////////////////////////////////////////////////
            ///
            /// Sexta parte escolha do modelo e envio dos dados
            /// 
            ///


            string modelo = Convert.ToString(dgRotulo.Rows[indice].Cells[3].Value);
            if (modelo == "240S")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer240s.Visible = true;
                reportViewer240s.Dock = DockStyle.Fill;
                this.reportViewer240s.RefreshReport();
            }
            else if (modelo == "240S+")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer240ss.Visible = true;
                reportViewer240ss.Dock = DockStyle.Fill;
                this.reportViewer240ss.RefreshReport();
            }
            else if (modelo == "240S++")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer240sss.Visible = true;
                reportViewer240sss.Dock = DockStyle.Fill;
                this.reportViewer240sss.RefreshReport();
            }
/////////////////////////////////////////////////////////////////////////////////////////////////
            else if (modelo == "240C")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer240c.Visible = true;
                reportViewer240c.Dock = DockStyle.Fill;
                this.reportViewer240c.RefreshReport();
            }
            else if (modelo == "240C+")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer240cc.Visible = true;
                reportViewer240cc.Dock = DockStyle.Fill;
                this.reportViewer240cc.RefreshReport();
            }
            else if (modelo == "240C++")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer240ccc.Visible = true;
                reportViewer240ccc.Dock = DockStyle.Fill;
                this.reportViewer240ccc.RefreshReport();
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////
            else if (modelo == "240T")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer240tt.Visible = true;
                reportViewer240tt.Dock = DockStyle.Fill;
                this.reportViewer240tt.RefreshReport();
            }
            else if (modelo == "240T+")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer240tt.Visible = true;
                reportViewer240tt.Dock = DockStyle.Fill;
                this.reportViewer240tt.RefreshReport();
            }
            else if (modelo == "240T++")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer240ttt.Visible = true;
                reportViewer240ttt.Dock = DockStyle.Fill;
                this.reportViewer240ttt.RefreshReport();
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////
            else if (modelo == "240T5")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer240t5.Visible = true;
                reportViewer240t5.Dock = DockStyle.Fill;
                this.reportViewer240t5.RefreshReport();
            }
            else if (modelo == "240T5+")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer240t5t.Visible = true;
                reportViewer240t5t.Dock = DockStyle.Fill;
                this.reportViewer240t5t.RefreshReport();
            }
            else if (modelo == "240T5++")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer240t5tt.Visible = true;
                reportViewer240t5tt.Dock = DockStyle.Fill;
                this.reportViewer240t5tt.RefreshReport();
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////
            else if (modelo == "M40")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer300c.Visible = true;
                reportViewer300c.Dock = DockStyle.Fill;
                this.reportViewer300c.RefreshReport();
            }
            else if (modelo == "M40+")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer300cc.Visible = true;
                reportViewer300cc.Dock = DockStyle.Fill;
                this.reportViewer300cc.RefreshReport();
            }
            else if (modelo == "M40++")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer300ccc.Visible = true;
                reportViewer300ccc.Dock = DockStyle.Fill;
                this.reportViewer300ccc.RefreshReport();
            }
/////////////////////////////////////////////////////////////////////////////////////////////////
            else if (modelo == "MS40")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer300s.Visible = true;
                reportViewer300s.Dock = DockStyle.Fill;
                this.reportViewer300s.RefreshReport();
            }
            else if (modelo == "MS40+")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer300ss.Visible = true;
                reportViewer300ss.Dock = DockStyle.Fill;
                this.reportViewer300ss.RefreshReport();
            }
            else if (modelo == "MS40++")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer300sss.Visible = true;
                reportViewer300sss.Dock = DockStyle.Fill;
                this.reportViewer300sss.RefreshReport();
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////
            else if (modelo == "MS40T")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer300t.Visible = true;
                reportViewer300t.Dock = DockStyle.Fill;
                this.reportViewer300t.RefreshReport();
            }
            else if (modelo == "MS40T+")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer300tt.Visible = true;
                reportViewer300tt.Dock = DockStyle.Fill;
                this.reportViewer300tt.RefreshReport();
            }
            else if (modelo == "MS40T++")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer300ttt.Visible = true;
                reportViewer300ttt.Dock = DockStyle.Fill;
                this.reportViewer300ttt.RefreshReport();
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////
            else if (modelo == "MS40T5")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer300t5.Visible = true;
                reportViewer300t5.Dock = DockStyle.Fill;
                this.reportViewer300t5.RefreshReport();
            }
            else if (modelo == "MS40T5+")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer300t5t.Visible = true;
                reportViewer300t5t.Dock = DockStyle.Fill;
                this.reportViewer300t5t.RefreshReport();
            }
            else if (modelo == "MS40T5++")
            {
                modRelatorioBindingSource.DataSource = modRotulo;
                reportViewer300t5tt.Visible = true;
                reportViewer300t5tt.Dock = DockStyle.Fill;
                this.reportViewer300t5tt.RefreshReport();
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////
            else
            {
            
                MessageBox.Show("Selecine um modelo em ativo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        }
        ///////////////////////////////////////////////////////////////////
        public Imp()
        {
            InitializeComponent();
        }

        private void Imp_Load(object sender, EventArgs e)
        {
            try
            {
                carregarRotulo("", 0);
                txtDataFabricacao.Text = Convert.ToString(DateTime.Today);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.reportViewer240s.RefreshReport();

            this.reportViewer240c.RefreshReport();
            this.reportViewer240cc.RefreshReport();
            this.reportViewer240ccc.RefreshReport();

            this.reportViewer240s.RefreshReport();
            this.reportViewer240ss.RefreshReport();
            this.reportViewer240sss.RefreshReport();

            this.reportViewer240t.RefreshReport();
            this.reportViewer240tt.RefreshReport();
            this.reportViewer240ttt.RefreshReport();

            this.reportViewer240t5.RefreshReport();
            this.reportViewer240t5t.RefreshReport();
            this.reportViewer240t5tt.RefreshReport();

            this.reportViewer300c.RefreshReport();
            this.reportViewer300cc.RefreshReport();
            this.reportViewer300ccc.RefreshReport();

            this.reportViewer300s.RefreshReport();
            this.reportViewer300ss.RefreshReport();
            this.reportViewer300sss.RefreshReport();

            this.reportViewer300t.RefreshReport();
            this.reportViewer300tt.RefreshReport();
            this.reportViewer300ttt.RefreshReport();

            this.reportViewer300t5.RefreshReport();
            this.reportViewer300t5t.RefreshReport();
            this.reportViewer300t5tt.RefreshReport();
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

                ///////////////////////////////////////////////////////////////////////////
                ///
                string datetime = DateTime.Now.ToString("hh:mm:ss tt");

                if (txtSenha.Text == cbSenha.Text)
                {

                    carregarCliente(cbClienteLogado.Text);

                    MessageBox.Show("Seja bem vindo:" + cbUsuario.Text + "!" + "\n" + "\n" + "Unidade: " + ClienteDados + "\n" + "\n" + datetime);
                    panelLogin.Visible = false;
                    panelBuscarEtiqueta.Enabled = true;
                    panelGerarRelatrorio.Enabled = false;

                    lbUnidadeLogin.Text = ClienteDados;
                    lbUsuarioLogado.Text = cbUsuario.Text;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos, favor verificar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção! A exlusão pode prejudicar os Relatorios. Confirma Exlusão?", "Confirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //(ex.Message);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                panelGerarRelatrorio.Visible = true;

                String Busca = Convert.ToString(cbEtiqueta.SelectedValue.ToString());
                carregarConteudoRotulo(Busca, 1);

                txtPrazovalidade.Text = cbPrazoValidade.SelectedValue.ToString();
                carregarData();
                panelGerarRelatrorio.Enabled = true;

                reportViewer240c.Visible = false;
                reportViewer240cc.Visible = false;
                reportViewer240ccc.Visible = false;

                reportViewer240s.Visible = false;
                reportViewer240ss.Visible = false;
                reportViewer240sss.Visible = false;

                reportViewer240t.Visible = false;
                reportViewer240tt.Visible = false;
                reportViewer240ttt.Visible = false;

                reportViewer240t5.Visible = false;
                reportViewer240t5t.Visible = false;
                reportViewer240t5tt.Visible = false;

                reportViewer300c.Visible = false;
                reportViewer300cc.Visible = false;
                reportViewer300ccc.Visible = false;

                reportViewer300s.Visible = false;
                reportViewer300ss.Visible = false;
                reportViewer300sss.Visible = false;

                reportViewer300t.Visible = false;
                reportViewer300tt.Visible = false;
                reportViewer300ttt.Visible = false;

                reportViewer300t5.Visible = false;
                reportViewer300t5t.Visible = false;
                reportViewer300t5tt.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnGerarRotulo_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = dgRotulo.CurrentRow.Index;
                String buscar = Convert.ToString(dgRotulo.Rows[indice].Cells[0].Value);

                carregarTabela(buscar, 1);
                GerarRelatorio();

                panelGerarRelatrorio.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \n" + "Suporte (37)9 9948-8561", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void PanelBuscarEtiqueta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnResomar_Click(object sender, EventArgs e)
        {

        }

        private void ReportViewerM40t5_Load(object sender, EventArgs e)
        {


        }
    }
}
