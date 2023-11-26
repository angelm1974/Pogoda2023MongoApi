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
        [HttpGet]
        public ActionResult<List<DanePogodowe>> PobierzWszystko()
        {
            return Ok(_danePogodoweRepozytorium.Get());
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