﻿using System.Threading.Tasks;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        /*
        public BookingsController(ApplicationDbContext context)
        {
            _context = context;
        }
        */

        public BookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Bookings
        [HttpGet]
        /*
        public async Task<ActionResult<IEnumerable<Booking>>> GetBookings()
        {
            return await _context.Bookings.ToListAsync();
        }
        */
        public async Task<IActionResult> GetBookings()
        {
            var bookings = await _unitOfWork.Bookings.GetAll(includes: q => q.Include(x => x.Vehicle).Include(x => x.Customer));
            return Ok(bookings);
        }

        // GET: api/Bookings/5
        [HttpGet("{id}")]
        /*
        public async Task<ActionResult<Booking>> GetBooking(int id)
        {
            var Booking = await _context.Bookings.FindAsync(id);

            if (Booking == null)
            {
                return NotFound();
            }

            return Booking;
        }
        */
        public async Task<IActionResult> GetBooking(int id)
        {
            var bookings = await _unitOfWork.Bookings.Get(q => q.Id == id);

            if (bookings == null)
            {
                return NotFound();
            }

            return Ok(bookings);
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        /*
        public async Task<IActionResult> PutBooking(int id, Booking Booking)
        {
            if (id != Booking.Id)
            {
                return BadRequest();
            }

            _context.Entry(Booking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingExists(id))
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
        public async Task<IActionResult> PutBooking(int id, Booking booking)
        {
            if (id != booking.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Bookings.Update(booking);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BookingExists(id))
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

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        /*
        public async Task<ActionResult<Booking>> PostBooking(Booking Booking)
        {
            _context.Bookings.Add(Booking);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBooking", new { id = Booking.Id }, Booking);
        }
        */
        public async Task<ActionResult<Booking>> PostBooking(Booking booking)
        {
            await _unitOfWork.Bookings.Insert(booking);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBooking", new { id = booking.Id }, booking);
        }

        // DELETE: api/Bookings/5
        [HttpDelete("{id}")]
        /*
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var Booking = await _context.Bookings.FindAsync(id);
            if (Booking == null)
            {
                return NotFound();
            }

            _context.Bookings.Remove(Booking);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        */
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            await _unitOfWork.Bookings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        /*
        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
        */
        private async Task<bool> BookingExists(int id)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
            return booking != null;
        }
    }
}
