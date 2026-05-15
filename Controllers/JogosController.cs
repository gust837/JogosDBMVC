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
    public class JogosController : Controller
    {
        private readonly JogosRepository _repository;

        public JogosController(JogosRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            @ViewData["Title"] = "Lista";
            List<Jogos> jogos = _repository.ObterJogos();
            ViewBag.TotalJogos = jogos.Count;
            return View(jogos);
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            @ViewData["Title"] = "Cadastro";
            return View();
        }


        [HttpPost]
        public IActionResult Cadastro(Jogos j)
        {
            string notaString = Request.Form["nota"].ToString().Replace(".", ",");

            if (decimal.TryParse(notaString, out var notaConvertida))
            {
                j.Nota = notaConvertida;
            }

            _repository.Adicionar(j);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}