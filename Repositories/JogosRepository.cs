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

        public void Adicionar(Jogos j)
        {
            _context.Jogos.Add(j);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Jogos j = _context.Jogos.FirstOrDefault(x => x.Id == id);

            if(j == null)return;
            
            _context.Jogos.Remove(j);
            _context.SaveChanges();
        }
    }
}