using ApplicationCore.Entities;
using ApplicationCore.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClienteController : Controller
    {
        // GET: Cliente
        private IServices<Cliente> _Repositorio;

        public ClienteController(IServices<Cliente> Repositorio)
        {
            _Repositorio = Repositorio;

        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("getall")]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            //var claims = User.Claims.ToList();
            //var user = claims.Any(x => x.Type == "Admin");
            //if (user)
            //{
            //    return await _Repositorio.GetAllAsync();
            //}
            //else
            //{
            //    return await _Repositorio.GetAllAsync();
            //}

            return await _Repositorio.GetAllAsync();
       }

  
        [HttpGet("GetId/{id}")]
        public ActionResult<IEnumerable<Cliente>> GetId(int id)
        {
           var Clientes = _Repositorio.Where(p => p.id == id);

            return  Ok(Clientes);
        }

        [HttpGet("Get/{nome}")]
        public ActionResult<IEnumerable<Cliente>> Tudo(string nome)
        {
            var Clientes = _Repositorio.Where(p=>p.Nome.Contains(nome)).OrderBy(x=>x.Nome).ToList();
            return Ok(Clientes);
        }

    }
}