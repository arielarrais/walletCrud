using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wallet.Web.Context;
using Wallet.Web.Shared.Models;

namespace Wallet.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarteiraController : ControllerBase
    {
        private readonly AppDbContext context;
        public CarteiraController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Carteira>>> Get()
        {
            return await context.Carteiras.AsNoTracking().ToListAsync();
        }

        [HttpGet("{id}", Name = "Carteira")]
        public async Task<ActionResult<Carteira>> Get(int id)
        {
            var carteira = await context.Carteiras.FirstOrDefaultAsync(x => x.Id == id);

            if (carteira is null)
                return NotFound($"Carteira com {id} não encontrada");

            return Ok(carteira);
        }

        [HttpPost]
        public async Task<ActionResult<Carteira>> Post(Carteira carteira)
        {
            context.Add(carteira);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("GetCarteira", new { id = carteira.Id }, carteira);
        }

        [HttpPut]
        public async Task<ActionResult<Carteira>> Put(Carteira carteira)
        {
            context.Entry(carteira).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(carteira);
        }

        [HttpDelete]
        public async Task<ActionResult<Carteira>> Delete(int id)
        {
            var carteira = new Carteira { Id = id };
            context.Remove(carteira);
            await context.SaveChangesAsync();
            return Ok(carteira);
        }
    }
}
