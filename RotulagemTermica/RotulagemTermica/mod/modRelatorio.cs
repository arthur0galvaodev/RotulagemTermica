using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotulagemTermica.mod
{
    public class modRelatorio
    {
        public int ID { get; set; }
        public String nome { get; set; }
        public String prazoValidade { get; set; }
        public int modeloID { get; set; }
        public String classificacaoProduto { get; set; }
        public String composicaoQualitativa { get; set; }
        public String eventuaisSubistitutivos { get; set; }
        public String niveisGarantia { get; set; }
        public String modoUsar { get; set; }
        public String indicacaoUso { get; set; }
        public String restricoesRecomendacoes { get; set; }
        public String condicaoConservacao { get; set; }
        public String trangenicaMilho { get; set; }
        public String trangenicaSoja { get; set; }
        public String trangenicaAlgodão { get; set; }
        public String textoMinisterio { get; set; }
        public String tabela { get; set; }

        ////Conteudo
        ///
        public int CofnteudoID { get; set; }
        public int RotuloID { get; set; }
        public String RotuloDescricao { get; set; }
        public int PesoID { get; set; }
        public String PesoDescricao { get; set; }
        public int FormaFisicaID { get; set; }
        public String FormaFisicaDescricao { get; set; }
        ///Tabela
        ///
        public int TabelaID { get; set; }
        public int ID_Rotulo { get; set; }
        public String A1 { get; set; }
        public String A2 { get; set; }
        public String A3 { get; set; }
        public String A4 { get; set; }
        public String A5 { get; set; }
        public String A6 { get; set; }
        public String A7 { get; set; }
        public String A8 { get; set; }
        public String A9 { get; set; }
        public String A10 { get; set; }
        public String A11 { get; set; }
        public String A12 { get; set; }
        public String A13 { get; set; }
        public String A14 { get; set; }
        public String A15 { get; set; }
        public String A16 { get; set; }
        public String A17 { get; set; }
        public String A18 { get; set; }
        public String B1 { get; set; }
        public String B2 { get; set; }
        public String B3 { get; set; }
        public String B4 { get; set; }
        public String B5 { get; set; }
        public String B6 { get; set; }
        public String B7 { get; set; }
        public String B8 { get; set; }
        public String B9 { get; set; }
        public String B10 { get; set; }
        public String B11 { get; set; }
        public String B12 { get; set; }
        public String B13 { get; set; }
        public String B14 { get; set; }
        public String B15 { get; set; }
        public String B16 { get; set; }
        public String B17 { get; set; }
        public String B18 { get; set; }

        /// <summary>
        /// ///
        public String C1 { get; set; }
        public String C2 { get; set; }
        public String C3 { get; set; }
        public String C4 { get; set; }
        public String C5 { get; set; }
        public String C6 { get; set; }
        public String C7 { get; set; }
        public String C8 { get; set; }
        public String C9 { get; set; }
        public String C10 { get; set; }
        public String C11 { get; set; }
        public String C12 { get; set; }
        public String C13 { get; set; }
        public String C14 { get; set; }
        public String C15 { get; set; }
        public String C16 { get; set; }
        public String C17 { get; set; }
        public String C18 { get; set; }
        public String D1 { get; set; }
        public String D2 { get; set; }
        public String D3 { get; set; }
        public String D4 { get; set; }
        public String D5 { get; set; }
        public String D6 { get; set; }
        public String D7 { get; set; }
        public String D8 { get; set; }
        public String D9 { get; set; }
        public String D10 { get; set; }
        public String D11 { get; set; }
        public String D12 { get; set; }
        public String D13 { get; set; }
        public String D14 { get; set; }
        public String D15 { get; set; }
        public String D16 { get; set; }
        public String D17 { get; set; }
        public String D18 { get; set; }

        ///
        /// </summary>
        public String lote { get; set; }
        public String Fabricante { get; set; }
        public String Sif { get; set; }
        public String dataFabricacao { get; set; }
        public String dataValidade { get; set; }
        public String textoTransgenia { get; set; }
    }
}
