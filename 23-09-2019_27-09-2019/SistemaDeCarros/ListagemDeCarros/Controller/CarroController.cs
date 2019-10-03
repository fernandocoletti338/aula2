using ListagemDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Controller
{
    public class CarroController
    {
        SistemaCarrosContext sistemaCarrosContext = new SistemaCarrosContext();
        /// <summary>
        /// metodo q retorna nossa lista de carros completa28
        /// </summary>
        /// <returns>retorna nossa lista de carros</returns>

        public List<Carro> GetCarros()
        {
            return sistemaCarrosContext.ListaCarros;
        }
    }

}
