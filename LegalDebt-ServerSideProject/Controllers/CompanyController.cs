using LegalDebt_ServerSideProject.Data;
using LegalDebt_ServerSideProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace LegalDebt_ServerSideProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        private readonly LegalDebtDbContext dbContext;

        public CompanyController(LegalDebtDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Company>> GetCompanies()
        {
            return dbContext.Companies.ToList();
        }

        [HttpPost]
        public ActionResult<Company> PostCompany(Company company)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            dbContext.Companies.Add(company);
            dbContext.SaveChanges();
            return Ok(company);
        }
    }
}
