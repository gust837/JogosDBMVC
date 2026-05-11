using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JogosMVC.Models
{
    public class Jogos
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        public string Genero { get; set; }

        [Required]
        public int Ano { get; set; }

        [Required]
        [Range(0,10)]
        public decimal Nota { get; set; }
    }
}