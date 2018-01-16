using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosLocalizacao.Classes.Model
{
    /// <summary>
    /// Entidade de dados AmigosLocalizacao
    /// </summary>
    public class AmigosLocalizacaoModel
    {
        public int id { get; set; }
        public string nome_amigo { get; set; }
        public string cidade { get; set; }
        public string Point { get; set; }
        public double Distancia { get; set; }
    }
}
