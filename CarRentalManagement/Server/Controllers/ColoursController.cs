using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        /*
        public ColoursController(ApplicationDbContext context)
        {
            _context = context;
        }
        */

        public ColoursController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Colours
        [HttpGet]
        /*
        public async Task<ActionResult<IEnumerable<Colour>>> GetColours()
        {
            return await _context.Colours.ToListAsync();
        }
        */
        public async Task<IActionResult> GetColours()
        {
            //return NotFound();
            var colour = await _unitOfWork.Colours.GetAll();
            return Ok(colour);
        }

        // GET: api/Colours/5
        /*
        public async Task<ActionResult<Colour>> GetColour(int id)
        {
            var Colour = await _context.Colours.FindAsync(id);

            if (Colour == null)
            {
                return NotFound();
            }

            return Colour;
        }
        */
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColour(int id)
        {
            var colour = await _unitOfWork.Colours.Get(q => q.Id == id);

            if (colour == null)
            {
                return NotFound();
            }

            return Ok(colour);
        }

        // PUT: api/Colours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        /*
        public async Task<IActionResult> PutColour(int id, Colour Colour)
        {
            if (id != Colour.Id)
            {
                return BadRequest();
            }

            _context.Entry(Colour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ColourExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        */
        public async Task<IActionResult> PutColour(int id, Colour colour)
        {
            if (id != colour.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Colours.Update(colour);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ColourExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Colours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        /*
        public async Task<ActionResult<Colour>> PostColour(Colour Colour)
        {
            _context.Colours.Add(Colour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetColour", new { id = Colour.Id }, Colour);
        }
        */
        public async Task<ActionResult<Colour>> PostColour(Colour colour)
        {
            await _unitOfWork.Colours.Insert(colour);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetColour", new { id = colour.Id }, colour);
        }

        // DELETE: api/Colours/5
        [HttpDelete("{id}")]
        /*
        public async Task<IActionResult> DeleteColour(int id)
        {
            var Colour = await _context.Colours.FindAsync(id);
            if (Colour == null)
            {
                return NotFound();
            }

            _context.Colours.Remove(Colour);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        */
        public async Task<IActionResult> DeleteColour(int id)
        {
            var colour = await _unitOfWork.Colours.Get(q => q.Id == id);
            if (colour == null)
            {
                return NotFound();
            }

            await _unitOfWork.Colours.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        /*
        private bool ColourExists(int id)
        {
            return _context.Colours.Any(e => e.Id == id);
        }
        */
        private async Task<bool> ColourExists(int id)
        {
            var colour = await _unitOfWork.Colours.Get(q => q.Id == id);
            return colour != null;
        }
    }
}
