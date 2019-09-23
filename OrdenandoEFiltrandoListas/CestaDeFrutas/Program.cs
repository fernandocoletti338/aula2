using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Codando muito
            var cestaDeFrutas = new List<Fruta>();

            //vamos no mercado
            cestaDeFrutas.Add(new Fruta()
            {
                Id= 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarelo",
                Peso = 325
            });

            Console.WriteLine("-----------------------");
            #region cesta1
            //ordenamos os valores de forma decrescentes pelo nome
            cestaDeFrutas.OrderBy(x => x.Nome).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome}"));
            #endregion
            Console.WriteLine("-----------------------");
            #region cesta2
            //aqui ordenamos os valores pelo id de forma crescente
            cestaDeFrutas.OrderBy(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome}"));
            #endregion
            Console.WriteLine("-----------Fitro-Peso------------");
            #region cesta3
            //filtramos o registros maiores de 100 gramas
            var filtroCesta = cestaDeFrutas.Where(x => x.Peso > 100).OrderBy(x => x.Nome);
            //ordemos os valores pelo nome
            
            filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Peso {i.Peso}"));

            //frutinha recebe cada fruta de nossa cesta
            (from frutinha in cestaDeFrutas//<- aqui temos a coleção de frutas
             where frutinha.Peso > 100//<- escolhemos as informações
             select frutinha).ToList<Fruta>()
                .ForEach(i => Console.WriteLine($"Fruta escolhida {i.Nome}"));
            #endregion

            Console.WriteLine("-----------Filtro-Peso------------");
            //aqui criamos uma variavel que recebe o valor buscado
            var mostrandoFind = cestaDeFrutas.
                //aqui é o filtro das informações por um "ou --> || <--" outra cor 
                Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id {mostrandoFind.Id} Nome {mostrandoFind.Nome}");

            //aqui criamos uma variavel que recebera a coleção que estamos buscando
            var mostrandoFindAll = cestaDeFrutas.
                //find all com esta condição traz frutas de cor amarela "ou" vermelhas
                FindAll(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            mostrandoFindAll.ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome}"));

            var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);

            foreach (var item in  listaOrdenada)
                Console.WriteLine($"Id {item.Id} Nome {item.Nome}");

            Console.WriteLine("-----------Filtro-Peso------------");

            var cestaDeFrutasFindOrder = cestaDeFrutas.OrderBy(x => x.Nome)
                .ToList<Fruta>().Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id {cestaDeFrutasFindOrder.Id} Nome {cestaDeFrutasFindOrder.Nome}");

            Console.ReadKey();
            #endregion
        }
    }
}
