using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(double preco, int quantidade, string nome) {

            Preco = preco;
            Quantidade = quantidade;
            Nome = nome;

        }

        public double getTotalAmount()
        {
            return Preco * Quantidade;
        }
        public string getTotalProduct() {
            return $"Nome:{Nome} , Preço:{Preco} , Quantidade:{Quantidade} "; 
    }
    }
}
