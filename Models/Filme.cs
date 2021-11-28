using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Filme
    {
        public int idFilme{ get; set; }
        public string CodigoBarras { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Ator { get; set; }
        public string Ano { get; set; }
        public string Tipo { get; set; }
        public string Diretor { get; set; }
        public string Tecnologia { get; set; }
        public decimal Preco { get; set; }
        public decimal Custo { get; set; }
        public DateTime DtAquisicao { get; set; }
        public string Status { get; set; }
        public virtual string ImageUrl { get; set; }
    }
}
