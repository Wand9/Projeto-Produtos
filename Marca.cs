using System;
using System.Collections.Generic;

namespace Projeto_produtos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        List<Marca> ListaDeMarcas = new List<Marca>();

        public string Cadastrar()
        {
            Marca NovaMarca = new Marca();

            Console.WriteLine("Digite o código da marca:");
            NovaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca:");
            NovaMarca.NomeMarca = Console.ReadLine();

            ListaDeMarcas.Add(NovaMarca);

            NovaMarca.DataCadastro = DateTime.Now;

            return "Marca cadastrada com sucesso!";
        }

        public void Listar()
        {
            foreach (var novaMarca in ListaDeMarcas)
            {
                Console.WriteLine($"-------------------");
                Console.WriteLine($"Codigo da Marca: {novaMarca.Codigo}");
                Console.WriteLine($"Nome da Marca: {novaMarca.NomeMarca}");
                Console.WriteLine($"Data do cadastro: {novaMarca.DataCadastro}");
                Console.WriteLine($"-------------------");

            }
        }

        public string Deletar(int Codigo)
        {
            Marca marca = ListaDeMarcas.Find(x => x.Codigo == Codigo);
            ListaDeMarcas.Remove(marca);
            return "Marca deletada com sucesso!";
        }
    }
}