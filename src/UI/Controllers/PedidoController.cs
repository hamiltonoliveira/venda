using System;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PedidoController : Controller
    {
        private IServices<Pedido> _Repositorio;
       
        public PedidoController(IServices<Pedido> Repositorio)
        {
            _Repositorio = Repositorio;
        }

        public ActionResult Index()
        {
            var nr = DateTime.Now.Ticks;
            ViewBag.numero = nr;

            DateTime aDate = DateTime.Now;
            ViewBag.dataNow = aDate.ToString("yyyy/MM/dd");
            return View();
        }


        // POST: api/Usuario
        [HttpPost("post")]
        public async Task<ActionResult<Pedido>> PostPedido([FromBody] Pedido pedido)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           
            await _Repositorio.InsertAsync(pedido);
            return Ok(pedido);
        }
    }
}

