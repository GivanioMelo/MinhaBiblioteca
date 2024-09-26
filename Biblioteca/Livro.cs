using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro: Entidade
    {
        public string titulo = "Novo Livro";
        public string autor = "Autor";
        public string edicao = "Primeira Edição";
        public DateTime publicacao = DateTime.MinValue;

        public int corredor = 1;
        public int estante = 1;
        public int prateleira = 1;

        public bool disponivel = true;
        public bool perdido = false;
        public bool destruido = false;
    }
}
