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
    public class conConteudoRotulo
    {
        conexao conect = new conexao();
        public DataTable selecionar(String Busca)
        {
            try
            {
                String sql = "SELECT CR.ID as Codigo, R.ID as Codigo, R.nome as Nome, P.ID AS IDPeso, P.Descricao AS Peso, F.ID AS IDForma, F.Nome AS Forma FROM ConteudoROTULOS as CR INNER JOIN ROTULOS as R ON CR.RotuloID = R.ID INNER JOIN Peso as P ON CR.PesoID = P.ID INNER JOIN FormaFisicas as F ON CR.FormaFisicaID = F.ID WHERE ID  = " + Busca + "; ";
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
                sql[0] = "SELECT CR.ID as Codigo, R.ID as Codigo, R.nome as Nome, P.ID AS IDPeso, P.Descricao AS Peso, F.ID AS IDForma, F.Nome AS Forma FROM ConteudoROTULOS as CR INNER JOIN ROTULOS as R ON CR.RotuloID = R.ID INNER JOIN Peso as P ON CR.PesoID = P.ID INNER JOIN FormaFisicas as F ON CR.FormaFisicaID = F.ID; ";
                sql[1] = "SELECT CR.ID as Codigo, R.ID as Codigo, R.nome as Nome, P.ID AS IDPeso, P.Descricao AS Peso, F.ID AS IDForma, F.Nome AS Forma FROM ConteudoROTULOS as CR INNER JOIN ROTULOS as R ON CR.RotuloID = R.ID INNER JOIN Peso as P ON CR.PesoID = P.ID INNER JOIN FormaFisicas as F ON CR.FormaFisicaID = F.ID WHERE R.ID = " + Busca + ";";

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
        public void Comando(modConteudoRotulo mod, int opcao)
        {

            int ID = mod.ID;
            int RotuloID = mod.RotuloID;
            String RotuloDescricao = mod.RotuloDescricao;
            int PesoID = mod.PesoID;
            String PesoDescricao = mod.PesoDescricao;
            int FormaFisicaID = mod.FormaFisicaID;
            String FormaFisicaDescricao = mod.FormaFisicaDescricao;


            try
            {
                String[] sql = new String[5];
                sql[0] = @"INSERT INTO ConteudoROTULOS(RotuloID , PesoID,FormaFisicaID)VALUES('" + RotuloID + "', '" + PesoID + "', '" + FormaFisicaID + "'); ";
                sql[1] = @"UPDATE ConteudoROTULOS SET RotuloID = '" + RotuloID + "', PesoID = '" + PesoID + "', FormaFisicaID = '" + FormaFisicaID + "' WHERE ID = '" + ID + "'; ";
                sql[2] = @"DELETE FROM ConteudoROTULOS WHERE ID = '" + ID + "'; ";

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
