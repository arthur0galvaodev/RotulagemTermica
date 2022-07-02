using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using RotulagemTermica.mod;
using RotulagemTermica.conect;
using System.Data;

namespace RotulagemTermica.com
{
    public class conRotulo
    {
        conexao conect = new conexao();

        public DataTable selecionar(String Busca)
        {
            try
            {
                String sql = "SELECT * FROM ROTULOS WHERE ID  = " + Busca + "; ";
                MySqlConnection con;
                con = new MySqlConnection(conect.ConexaowebOulHost());
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable selecionar(String Busca, int opcao)
        {
            try
            {
                String[] sql = new String[5];
                sql[0] = "SELECT * FROM ROTULOS ORDER BY nome; ";
                sql[1] = "SELECT * FROM ROTULOS WHERE ID  = " + Busca + "; ";
                sql[2] = "SELECT * FROM ROTULOS WHERE tabela  = '" + Busca + "'; ";

                MySqlConnection con;
                con = new MySqlConnection(conect.ConexaowebOulHost());
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql[opcao], con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Comando(modRotulo mod, int opcao)
        {

            int ID = mod.ID;
            String nome = mod.nome;
            String prazoValidade = mod.prazoValidade;
            String modeloID = mod.modeloID;
            String classificacaoProduto = mod.classificacaoProduto;
            String composicaoQualitativa = mod.composicaoQualitativa;
            String eventuaisSubistitutivos = mod.eventuaisSubistitutivos;
            String niveisGarantia = mod.niveisGarantia;
            String modoUsar = mod.modoUsar;
            String indicacaoUso = mod.indicacaoUso;
            String restricoesRecomendacoes = mod.restricoesRecomendacoes;
            String condicaoConservacao = mod.condicaoConservacao;
            String trangenicaMilho = mod.trangenicaMilho;
            String trangenicaSoja = mod.trangenicaSoja;
            String trangenicaAlgodão = mod.trangenicaAlgodão;
            String textoMinisterio = mod.textoMinisterio;
            String tabela = mod.tabela;



            try
            {
                String[] sql = new String[5];
                sql[0] = @"INSERT INTO ROTULOS(nome , prazoValidade,modeloID,classificacaoProduto,composicaoQualitativa,eventuaisSubistitutivos, niveisGarantia,modoUsar,indicacaoUso , restricoesRecomendacoes, condicaoConservacao ,trangenicaMilho,trangenicaSoja,trangenicaAlgodão,textoMinisterio ,tabela )VALUES('" + nome + "', '" + prazoValidade + "', '" + modeloID + "', '" + classificacaoProduto + "', '" + composicaoQualitativa + "', '" + eventuaisSubistitutivos + "', '" + niveisGarantia + "', '" + modoUsar + "', '" + indicacaoUso + "', '" + restricoesRecomendacoes + "', '" + condicaoConservacao + "', '" + trangenicaMilho + "', '" + trangenicaSoja + "', '" + trangenicaAlgodão + "', '" + textoMinisterio + "', '" + tabela + "'); ";
                sql[1] = @"UPDATE ROTULOS SET nome = '" + nome + "', prazoValidade = '" + prazoValidade + "', modeloID = '" + modeloID + "', classificacaoProduto = '" + classificacaoProduto + "', composicaoQualitativa = '" + composicaoQualitativa + "', eventuaisSubistitutivos = '" + eventuaisSubistitutivos + "', niveisGarantia = '" + niveisGarantia + "', modoUsar = '" + modoUsar + "', indicacaoUso = '" + indicacaoUso + "', restricoesRecomendacoes = '" + restricoesRecomendacoes + "', condicaoConservacao = '" + condicaoConservacao + "', trangenicaMilho = '" + trangenicaMilho + "', trangenicaSoja = '" + trangenicaSoja + "', trangenicaAlgodão = '" + trangenicaAlgodão + "', textoMinisterio = '" + textoMinisterio + "', tabela = '" + tabela + "' WHERE ID = '" + ID + "'; ";
                sql[2] = @"DELETE FROM ROTULOS WHERE ID = '" + ID + "'; ";

                String sqlComando = sql[opcao];
                MySqlConnection con;
                con = new MySqlConnection(conect.ConexaowebOulHost());
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sqlComando, con);
                cmd.ExecuteNonQuery();

                con.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
