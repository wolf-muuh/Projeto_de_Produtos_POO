using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_de_Produtos_POO;

namespace Projeto_de_Produtos_POO
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca { get; set; }
        public Usuario CadastroPor { get; set; }
        List<Produto> Produtos = new List<Produto>();

        public Cadastrar(Produto _produto)
        {
            
        }
        public void Listar()
        {
            foreach (var item in Produtos)
            {
                Console.WriteLine($"{Codigo}, {NomeProduto}, {DataCadastro}");
                
            }
        }

         public void Deletar(Produto _produto)
        {
            
        }





    }
}