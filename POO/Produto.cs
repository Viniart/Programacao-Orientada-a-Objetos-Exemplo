using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        public double CalcularTotal()
        {
            return preco * quantidadeEmEstoque;
        }
    }
}
