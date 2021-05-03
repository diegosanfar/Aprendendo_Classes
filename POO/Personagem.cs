using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Personagem
    {
        public string nome;
        public string sexo;
        public string classe;
        public int idade;
        public string nivel;

        public void Pular()
        {
            Console.WriteLine("Eu pulei!");
        }

        public void Agachar()
        {
            Console.WriteLine("Estou agachado!");
        }

        public void Rolar()
        {
            Console.WriteLine("Estou rolando");
        }
    }

}
