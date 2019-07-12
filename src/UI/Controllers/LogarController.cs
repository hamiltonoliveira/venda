
using System;
using System.Data;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using ApplicationCore.Entities;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Recurso.Validacao;


namespace UI.Controllers
{
    [Route("api/[controller]")]
    public class LogarController : Controller
    {
        private readonly IConfiguration _configuration;

        public IActionResult Index()
        {
           return View();
        }


        public LogarController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Index([FromBody] UsuarioViewModel request)
        {

            //dapper
            var _id = "";
            var _perfilid = "";
            var _senha = "";
            var _codigoUsuario = "";
            var _libera = false;
            string _sql = "";
            var _nome = "";

            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }

                _codigoUsuario = request.CodigoUsuario;
                _senha = GerarSenha.Encrypt(request.Senha);

                _sql += @"Select id, CodigoUsuario,Senha,Perfilid, Nome from Usuario where Senha=@senha and CodigoUsuario=@CodigoUsuario and Ativo=1";

                var retorno = db.Query<UsuarioViewModel>(_sql, new { senha = _senha, CodigoUsuario = _codigoUsuario }, commandType: CommandType.Text).ToList();

                if (retorno.Count > 0)
                {
                    _perfilid = retorno[0].Perfilid.ToString();
                    _libera = true;
                    _nome = retorno[0].Nome.ToString();
                    _id = retorno[0].id.ToString();
                }
            }

            //dapper

            // aqui podemos pegar do banco os dados do usuario
            // podemos incluir nas Claim o perfil do usuário - Importante em todos os controllers.
            if (_libera)
            {
                var claims = new[]
                {
                     new Claim(ClaimTypes.Role,_perfilid.ToString()),
                     new Claim(ClaimTypes.Name,_nome.ToString() ),
                     new Claim("codigoUsuario",_codigoUsuario.ToString()),
                     new Claim("id", _id.ToString())
                };

                //recebe uma instancia da classe SymmetricSecurityKey 
                //armazenando a chave de criptografia usada na criação do token
                var key = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(_configuration["SecurityKey"]));

                //recebe um objeto do tipo SigninCredentials contendo a chave de 
                //criptografia e o algoritmo de segurança empregados na geração 
                // de assinaturas digitais para tokens
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

                var token = new JwtSecurityToken(
                     issuer: "hamilton.net",
                     audience: "hamilton.net",
                     claims: claims,
                     expires: DateTime.Now.AddHours(8),
                     signingCredentials: creds);


                //gera o cookie do usuário -  com o JWT
                var _EncodedPayload = new JwtSecurityTokenHandler().WriteToken(token);
                var Cookie = _EncodedPayload.ToString();
            

                Response.Cookies.Delete("D4Cookie");
                Response.Cookies.Append("D4Cookie", Cookie, new Microsoft.AspNetCore.Http.CookieOptions
                {
                    HttpOnly = false,
                    Secure = false,
                    Expires = DateTime.Now.AddHours(8)
                });

                Response.Cookies.Delete("D4User");
                Response.Cookies.Append("D4User", _id, new Microsoft.AspNetCore.Http.CookieOptions
                {
                    HttpOnly = false,
                    Secure = false,
                    Expires = DateTime.Now.AddHours(8)
                });


                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });

            }
            return BadRequest("Credenciais inválidas...");
        }

    }
}