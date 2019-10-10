
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaNomes.Model
{
    public class Nomes
    {
        [Key]
        public int Id { get; set; }

        
        public string Nome { get; set; }
    }
}
