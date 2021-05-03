using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Pedido
    {
        public int numero_da_mesa;
        public string comanda;
        public string garçom;
        public float preco_a_pagar;

        public void Gorjeta()
        {
            float gorjeta = preco_a_pagar * 0.10f;
            Console.WriteLine("Gorjeta:" + gorjeta);

        }

        public void PrecoFinal()
        {
            float preco_final = (preco_a_pagar * 0.10f) + preco_a_pagar;
            Console.WriteLine("Preço final:" + preco_final);

        }
    }


}
