using Microsoft.AspNetCore.Mvc;
using MyDto;
using SearchProject;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TanachController : Controller
    {

        [HttpGet("getA/{word}")]
        public List<location> Get(string word)
        {
            return BLL.Answer(word);
        }

        [HttpGet("getR/{word}")]
        public List<location> GetRT(string word)
        {
            return BLL.RT(word);
        }
        [HttpGet("getE/{word}")]
        public List<location> GetE(string word)
        {
            return BLL.Answer(word);
        }

    }
}
