using BlazingLego.Data.Models;
using Newtonsoft.Json;
using System.Text;

namespace BlazingLego.Data.Services
{
    public class JsonDataService
    {
        public LegoSet GetLegoSet(string setNumber)
        {
            var jsonLegoDataDb = ReadLegoSetDbFromJson();
            var legoSets = JsonConvert.DeserializeObject<List<LegoSet>>(jsonLegoDataDb);

            var setOne = $"{setNumber}-1";
            var setTwo = $"{setNumber}-2";
            var setThree = $"{setNumber}-3";

            LegoSet legoSet = legoSets.Where(s => s.SetNumber == setOne || 
                                                  s.SetNumber == setTwo ||
                                                  s.SetNumber == setThree).FirstOrDefault();

            return legoSet;

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
