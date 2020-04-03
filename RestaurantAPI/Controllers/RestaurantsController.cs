using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Models;

namespace RestaurantAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RestaurantsController : ControllerBase
  {
    private RestaurantAPIContext _db;

    public RestaurantsController(RestaurantAPIContext db)
    {
      _db = db;
    }

    // GET api/restaurants
    // List all restaurants
    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> Get()
    {
      var query = _db.Restaurants.AsQueryable();
      return query.ToList();
    }

    // GET api/restaurants/5
    // Retrieve specific restaurant
    [HttpGet("{id}")]
    public ActionResult<Restaurant> Get(int id)
    {
      return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
    }

    // POST api/restaurants
    // Add new restaurant
    [HttpPost]
    public void Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }

    // PUT api/restaurants/8
    // Edit specific restaurant
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Restaurant restaurant)
    {
      restaurant.RestaurantId = id;
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
    }
  }
}