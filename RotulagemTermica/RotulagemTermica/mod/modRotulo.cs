using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotulagemTermica.mod
{
    public class modRotulo
    {

        public int ID { get; set; }
        public String nome { get; set; }
        public String prazoValidade { get; set; }
        public String modeloID { get; set; }
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
    }
}
