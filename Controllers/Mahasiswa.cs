using Microsoft.AspNetCore.Mvc;

namespace TP_MOD09_1302213026.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Mahasiswa : ControllerBase
    {
        public static List<Mahasiswaa> data = new List<Mahasiswaa>
        {
            new Mahasiswaa("Putu Vidya Ananda R", "1302213026"),
            new Mahasiswaa("Rafidhia Haikalpasya", "1302210127"),
            new Mahasiswaa("Kevin", "1302210019"),
            new Mahasiswaa("Glorious Satria D A", "1302213015"),
            new Mahasiswaa("Farhan Mulya Argyanto", "1302213073"),
        };

        [HttpGet]
        public IEnumerable<Mahasiswaa> Get()
        {
            return data;
        }

        [HttpGet("{id}")]
        public Mahasiswaa Get(int id)
        {
            if(id<0 || id >= data.Count)
            {
                NotFound();
            }
            return data[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswaa value)
        {
            data.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= data.Count)
            {
                NotFound();
            }
            data.RemoveAt(id);
        }
    }    
}