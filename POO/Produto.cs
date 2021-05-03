using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace POO
{
    [System.Serializable]
    class Produto
    {
        
        public string nome;
        public string marca;
        public float preco;
        public int quantidade;
        static List<Produto> produtos = new List<Produto>();

        public void ConsultarProdutos()
        {
            if (produtos.Count > 0)
            {
                Console.WriteLine("Lista de produtos: ");
                int i = 0;
                foreach (Produto produto in produtos)
                {
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome: {produto.nome}");
                    Console.WriteLine($"Marca: {produto.marca}");
                    Console.WriteLine($"Quantidade: {produto.quantidade}");
                    Console.WriteLine($"Preço: {produto.preco}");
                    Console.WriteLine("==================================");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
            }
            Console.WriteLine("Aperte enter para sair.");
            Console.ReadLine();
        }

        public void Incluir()
        {
            Produto produto = new Produto();
            Console.WriteLine("Cadastro de produtos: ");
            Console.WriteLine("Nome do produto: ");
            produto.nome = Console.ReadLine();
            Console.WriteLine("Marca do produto: ");
            produto.marca = Console.ReadLine();
            Console.WriteLine("Quantidade em estoque: ");
            produto.quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor do produto: ");
            produto.preco = float.Parse(Console.ReadLine());

            produtos.Add(produto);
            Console.WriteLine("Cadastro concluído, aperte enter para sair.");
            Console.ReadLine();

        }

        public void Comprar()
        {
            ConsultarProdutos();
            Console.WriteLine("Digite o ID do produto que você deseja comprar: ");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {
                produtos.RemoveAt(id);

            }
            else
            {
                Console.WriteLine("Id digitado é inválido, tente novamente!");
                Console.ReadLine();
            }

        }

    }

}
