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

    // // PUT api/photos/8
    // [HttpPut("{id}")]
    // public void Put(int id, [FromBody] Photo photo)
    // {
    //   photo.PhotoId = id;
    //   _db.Entry(photo).State = EntityState.Modified;
    //   _db.SaveChanges();
    // }

    // // Delete api/photos/5
    // [HttpDelete("{id}")]
    // public void Delete(int id)
    // {
    //   var photoToDelete = _db.Photos.FirstOrDefault(entry => entry.PhotoId == id);
    //   _db.Photos.Remove(photoToDelete);
    //   _db.SaveChanges();
    // }
  }
}