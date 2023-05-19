using System;
using System.Collections.Generic;
using Projeto_produtos;

public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; set; }
        List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar()
        {
            Console.WriteLine("Digite o código do produto:");
            NovoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto:");
            NovoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            NovoProduto.Preco = float.Parse(Console.ReadLine());

            ListaDeProdutos.Add(NovoProduto);

            NovoProduto.DataCadastro = DateTime.Now;

            return "Produto cadastrado com sucesso!";
        }

        public List<Produto> Listar()
        {
            return new List<Produto>();
        }

        public string Deletar(Produto produto)
        {
            return "Produto deletado com sucesso!";
        }

    internal void Deletar(int codigoProduto)
    {
        throw new NotImplementedException();
    }

    internal void Cadastrar()
    {
        throw new NotImplementedException();
    }
}

public class Marca
{
    internal void Cadastrar()
    {
        throw new NotImplementedException();
    }

    internal void Deletar(int codigoMarca)
    {
        throw new NotImplementedException();
    }

    internal void Listar()
    {
        throw new NotImplementedException();
    }
}