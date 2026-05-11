using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JogosMVC.Contexts;
using JogosMVC.Models;

namespace JogosMVC.Repositories
{
    public class JogosRepository
    {
        private readonly JogosDBContext _context;

        public JogosRepository (JogosDBContext context)
        {
           _context = context; 
        }

        public List<Jogos> ObterJogos()
        {
            return _context.Jogos.ToList();
        }
    }
}