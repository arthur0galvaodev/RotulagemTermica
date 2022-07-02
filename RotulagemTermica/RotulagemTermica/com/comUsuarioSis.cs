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
    public class comUsuarioSis
    {

        conexao conect = new conexao();
        public DataTable selecionar(String Busca)
        {
            try
            {
                String sql = "SELECT * FROM usuarioSis WHERE id  = " + Busca + "; ";
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
                sql[0] = "SELECT * FROM usuarioSis;";
                sql[1] = "SELECT * FROM usuarioSis WHERE id  = " + Busca + ";";
                sql[2] = "SELECT * FROM usuarioSis WHERE nome  = '" + Busca + "';";

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

        public void Comando(modUsuarioSis mod, int opcao)
        {

            int id = mod.id;
            String nome = mod.nome;
            String email = mod.email;
            String nivel = mod.nivel;
            String senha = mod.senha;
            int idCliente = mod.idCliente;

            try
            {
                String[] sql = new String[5];
                sql[0] = @"INSERT INTO usuarioSis(nome,email,nivel,senha,idCliente)VALUES('" + nome + "','" + email + "','" + nivel + "','" + senha + "','" + idCliente + "'); ";
                sql[1] = @"UPDATE usuarioSis SET nome = '" + nome + "',email = '" + email + "',senha = '" + senha + "',nivel = '" + nivel + "' WHERE id = '" + id + "'; ";
                sql[2] = @"DELETE FROM usuarioSis WHERE id = '" + id + "'; ";

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
