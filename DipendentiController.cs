using DemoAPI.Model;
using DemoAPI.Model.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DipendentiController : Controller
    {
        private IRepositoryDipendenti dipendenti;

        public DipendentiController(IRepositoryDipendenti dipendenti) 
        {
            this.dipendenti = dipendenti;
        }

        [HttpGet]
        public List<Dipendenti> GetAll()
        {
            return dipendenti.GetAll();
        }

        [HttpGet("{id}")]
        public Dipendenti GetById(int id)
        {
            return dipendenti.GetById(id);
        }
        [HttpPost]
        public Dipendenti Post([FromBody] Dipendenti dip)
        {
            return dipendenti.Add(dip);
        }

        [HttpPut]
        public Dipendenti Put([FromBody] Dipendenti dip)
        {
            return dipendenti.Update(dip);
        }

        [HttpDelete("{id:int}")]
        public Dipendenti Remove([FromBody] int id)
        {
            return dipendenti.Remove(id);
        }
    }
}
