using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotulagemTermica.mod
{
    public class modConteudoRotulo
    {
        public int ID { get; set; }
        public int RotuloID { get; set; }
        public String RotuloDescricao { get; set; }
        public int PesoID { get; set; }
        public String PesoDescricao { get; set; }
        public int FormaFisicaID { get; set; }
        public String FormaFisicaDescricao { get; set; }
    }
}
