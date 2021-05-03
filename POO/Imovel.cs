using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Imovel
    {
        public string tipo;
        public string endereco;
        public string area;
        public decimal preco;
        public decimal taxas;

        public void PrecoFinal()
        {
            decimal preco_final = preco + taxas;
            Console.WriteLine("Preço Final: " + preco_final);
        }
    }


}
