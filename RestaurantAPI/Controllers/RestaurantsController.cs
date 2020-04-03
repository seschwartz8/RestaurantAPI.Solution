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
    // Lists all restaurants
    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> Get()
    {
      var query = _db.Restaurants.AsQueryable();
      return query.ToList();
    }

    // // GET api/photos/count
    // [HttpGet("count")]
    // public ActionResult<int> CountPhotos(string title, string tag, string url, string userName)
    // {
    //   var query = _db.Photos.AsQueryable();

    //   if (tag != null)
    //   {
    //     query = query.Where(photo => photo.SearchForTag(tag) == true);
    //   }

    //   if (title != null)
    //   {
    //     query = query.Where(entry => entry.Title == title);
    //   }

    //   if (url != null)
    //   {
    //     query = query.Where(entry => entry.Url == url);
    //   }

    //   if (userName != null)
    //   {
    //     query = query.Where(entry => entry.UserName == userName);
    //   }

    //   return query.ToList().Count();
    // }

    // // POST api/photos
    // [HttpPost]
    // public void Post([FromBody] Photo photo)
    // {
    //   _db.Photos.Add(photo);
    //   _db.SaveChanges();
    // }

    // // GET api/photos/5
    // [HttpGet("{id}")]
    // public ActionResult<Photo> Get(int id)
    // {
    //   return _db.Photos.FirstOrDefault(entry => entry.PhotoId == id);
    // }

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