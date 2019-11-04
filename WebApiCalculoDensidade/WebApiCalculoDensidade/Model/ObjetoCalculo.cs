using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCalculoDensidade.Model
{
    public class ObjetoCalculo
    {
        public int Id { get; set; }
        public double Massa { get; set; }
        public double Densidade { get; set; }
        public double Volume { get; set; }
        public double Peso { get; set;}
        public double Gravidade { get; set; } = 9.8;
    }
}
