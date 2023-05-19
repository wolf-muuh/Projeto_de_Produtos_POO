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
                GerarMenu(user);
            }
        }
        public void Logar(Usuario _usuario)
        {

            _usuario.Cadastrar();
            string emailDigitado;
            string senhaDigitada;
            do
            {



                Console.WriteLine(@$"
            ---------------------
               Repita os dados 
            para efetuar o login
            ---------------------
            ");


                Console.WriteLine($"Insira o seu email");
                emailDigitado = Console.ReadLine();

                Console.WriteLine($"Insira a sua senha");
                senhaDigitada = Console.ReadLine();

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
            } while (emailDigitado != _usuario.Email && senhaDigitada != _usuario.Senha);

        }
        public void Deslogar()
        {
            this.Logado = false;
        }
        public void GerarMenu(Usuario user)
        {
            
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

                [7] - Dados do perfil

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
                        Console.WriteLine($"Digite o código do produto que você quer remover");
                        int cod1 = int.Parse(Console.ReadLine());

                        produto.Deletar(cod1);
                        break;
                    case "4":
                        marca.Cadastrar();
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":
                        Console.WriteLine($"Digite o código do produto que você quer remover");
                        int cod = int.Parse(Console.ReadLine());
                        marca.Deletar(cod);
                        break;

                    case "7":

                        string opcao2;
                        do
                        {
                            Console.WriteLine(@$"
                        Nome: {user.Nome}
                        Email: {user.Email}
                        Senha: ***** (digite 1 para visualizar a senha)
                        Data de cadastro: {user.DataCadastro}

                        Deseja apagar esse cadastro? s/n
                        ");

                            opcao2 = Console.ReadLine().ToLower();
                            switch (opcao2)
                            {
                                case "1":
                                    string opcao4;
                                    Console.WriteLine(@$"
                        Nome: {user.Nome}
                        Email: {user.Email}
                        Senha: {user.Senha}
                        Data de cadastro: {user.DataCadastro}

                        Deseja apagar esse cadastro? s/n
                        ");
                                    opcao4 = Console.ReadLine().ToLower();
                                    switch (opcao4)
                                    {
                                        case "s":
                                            this.Deslogar();
                                            user.Deletar();
                                            string opcao5;
                                            Console.WriteLine($"Cadastro apagado! deseja criar outro cadastro? s/n (se você não realizar um cadastro não será possivel utilizar o programa)");
                                            opcao5 = Console.ReadLine().ToLower();
                                            switch (opcao5)
                                            {
                                                case "s":
                                                    user.Cadastrar();
                                                    break;
                                                case "n":
                                                    Console.WriteLine($"Fim do programa tenha um bom dia!");

                                                    break;
                                                default:
                                                    Console.WriteLine($"Digite uma opção válida");

                                                    break;
                                            }
                                            break;
                                        case "n":
                                            Console.WriteLine($"Ok cadastro mantido!");

                                            break;
                                        default:
                                            Console.WriteLine($"Digite uma opção válida");

                                            break;
                                    }



                                    break;
                                case "s":
                                    this.Deslogar();
                                    user.Deletar();
                                    string opcao3;
                                    Console.WriteLine($"Cadastro apagado! deseja criar outro cadastro? s/n (se você não realizar um cadastro não será possivel utilizar o programa)");
                                    opcao3 = Console.ReadLine().ToLower();
                                    do
                                    {
                                        switch (opcao3)
                                        {
                                            case "s":
                                                user.Cadastrar();
                                                break;
                                            case "n":
                                                Console.WriteLine($"Fim do programa tenha um bom dia!");

                                                break;
                                            default:
                                                Console.WriteLine($"Digite uma opção válida");

                                                break;
                                        }
                                    } while (opcao3 != "n");



                                    break;
                                case "n":
                                    Console.WriteLine($"Ok, cadastro mantido");

                                    break;
                                default:
                                    Console.WriteLine($"Digite uma opção válida!");

                                    break;
                            }
                        } while (opcao2 != "n");
                        break;
                    case "0":
                        Console.WriteLine($"Fim do programa! Digite sua senha novamente para poder deslogar da sua conta");
                        string senha;
                        do
                        {
                            senha = Console.ReadLine();

                            if (senha == user.Senha)
                            {
                                this.Deslogar();
                                Console.WriteLine($"Deslogado! Tchauzinho!");
                            }
                            else
                            {
                                Console.WriteLine($"Senha invalida");

                            }
                        } while (senha != user.Senha);


                        break;
                    default:
                        Console.WriteLine($"Digite uma opção válida!");

                        break;
                }



            } while (opcao != "0");
        }
    }
}