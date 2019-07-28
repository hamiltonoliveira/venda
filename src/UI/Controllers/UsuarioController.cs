using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Infra.Data;
using ApplicationCore.Services.IServices;
using Recurso.Validacao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace UI.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
 
    public class UsuarioController : ControllerBase
    {
          private IServices<Usuario> _Repositorio;

        public UsuarioController(IServices<Usuario> Repositorio)
        {
             _Repositorio = Repositorio;
        }

        [EnableCors("EnabledCORS")]
        [Authorize(Roles = "1")]
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            //return await _context.Usuarios.ToListAsync();

            //var claims = User.Claims.ToList();
            //var user = claims.Any(x => x.Type == "Admin");
            //if(user)
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
        public async Task<ActionResult<Usuario>> GetId(int id)
        {
            var model = _Repositorio.GetByIdAsync(id);
            if (model.Result == null)
            {
                return BadRequest(ModelState);
            }
            return Ok(await model);
        }

        [HttpPut("{put}")]
        public async Task<IActionResult> PutUsuario([FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _Repositorio.UpdateAsync(usuario);
            return Ok(usuario);
        }

        [HttpPatch("patch/{id}")]
        public async Task<IActionResult> PatchUsuario(int id,[FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var _usuario = await _Repositorio.GetByIdAsync(id);
          
            if (_usuario != null)
            {
                if ((_usuario.Nome != usuario.Nome) && usuario.Nome != null)
                {
                    _usuario.Nome = usuario.Nome;
                }
               
                if ((_usuario.Email != usuario.Email) && usuario.Email != null){
                    _usuario.Email = usuario.Email;
                }

                if ((_usuario.CnpjCpf != usuario.CnpjCpf) && usuario.CnpjCpf != null)
                {
                    _usuario.CnpjCpf = usuario.CnpjCpf;
                }
               
                if ((_usuario.Senha != usuario.Senha) && usuario.Senha != null)
                {
                    _usuario.Senha = usuario.Senha;
                }

                if ((_usuario.Ativo != usuario.Ativo))
                {
                    _usuario.Ativo = usuario.Ativo;
                }

                if ((_usuario.PerfilId != usuario.PerfilId))
                {
                    _usuario.PerfilId = usuario.PerfilId;
                }

                if ((_usuario.DataCadastro != usuario.DataCadastro) && usuario.DataCadastro != null)
                {
                    _usuario.DataCadastro = usuario.DataCadastro;
                }
              
                if((_usuario.DataUltimoLog != usuario.DataUltimoLog) && usuario.DataUltimoLog != null)
                {
                    _usuario.DataUltimoLog = usuario.DataUltimoLog;
                }
               
            }
            await _Repositorio.UpdateAsync(_usuario);
            return Ok(_usuario);
        }
    

        [HttpPost("post")]
        public async Task<ActionResult<Usuario>> PostUsuario([FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (ValidarEmail.IsValid(usuario.Email))
            {
                return BadRequest(ModelState);
            }

            await _Repositorio.InsertAsync(usuario);
            return Ok(usuario);
        }

        [HttpDelete("{del}")]
        public async Task<ActionResult<Usuario>> DeleteUsuario([FromBody] Usuario usuario)
        {
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                await _Repositorio.DeleteAsync(usuario);
                return Ok(usuario);
            }
        }
   }
}
