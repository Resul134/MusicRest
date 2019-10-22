using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modellib;

namespace MusicRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {

        private static List<Record> recordsList = new List<Record>()
        {
            new Record("From", "Christian", 03.43, 2019),
            new Record("Wow", "Resul", 03.43, 2018)


        };
        // GET: api/Records
        [HttpGet]
        public List<Record> GetAll()
        {
            return recordsList;
        }

        // GET: api/Records/5
        [HttpGet("{substring}")]
        public Record Get(string substring)
        {
            return recordsList.Find(i => i.Title == substring);
        }


        [HttpGet("{id}")]
        public Record Get(int id)
        {
            return recordsList.Find(i => i.Id == id);
        }

        // POST: api/Records
        [HttpPost]
        public void Post([FromBody] Record value)
        {
            recordsList.Add(value);
        }

        // PUT: api/Records/5
        [HttpPut("{title}")]
        public void Put(string title, [FromBody] Record value)
        {
            Record record = Get(title);
            if (record != null)
            {
                record.Title = value.Title;
                record.Artist = value.Artist;
                record.Duration = value.Duration;
                record.YearOfPublication = value.YearOfPublication;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{title}")]
        public void Delete(string title)
        {
            Record records = Get(title);
            if (records != null)
            {
                recordsList.Remove(records);
            }

        }
    }
}
