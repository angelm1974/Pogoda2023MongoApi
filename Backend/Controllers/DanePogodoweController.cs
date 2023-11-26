using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Pogoda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanePogodoweController: ControllerBase
    {
        private readonly DanePogodoweRepozytorium _danePogodoweRepozytorium;

        public DanePogodoweController(DanePogodoweRepozytorium danePogodoweRepozytorium)
        {
            _danePogodoweRepozytorium = danePogodoweRepozytorium;
        }

        // GET: api/DanePogodowe
        [HttpGet("PobierzWszystko")]
        public ActionResult<List<DanePogodowe>> PobierzWszystko()
        {
            return Ok(_danePogodoweRepozytorium.Get());
        }

        [HttpGet("PobierzZakres")]
        public ActionResult<List<DanePogodowe>> PobierzZakres([FromQuery] string startDate, [FromQuery] string endDate)
        {
            try
            {
                var danePogodowe = _danePogodoweRepozytorium.Get(startDate, endDate);
                if (danePogodowe == null || danePogodowe.Count==0)
                {
                    return NotFound();
                }

                return Ok(danePogodowe);
                                              
            }
            catch (Exception ex)
            {
                return StatusCode(500,ex.Message);
            }
        }


        // Post : api/DodajDane
        [HttpPost]
        public ActionResult<DanePogodowe> DodajDane(DanePogodowe danePogodowe)
        {
            _danePogodoweRepozytorium.Create(danePogodowe);
            return Ok(danePogodowe);
        }
    }
}