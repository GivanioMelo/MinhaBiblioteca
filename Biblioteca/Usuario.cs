using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario:Entidade
    {
        public string nome = "Novo Usuário";
        public string telefone = "";
        public string endereco = "";
        public string email = "";
        public bool banido = false;
    }
}
