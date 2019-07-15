﻿using ApplicationCore.Entities;
using ApplicationCore.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private IServices<Produto> _Repositorio;
        // GET: Produto

        public ProdutoController(IServices<Produto> Repositorio)
        {
            _Repositorio = Repositorio;
        }

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet("GetId/{id}")]
        public ActionResult<IEnumerable<Produto>> GetId(int id)
        {
            var Clientes = _Repositorio.Where(p => p.id == id);

            return Ok(Clientes);
        }

        [HttpGet("Get/{nome}")]
        public ActionResult<IEnumerable<Produto>> Tudo(string nome)
        {
            var Clientes = _Repositorio.Where(p => p.Nome.Contains(nome)).OrderBy(x => x.Nome).ToList();
            return Ok(Clientes);
        }

    }
}