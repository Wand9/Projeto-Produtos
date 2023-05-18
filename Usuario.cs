using System;
using System.Collections.Generic;

public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public void Cadastrar()
        {
            Console.WriteLine("Informe seu nome:");
            Nome = Console.ReadLine();

            Console.WriteLine("Informe seu e-mail:");
            Email = Console.ReadLine();

            Console.WriteLine("Informe sua senha:");
            Senha = Console.ReadLine();

            DataCadastro = DateTime.Now;

            Console.WriteLine("Usuário cadastrado com sucesso!");
        }

        public void Deletar()
        {
            
        }
    }