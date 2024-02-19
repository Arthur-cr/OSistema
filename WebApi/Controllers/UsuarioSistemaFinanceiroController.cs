using Domain.Interfaces.InterfaceServicos;
using Domain.Interfaces.IUsuarioSistemaFinanceiro;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioSistemaFinanceiroController : ControllerBase
    {
        private readonly InterfaceUsuarioSistemaFinanceiro _InterfaceUsuarioSistemaFinanceiro;
        private readonly IUsuarioSistemaFinanceiroServico _IUsuarioSistemaFinanceiroServico;
        public UsuarioSistemaFinanceiroController(InterfaceUsuarioSistemaFinanceiro InterfaceUsuarioSistemaFinanceiro,
            IUsuarioSistemaFinanceiroServico IUsuarioSistemaFinanceiroServico)
        {
            _InterfaceUsuarioSistemaFinanceiro = InterfaceUsuarioSistemaFinanceiro;
            _IUsuarioSistemaFinanceiroServico = IUsuarioSistemaFinanceiroServico;
        }


        [HttpGet("/api/ListaSistemaUsuario")]
        [Produces("application/json")]
        public async Task<object> ListaUsuarioSistemaFinanceiro(int idSistema)
        {
            return await _InterfaceUsuarioSistemaFinanceiro.ListarUsuariosSistema(idSistema);
        }
    }
}
