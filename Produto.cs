using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Projeto_de_Produtos_POO
{
    public class Produto
    {
        Usuario user = new Usuario();
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public string CadastradoPor { get; set; }
        List<Produto> ListaProdutos = new List<Produto>();
        public void Cadastrar()
        {
            Produto produto = new Produto();

            Console.WriteLine($"Digite o código do produto");
            this.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o nome do produto");
            this.NomeProduto = Console.ReadLine();
            Console.WriteLine($"Digite o nome da marca do produto");
            Marca.NomeMarca = Console.ReadLine();
            
            

            ListaProdutos.Add(produto);            
        }
        public void Listar()
        {
            Usuario user = new Usuario();
            DataCadastro = DateTime.Now;
            CadastradoPor = user.Nome;
            foreach (var item in ListaProdutos)
            {
                Console.WriteLine(@$"
                Código: {this.Codigo}
                Nome: {this.NomeProduto}
                Data de cadastro: {DataCadastro.ToShortDateString()}
                Marca do produto: {Marca.NomeMarca}
                Cadastrado por: {this.CadastradoPor}
                ");

            }            
        }        
        public void Deletar(int cod1)
        {
            Produto produtoDelete = ListaProdutos.Find(m => m.Codigo == cod1);

            ListaProdutos.Remove(produtoDelete);
        }        



    }
}