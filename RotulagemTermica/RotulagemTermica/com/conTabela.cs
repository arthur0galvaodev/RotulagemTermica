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
    public class conTabela
    {
        conexao conect = new conexao();

        public DataTable selecionar(String Busca)
        {
            try
            {
                String sql = "SELECT * FROM Tabela WHERE ID  = " + Busca + "; ";
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
                sql[0] = "SELECT T.ID as Codigo, R.ID as CodigoR, R.nome, R.niveisGarantia as Garantia FROM Tabela as T INNER JOIN ROTULOS as R ON T.ID_Rotulo = R.ID; ";
                sql[1] = "SELECT * FROM Tabela WHERE ID_Rotulo  = " + Busca + ";";

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

        public void Comando(modTabela mod, int opcao)
        {
            int ID_Rotulo = mod.ID_Rotulo;
            int ID = mod.ID;
            String a1 = mod.A1;
            String a2 = mod.A2;
            String a3 = mod.A3;
            String a4 = mod.A4;
            String a5 = mod.A5;
            String a6 = mod.A6;
            String a7 = mod.A7;
            String a8 = mod.A8;
            String a9 = mod.A9;
            String a10 = mod.A10;
            String a11 = mod.A11;
            String a12 = mod.A12;
            String a13 = mod.A13;
            String a14 = mod.A14;
            String a15 = mod.A15;
            String a16 = mod.A16;
            String a17 = mod.A17;
            String a18 = mod.A18;

            String b1 = mod.B1;
            String b2 = mod.B2;
            String b3 = mod.B3;
            String b4 = mod.B4;
            String b5 = mod.B5;
            String b6 = mod.B6;
            String b7 = mod.B7;
            String b8 = mod.B8;
            String b9 = mod.B9;
            String b10 = mod.B10;
            String b11 = mod.B11;
            String b12 = mod.B12;
            String b13 = mod.B13;
            String b14 = mod.B14;
            String b15 = mod.B15;
            String b16 = mod.B16;
            String b17 = mod.B17;
            String b18 = mod.B18;

            String c1 = mod.C1;
            String c2 = mod.C2;
            String c3 = mod.C3;
            String c4 = mod.C4;
            String c5 = mod.C5;
            String c6 = mod.C6;
            String c7 = mod.C7;
            String c8 = mod.C8;
            String c9 = mod.C9;
            String c10 = mod.C10;
            String c11 = mod.C11;
            String c12 = mod.C12;
            String c13 = mod.C13;
            String c14 = mod.C14;
            String c15 = mod.C15;
            String c16 = mod.C16;
            String c17 = mod.C17;
            String c18 = mod.C18;

            String d1 = mod.D1;
            String d2 = mod.D2;
            String d3 = mod.D3;
            String d4 = mod.D4;
            String d5 = mod.D5;
            String d6 = mod.D6;
            String d7 = mod.D7;
            String d8 = mod.D8;
            String d9 = mod.D9;
            String d10 = mod.D10;
            String d11 = mod.D11;
            String d12 = mod.D12;
            String d13 = mod.D13;
            String d14 = mod.D14;
            String d15 = mod.D15;
            String d16 = mod.D16;
            String d17 = mod.D17;
            String d18 = mod.D18;
            try
            {
                String[] sql = new String[5];
                sql[0] = @"INSERT INTO Tabela(ID_Rotulo,A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13,A14,A15,A16,A17,A18,B1,B2,B3,B4,B5,B6,B7,B8,B9,B10,B11,B12,B13,B14,B15,B16,B17,B18,c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11,c12,c13,c14,c15,c16,c17,c18,d1,d2,d3,d4,d5,d6,d7,d8,d9,d10,d11,d12,d13,d14,d15,d16,d17,d18) VALUES('" + ID_Rotulo + "','" + a1 + "','" + a2 + "','" + a3 + "','" + a4 + "','" + a5 + "','" + a6 + "','" + a7 + "','" + a8 + "','" + a9 + "','" + a10 + "','" + a11 + "','" + a12 + "','" + a13 + "','" + a14 + "','" + a15 + "','" + a16 + "','" + a17 + "','" + a18 + "','" + b1 + "','" + b2 + "','" + b3 + "','" + b4 + "','" + b5 + "','" + b6 + "','" + b7 + "','" + b8 + "','" + b9 + "','" + b10 + "','" + b11 + "','" + b12 + "','" + b13 + "','" + b14 + "','" + b15 + "','" + b16 + "','" + b17 + "','" + b18 + "'," + "'" + c1 + "','" + c2 + "','" + c3 + "','" + c4 + "','" + c5 + "','" + c6 + "','" + c7 + "','" + c8 + "','" + c9 + "','" + c10 + "','" + c11 + "','" + c12 + "','" + c13 + "','" + c14 + "','" + c15 + "','" + c16 + "','" + c17 + "','" + c18 + "','" + d1 + "','" + d2 + "','" + d3 + "','" + d4 + "','" + d5 + "','" + d6 + "','" + d7 + "','" + d8 + "','" + d9 + "','" + d10 + "','" + d11 + "','" + d12 + "','" + d13 + "','" + d14 + "','" + d15 + "','" + d16 + "','" + d17 + "','" + d18 + "'); ";
                sql[1] = @"UPDATE Tabela SET A1 = '" + a1 + "' A2 = '" + a2 + "'A3 = '" + a3 + "'A4 = '" + a4 + "'A5 = '" + a5 + "'a6 = '" + a6 + "'a7 = '" + a7 + "'a8 = '" + a8 + "'a9 = '" + a9 + "' a10 = '" + a10 + "' a11 = '" + a11 + "' a12 = '" + a12 + "' a13 = '" + a13 + "' a14 = '" + a14 + "' a15 = '" + a15 + "'a16 = '" + a16 + "' a17 = '" + a17 + "' a18 = '" + a18 + "' b1 = '" + b1 + "' b2 = '" + b2 + "' b3 = '" + b3 + "'b4 = '" + b4 + "' b5 = '" + b5 + "' b6 = '" + b6 + "' b7 = '" + b7 + "' b8 = '" + b8 + "' b9 = '" + b9 + "'b10 = '" + b10 + "' b11 = '" + b11 + "'b12 = '" + b12 + "' b13 = '" + b13 + "'b14 = '" + b14 + "' b15 = '" + b15 + "' b16 = '" + b16 + "' b17 = '" + b17 + "' b18 = '" + b18 + "'  WHERE ID = '" + ID + "'; ";
                sql[2] = @"DELETE FROM Tabela WHERE ID = '" + ID + "'; ";

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
