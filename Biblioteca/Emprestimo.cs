using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Emprestimo:Entidade
    {
        public DateTime dataEmprestimo = DateTime.Now;
        public DateTime dataDevolucao = DateTime.Now;
        public int idLivro = 0;
        public int idUsuário = 0;
        public bool devolvido = false;
    }
}
