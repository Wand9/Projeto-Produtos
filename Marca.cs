using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

namespace Projeto_produtos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        public void Cadastrar()
        {
            Console.WriteLine("Digite o código da marca:");
            Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca:");
            NomeMarca = Console.ReadLine();

            DataCadastro = DateTime.Now;

            Console.WriteLine("Marca cadastrada com sucesso!");
        }

        public List<Marca> Listar()
        {
            
            return new List<Marca>();
        }

        public void Deletar(int codigo)
        {
            
        }
    }
}