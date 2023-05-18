using System;
using System.Collections.Generic;

public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Projeto_produtos.Marca Marca { get; set; }
        public Usuario CadastradoPor { get; set; }
        public List<Produto> ListaDeProdutos { get; set; }

        public void Cadastrar()
        {
            Console.WriteLine("Informe o código do produto:");
            Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do produto:");
            NomeProduto = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto:");
            Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.Now;

            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        public void Listar()
        {
            
        }

        public void Deletar(int codigo)
        {
            
        }
    }