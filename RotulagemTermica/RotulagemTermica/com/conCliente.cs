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
    public class conCliente
    {
        conexao conect = new conexao();
        public DataTable selecionar(String Busca)
        {
            try
            {
                String sql = "SELECT * FROM Cliente WHERE ID  = " + Busca + "; ";
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
                sql[0] = "SELECT * FROM Cliente; ";
                sql[1] = "SELECT * FROM Cliente WHERE ID  = " + Busca + "; ";

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

        public void Comando(modCliente mod, int opcao)
        {
            int ID = mod.ID;
            String TipodeCliente = mod.TipodeCliente;
            String NomeFantasia = mod.NomeFantasia;
            String RazaoSocial = mod.RazaoSocial;
            String CNPJ = mod.CNPJ;
            String InscricaoEstadual = mod.InscricaoEstadual;
            String Atividadeeconomica = mod.Atividadeeconomica;
            String CodigoSif = mod.CodigoSif;
            String Site = mod.Site;
            String Email = mod.Email;
            String Telefone1 = mod.Telefone1;
            String Telefone2 = mod.Telefone2;
            String Logradouro = mod.Logradouro;
            String Numero = mod.Numero;
            String Bairro = mod.Bairro;
            String Complemento = mod.Complemento;
            String Cep = mod.Cep;
            String Estado = mod.Estado;
            String Cidade = mod.Cidade;
            String NomeDoResponsavelTecnico = mod.NomeDoResponsavelTecnico;
            String Logo = mod.Logo;

            try
            {
                String[] sql = new String[5];
                sql[0] = @"INSERT INTO Cliente(TipodeCliente, NomeFantasia, RazaoSocial, CNPJ, InscricaoEstadual, Atividadeeconomica, CodigoSif, Site, Email, Telefone1, Telefone2, Logradouro, Numero, Bairro, Complemento, Cep, Estado, Cidade, NomeDoResponsavelTecnico, Logo)VALUES('" + TipodeCliente + "', '" + NomeFantasia + "', '" + RazaoSocial + "', '" + CNPJ + "', '" + InscricaoEstadual + "', '" + Atividadeeconomica + "', '" + CodigoSif + "', '" + Site + "', '" + Email + "', '" + Telefone1 + "', '" + Telefone2 + "', '" + Logradouro + "', '" + Numero + "', '" + Bairro + "', '" + Complemento + "', '" + Cep + "', '" + Estado + "', '" + Cidade + "', '" + NomeDoResponsavelTecnico + "', '" + Logo + "'); ";
                sql[1] = @"UPDATE Cliente SET TipodeCliente = '" + TipodeCliente + "', NomeFantasia = '" + NomeFantasia + "', RazaoSocial = '" + RazaoSocial + "', CNPJ = '" + CNPJ + "', InscricaoEstadual = '" + InscricaoEstadual + "', Atividadeeconomica = '" + Atividadeeconomica + "', CodigoSif = '" + CodigoSif + "', Site = '" + Site + "', Email = '" + Email + "', Telefone1 = '" + Telefone1 + "', Telefone2 = '" + Telefone2 + "', Logradouro = '" + Logradouro + "', Numero = '" + Numero + "', Bairro = '" + Bairro + "', Complemento = '" + Complemento + "', Cep = '" + Cep + "', Estado = '" + Estado + "', Cidade = '" + Cidade + "',  NomeDoResponsavelTecnico = '" + NomeDoResponsavelTecnico + "', Logo = '" + Logo + "' WHERE ID = '" + ID + "'; ";
                sql[2] = @"DELETE FROM Cliente WHERE ID = '" + ID + "'; ";

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
