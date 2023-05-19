using System;
using Projeto_produtos;

public class Login
    {
    private object usuario;

    public bool Logado { get; set; }

        public Login()
        {
            Usuario user = new Usuario();

            Logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }

        public void Logar(Usuario usuario)
        {
            Console.WriteLine("Faça login!");
            Console.WriteLine("Insira seu email cadastrado:");
            string email = Console.ReadLine();

            Console.WriteLine("Insira sua senha:");
            string senha = Console.ReadLine();

            if (email == usuario.Email && senha == usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine("Login efetuado com sucesso!");
            }
            else
            {
                this.Logado = false;
                Console.WriteLine("Email ou senha incorretos!");
            }
        }

        public void Deslogar()
        {
             if (Usuario.Logado)
            {
                Logado = false;
                Console.WriteLine($"Usuário {nome} deslogado com sucesso!");
            }
            else
            {
                Console.WriteLine("Usuário já está deslogado!");
            }
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;
            do
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("|                         |");
                Console.WriteLine("|  1- Cadastrar Produto   |");
                Console.WriteLine("|  2- Listar Produto      |");
                Console.WriteLine("|  3- Remover Produto     |");
                Console.WriteLine("|_________________________|");
                Console.WriteLine("_________________________");
                Console.WriteLine("|  4- Cadastrar Marca     |");
                Console.WriteLine("|  5- Listar Marca        |");
                Console.WriteLine("|  6- Remover Marca       |");
                Console.WriteLine("-------------------------");
                Console.WriteLine("| 0- Sair               |");
                Console.WriteLine("-------------------------");

                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar();
                        break;
                    case "2":
                        produto.Listar();
                        break;
                    case "3":
                        Console.WriteLine("Informe o código do produto que deseja remover:");
                        int codigoProduto = int.Parse(Console.ReadLine());
                        produto.Deletar(codigoProduto);
                        break;
                    case "4":
                        marca.Cadastrar();
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":
                        Console.WriteLine("Informe o código da marca que deseja remover:");
                        int codigoMarca = int.Parse(Console.ReadLine());
                        marca.Deletar(codigoMarca);
                        break;
                    case "0":
                        Console.WriteLine("App encerrado");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != "0");
        }
    }
