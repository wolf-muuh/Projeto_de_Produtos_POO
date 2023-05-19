using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos_POO
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public void Cadastrar()
        {
            Console.WriteLine(@$"
            ---------------------------
                Crie o seu cadastro
            ---------------------------    
            ");
            
            Console.WriteLine($"Digite seu nome");            
            this.Nome = Console.ReadLine();
            Console.WriteLine($"Digite o seu email");            
            this.Email = Console.ReadLine();
            Console.WriteLine($"Crie uma senha");            
            this.Senha = Console.ReadLine();
            this.DataCadastro = DateTime.Now;
        }

        public void Deletar()
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00");
        }

    }
}