using System;
using System.Collections.Generic;

namespace Projeto_produtos;
public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        
        public Usuario()
        {
            Cadastrar();
        }
        
        public void Cadastrar()
        {
            Console.WriteLine($"Informe seu nome");
            this.Nome = Console.ReadLine();


            Console.WriteLine($"Informe seu Email");
            this.Email = Console.ReadLine();


            Console.WriteLine($"Informe seu Senha");
            this.Senha = Console.ReadLine();

            this.DataCadastro = DateTime.Now;

            Console.WriteLine($"Cadastro concluido");
        }

        public void Deletar()
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Now;
        }
      }