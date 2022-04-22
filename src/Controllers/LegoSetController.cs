using BlazingLego.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

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
            return JsonConvert.SerializeObject(GetLegoSet(setNumber));
        }

        private LegoSet GetLegoSet(string setNumber) 
        {
            var jsonLegoDataDb = ReadLegoSetDbFromJson();
            var legoSets = JsonConvert.DeserializeObject<List<LegoSet>>(jsonLegoDataDb);

            return legoSets.Where(s => s.SetNumber == setNumber).FirstOrDefault();           
        }

        private string ReadLegoSetDbFromJson()
        {
            string jsonData;
            var fileStream = new FileStream(@"legoSetDb.json", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                jsonData = streamReader.ReadToEnd();
            }

            return jsonData;
        }
    }
}
