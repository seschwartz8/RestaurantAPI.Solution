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
    public ActionResult<IEnumerable<Restaurant>> Get(string name, int rating, int page, int size)
    {
      var query = _db.Restaurants.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (rating > 0)
      {
        query = query.Where(entry => entry.Rating == rating);
      }

      // Pagination
      int maxPageSize = 50; // max of 50 restaurants per page
      int pageSize = 20; //defaults to 20 restaurants per page

      int pageNumber = (page > 0) ? page : 1; //defaults to page 1
      if (size > 0)
      {
        pageSize = (size > maxPageSize) ? maxPageSize : size;
      }

      return query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
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

    // Delete api/restaurants/5
    // Delete specific restaurant
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var restaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
      _db.Restaurants.Remove(restaurantToDelete);
      _db.SaveChanges();
    }
  }
}