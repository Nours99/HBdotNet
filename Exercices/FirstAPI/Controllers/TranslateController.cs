using FirstAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TranslateController : ControllerBase
    {
        private readonly ITranslator Translator;

        public TranslateController(ITranslator translator)
        {
            Translator = translator;
        }

        [HttpGet]
        public ActionResult Get(string word) 
        {
            return Ok(Translator.Translate(word));
        }
        
    }
}
