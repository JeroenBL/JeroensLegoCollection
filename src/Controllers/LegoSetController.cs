using BlazingLego.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazingLego.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class LegoSetController : ControllerBase
    {
        // GET: api/<LegoSetController>
        [HttpGet("{setNumber}")]
        public async Task<ActionResult<string>> Get(string setNumber)
        {
            var JsonDataService = new JsonDataService();
            return JsonConvert.SerializeObject(JsonDataService.GetLegoSet(setNumber));
        }
    }
}
