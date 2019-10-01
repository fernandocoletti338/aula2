using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class SistemaCarrosContext
    {
        public List<Carro> ListaDeCarros { get; set; }

        public SistemaCarrosContext()
        {
            ListaDeCarros = new List<Carro>();

            ListaDeCarros.Add(new Carro() { Id = 1, Marca = "Volkswagem", Modelo = "Gol", Ano = 1989, Cilindradas = 1600, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 2, Marca = "Volkswagem", Modelo = "Gol", Ano = 1990, Cilindradas = 1800, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 3, Marca = "Volkswagem", Modelo = "Gol", Ano = 1992, Cilindradas = 1800, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 4, Marca = "Volkswagem", Modelo = "Gol", Ano = 1994, Cilindradas = 2000, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 5, Marca = "Volkswagem", Modelo = "Gol", Ano = 2000, Cilindradas = 1000, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 6, Marca = "Volkswagem", Modelo = "Gol", Ano = 2003, Cilindradas = 1800, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 7, Marca = "Volkswagem", Modelo = "Gol", Ano = 2005, Cilindradas = 1000, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 8, Marca = "Volkswagem", Modelo = "Gol", Ano = 2010, Cilindradas = 1600, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 9, Marca = "Volkswagem", Modelo = "Gol", Ano = 2012, Cilindradas = 1600, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 10, Marca = "Volkswagem", Modelo = "Gol", Ano = 2018, Cilindradas = 1600, Portas = 4 });

        }
        public List<Carro> ListaCarros { get { return ListaDeCarros; } }

    }
}
