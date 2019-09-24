using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaCarteira
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPessoas = new List<Pessoa>();
            #region Lista de pesssoas
            listaPessoas.Add(new Pessoa()
            {
               Id= 0,
               Nome = "Spears",
               DataDeNascimento = DateTime.Parse("07/11/2004"),
               Carteira  = 846.96
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 1,
                Nome = "Swanson",
                DataDeNascimento = DateTime.Parse("20/06/2003"),
                Carteira = 233.09
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 2,
                Nome = "Gay",
                DataDeNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 911.92
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 3,
                Nome = "Gregory",
                DataDeNascimento = DateTime.Parse("02/01/2000"),
                Carteira = 469.01
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 4,
                Nome = "Olson",
                DataDeNascimento = DateTime.Parse("18/07/2001"),
                Carteira = 261.90
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 5,
                Nome = "Garza",
                DataDeNascimento = DateTime.Parse("01/04/2000"),
                Carteira = 360.41
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 6,
                Nome = "Sweet",
                DataDeNascimento = DateTime.Parse("12/03/2003"),
                Carteira = 312.76
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 7,
                Nome = "Cline",
                DataDeNascimento = DateTime.Parse("26/03/2002"),
                Carteira = 484.51
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 8,
                Nome = "Oliver",
                DataDeNascimento = DateTime.Parse("05/07/2004"),
                Carteira = 513.76
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 9,
                Nome = "Vang",
                DataDeNascimento = DateTime.Parse("10/07/2000"),
                Carteira = 271.05
            }); listaPessoas.Add(new Pessoa()
            {
                Id = 10,
                Nome = "Maddox",
                DataDeNascimento = DateTime.Parse("29/05/2004"),
                Carteira = 783.97
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 11,
                Nome = "Garrett",
                DataDeNascimento = DateTime.Parse("03/06/2006"),
                Carteira = 154.11
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 12,
                Nome = "Mcintosh",
                DataDeNascimento = DateTime.Parse("06/07/2006"),
                Carteira = 902.80
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 13,
                Nome = "Yang",
                DataDeNascimento = DateTime.Parse("29/04/2005"),
                Carteira = 550.48
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 14,
                Nome = "Hendricks",
                DataDeNascimento = DateTime.Parse("05/09/2003"),
                Carteira = 410.56
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 15,
                Nome = "Cain",
                DataDeNascimento = DateTime.Parse("12/01/2002"),
                Carteira = 221.13
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 16,
                Nome = "Blackburn",
                DataDeNascimento = DateTime.Parse("10/05/2000"),
                Carteira = 221.13
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 17,
                Nome = "Howe",
                DataDeNascimento = DateTime.Parse("27/09/2005"),
                Carteira = 360.14
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 18,
                Nome = "Pratt",
                DataDeNascimento = DateTime.Parse("18/09/2000"),
                Carteira = 991.83
            });
            listaPessoas.Add(new Pessoa()
            {
                Id = 19,
                Nome = "Sherman",
                DataDeNascimento = DateTime.Parse("20/02/2003"),
                Carteira = 667.00
            });
            #endregion

            listaPessoas.OrderBy(i => i.Nome).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome}"));

            Console.WriteLine("--------------------------------");

            listaPessoas.OrderByDescending(i => i.DataDeNascimento).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome}"));

            Console.WriteLine("--------------------------------");

            listaPessoas.Where(i => (DateTime.Today.Year - i.DataDeNascimento.Year > 18)).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id{i.Id} Nome: {i.Nome}"));

            Console.WriteLine("--------------------------------");

            listaPessoas.Where(i => (DateTime.Today.Year - i.DataDeNascimento.Year < 16)).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id{i.Id} Nome: {i.Nome}"));

            Console.ReadKey();
        }
    }
}
