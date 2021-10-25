using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Models;
using System;
using System.Linq;

namespace Travel.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationsController : ControllerBase
  {
    private readonly TravelContext _db;

    public DestinationsController(TravelContext db)
    {
      _db = db;
    }
    
    // GET: api/Animals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Destination>>> Get(int rating)
    {
      var query = _db.Destinations.AsQueryable();

      if (rating != null)
      {
        query = query.Where(entry => entry.Rating == rating);
      }  
      return await query.ToListAsync();
    }

    // [HttpGet]
    // public async Task<ActionResult<IEnumerable<Destination>>> Get(string city)
    // {
    //   var query = _db.Destinations.AsQueryable();

    //   if (city != null)
    //   {
    //     query = query.Where(entry => entry.City == city);
    //   }  
    //   return await query.ToListAsync();
    // }


    [HttpGet("{id}")]
    public async Task<ActionResult<Destination>> GetDestination(int id)
    {
        var destination = await _db.Destinations.FindAsync(id);

        if (destination == null)
        {
            return NotFound();
        }

        return destination;
    }


    [HttpPost]
    public async Task<ActionResult<Destination>> Post(Destination destination)
    {
      _db.Destinations.Add(destination);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetDestination), new { id = destination.DestinationId }, destination);
    }
  }
}

