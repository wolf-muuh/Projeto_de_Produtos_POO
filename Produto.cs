using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Projeto_de_Produtos_POO
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; set; }
        List<Produto> ListaProdutos = new List<Produto>();
        public void Cadastrar()
        {            
        }
        public void Listar()
        {            
        }        
        public void Deletar()
        {            
        }        



    }
}