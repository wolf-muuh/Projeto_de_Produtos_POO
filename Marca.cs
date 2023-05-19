using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Projeto_de_Produtos_POO
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        List<Marca> listaMarcas = new List<Marca>();
        public void Cadastrar()
        {
            Marca marca = new Marca();

            Console.WriteLine($"Digite o código da marca");
            this.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o nome da marca");
            this.NomeMarca = Console.ReadLine();

            listaMarcas.Add(marca);

        }
        public void Listar()
        {
            DataCadastro = DateTime.Now;
            foreach (var item in listaMarcas)
            {
                Console.WriteLine(@$"
                Código: {this.Codigo}
                Nome: {this.NomeMarca}
                Data de cadastro: {this.DataCadastro.ToShortDateString()}
                ");

            }
        }
        public void Deletar(int cod)
        {                    
            
            Marca marcaDelete = listaMarcas.Find(m => m.Codigo == cod);

            listaMarcas.Remove(marcaDelete);
        }


    }
}