using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Filme filme = new Filme();
            filme.nome = "Sei la";
            filme.Executar();

            Filme filme2 = new Filme();
            filme2.nome = "Ta dando onda!";
            filme2.Executar();
            filme2.Pausar();
            Console.WriteLine("==================================");

            //------------------------- //------------------------

            Produto produto = new Produto();
            produto.nome = "Capa de Celular";
            produto.marca = "Nokia";
            produto.preco = 25.70f;
            produto.quantidade = 45;

            Console.WriteLine($"Nome: {produto.nome}\n" + $"Marca: {produto.marca}");
            Console.WriteLine($"Quantidade: {produto.quantidade}\n" + $"Preço: {produto.preco}");
            Console.WriteLine("==================================");

            //------------------------- //------------------------

            Jogo marvinho = new Jogo();
            marvinho.nome = "Ultimate Marvel vs Capcom 3";
            marvinho.produtora = "CAPCOM";
            marvinho.preco = 50.00f;
            marvinho.quantidade_estoque = 12;

            Console.WriteLine("Nome: " + marvinho.nome + "\n" + "Produtora: " + marvinho.produtora);
            Console.WriteLine("Preço: " + marvinho.preco + "\n" + "Quantidade: " + marvinho.quantidade_estoque);
            Console.WriteLine("==================================");

            //------------------------- //------------------------

            Pedido pedido = new Pedido();
            pedido.numero_da_mesa = 25;
            pedido.comanda = "Um filé mignon mal passado com uma taça de vinho branco da serra";
            pedido.garçom = "Jacquin";
            pedido.preco_a_pagar = 127.60f;

            Console.WriteLine("Mesa: " + pedido.numero_da_mesa + "\n" + "Prato Principal: " + pedido.comanda);
            Console.WriteLine("Garçom: " + pedido.garçom + "\n" + "Preço: " + pedido.preco_a_pagar);
            pedido.Gorjeta();
            pedido.PrecoFinal();
            Console.WriteLine("==================================");

            //------------------------- //------------------------

            Personagem mago = new Personagem();
            mago.nome = "Gandalf";
            mago.sexo = "Male";
            mago.idade = 1526;
            mago.classe = "White Wizard";
            mago.nivel = "999+";

            Console.WriteLine("Nome: " + mago.nome + "\n" + "Sexo: " + mago.sexo);
            Console.WriteLine("Idade: " + mago.idade + "\n" + "Classe: " + mago.classe + "\n" + "Nivel: " + mago.nivel);
            Console.WriteLine("\nAção 1:");
            mago.Pular();
            Console.WriteLine("\nAção 2:");
            mago.Agachar();
            Console.WriteLine("\nAção 3:");
            mago.Rolar();
            Console.WriteLine("==================================");

            //------------------------- //------------------------

            Imovel imovel = new Imovel();
            imovel.tipo = "Residência Colonial";
            imovel.endereco = "Rua Alamenda Rio Vermelho - 462 - São Tomé das Álgebras";
            imovel.area = "215m²";
            imovel.preco = 260000.00m;
            imovel.taxas = 4600.54m;

            Console.WriteLine("Tipo: " + imovel.tipo + "\n" + "Endereco: " + imovel.endereco);
            Console.WriteLine("Area: " + imovel.area + "\n" + "Preço: " + imovel.preco + "\n" + "Taxas: " + imovel.taxas);
            imovel.PrecoFinal();

            Console.ReadLine();
        }
    }
}
