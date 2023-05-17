using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos_POO
{
    public class Login
    {
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
        public void Logar(Usuario _usuario)
        {
            Console.WriteLine($"Insira o seu email");
            string emailDigitado = Console.ReadLine();

            Console.WriteLine($"Insira a sua senha");
            string senhaDigitada = Console.ReadLine();

            if (emailDigitado == _usuario.Email && senhaDigitada == _usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login efetuado com sucesso!");

            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao logar");
            }

        }
        public void Deslogar()
        {
            this.Logado = false;
        }
        public void GerarMenu()
        {
            Usuario user = new Usuario();
            Produto produto = new Produto();
            Marca marca = new Marca();
            string opcao;

            do
            {
                Console.WriteLine(@$"
                [1] - Cadastrar produto
                [2] - Listar produtos
                [3] - Remover produtos

                [4] - Cadastrar marca
                [5] - Listar marcas
                [6] - Remover marcas

                [0] - sair

                ");

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
                        produto.Deletar();
                        break;
                    case "4":
                        marca.Cadastrar();
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":

                        marca.Deletar();
                        break;
                    case "0":
                        Console.WriteLine($"Fim do programa! Digite sua senha novamente para poder deslogar da sua conta");
                        string senha = Console.ReadLine();
                        if(senha == user.Senha)
                        {
                            
                        }


                        break;
                    default:
                        Console.WriteLine($"Digite uma conta ");
                        
                        break;
                }



            } while (opcao != "0");
        }
    }
}