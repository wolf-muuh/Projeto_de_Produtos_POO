using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_de_Produtos_POO;

namespace Projeto_de_Produtos_POO
{
    public class Marca
    {
        public string Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        List<Marca> Marcas = new List<Marca>();
        public void Cadastrar(Marca _marca)
        {
        }
        
        public void Listar()
        {
            foreach (var item in Marcas)
            {
                Console.WriteLine($"{Codigo}, {NomeMarca}, {DataCadastro}");
                
            }
        }

        public void Deletar(Marca _marca)
        {
            
        }

    }
}