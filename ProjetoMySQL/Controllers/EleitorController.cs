using Microsoft.AspNetCore.Mvc;
using ProjetoMySQL.Models;
 
namespace ProjetoMySQL.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class EleitorController : ControllerBase
    {
        private BDContexto contexto;
 
        public EleitorController(BDContexto bdContexto)
        {
            contexto = bdContexto;
        }
 
        [HttpGet]
        public List<Eleitor> Listar()
        {
            return contexto.Eleitors.ToList();
        }
    }
}
