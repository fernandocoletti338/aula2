﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomesLista.Model
{
    public class Nomes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nome { get; set; }
    }
}
