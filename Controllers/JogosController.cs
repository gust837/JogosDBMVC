using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using JogosMVC.Models;
using JogosMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JogosMVC.Controllers
{
    [Route("[controller]")]
    public class JogosController : Controller
    {
        private readonly JogosRepository  _repository;

        public JogosController (JogosRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<Jogos> jogos = _repository.ObterJogos();
            return View(jogos);
        }

    }
}