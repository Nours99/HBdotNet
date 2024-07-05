using FirstApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TranslateController : ControllerBase
    {
        private readonly ITranslator translator;

        public TranslateController(ITranslator translator)
        {
            this.translator = translator;
        }

        [HttpGet]
        public ActionResult Get(string word)
        {
            if (string.IsNullOrWhiteSpace(word)) // null ou "" ou "   "
                word = "Bonjour";

            return Ok(this.translator.Translate(word));
        }
    }
}
