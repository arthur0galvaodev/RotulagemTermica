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
    public class conPeso
    {
        conexao conect = new conexao();

        public DataTable selecionar(String Busca)
        {
            try
            {
                String sql = "SELECT * FROM Peso WHERE ID  = " + Busca + "; ";
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
                sql[0] = "SELECT * FROM Peso;";
                sql[1] = "SELECT * FROM Peso WHERE ID  = " + Busca + ";";

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

        public void Comando(modPeso mod, int opcao)
        {

            int ID = mod.ID;
            String Descricao = mod.Descricao;


            try
            {
                String[] sql = new String[5];
                sql[0] = @"INSERT INTO Peso(Descricao)VALUES('" + Descricao + "'); ";
                sql[1] = @"UPDATE Peso SET Descricao = '" + Descricao + "' WHERE ID = '" + ID + "'; ";
                sql[2] = @"DELETE FROM Peso WHERE ID = '" + ID + "'; ";

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
