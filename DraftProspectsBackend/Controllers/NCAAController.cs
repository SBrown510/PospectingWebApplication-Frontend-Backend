using CsvHelper;
using DraftProspects.Properties;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace DraftProspects.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NCAAController : ControllerBase
    {

        [HttpGet(Name = "GetNCAAPPGRankings")]
        public List<NCAAHockeyStats> Get()
        {
            var ret = new List<NCAAHockeyStats>();

            var csvString = Resource.NCAA_Statistics_2023_2024___Division_1;

            using (var reader = new StringReader(csvString))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var players = csv.GetRecords<NCAAHockeyStats>().ToList();
                return players;
            }
        }
    }
}
