using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelpDeskAPINew.Data;
using HelpDeskAPINew.Models;

namespace HelpDeskAPINew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketChatsController : ControllerBase
    {
        private readonly DataContext _context;

        public TicketChatsController(DataContext context)
        {
            _context = context;
        }
        // GET: api/TicketChats/ticketId/1
        [HttpGet("ticketId/{ticketId}")]
        public async Task<ActionResult<IEnumerable<TicketChat>>> GetTicketChatsByTicketId(int ticketId)
        {
            var ticketChats = await _context.TicketChats
                                .Where(t => t.TicketId == ticketId).ToListAsync();
            if (ticketChats == null)
            {
                return NotFound();
            }

            return ticketChats;
        }
        // GET: api/TicketChats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketChat>>> GetTicketChats()
        {
          if (_context.TicketChats == null)
          {
              return NotFound();
          }
            return await _context.TicketChats.ToListAsync();
        }

        // GET: api/TicketChats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketChat>> GetTicketChat(int id)
        {
          if (_context.TicketChats == null)
          {
              return NotFound();
          }
            var ticketChat = await _context.TicketChats.FindAsync(id);

            if (ticketChat == null)
            {
                return NotFound();
            }

            return ticketChat;
        }

        // PUT: api/TicketChats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicketChat(int id, TicketChat ticketChat)
        {
            if (id != ticketChat.Id)
            {
                return BadRequest();
            }

            _context.Entry(ticketChat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketChatExists(id))
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

        // POST: api/TicketChats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TicketChat>> PostTicketChat(TicketChat ticketChat)
        {
          if (_context.TicketChats == null)
          {
              return Problem("Entity set 'DataContext.TicketChats'  is null.");
          }
            _context.TicketChats.Add(ticketChat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTicketChat", new { id = ticketChat.Id }, ticketChat);
        }

        // DELETE: api/TicketChats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicketChat(int id)
        {
            if (_context.TicketChats == null)
            {
                return NotFound();
            }
            var ticketChat = await _context.TicketChats.FindAsync(id);
            if (ticketChat == null)
            {
                return NotFound();
            }

            _context.TicketChats.Remove(ticketChat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TicketChatExists(int id)
        {
            return (_context.TicketChats?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
