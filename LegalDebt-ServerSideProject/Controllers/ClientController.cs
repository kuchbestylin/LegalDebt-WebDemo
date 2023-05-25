using LegalDebt_ServerSideProject.Data;
using LegalDebt_ServerSideProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LegalDebt_ServerSideProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly LegalDebtDbContext dbContext;
        public ClientController(LegalDebtDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Client>> Get()
        {
            return dbContext.Clients.ToList();
        }

        [HttpPost]
        public ActionResult<Client> PostClient(Client client)
        {
            if (!ModelState.IsValid) 
                return BadRequest(ModelState);

            dbContext.Clients.Add(client);
            dbContext.SaveChanges();
            return Ok(client);
        }
    }
}
