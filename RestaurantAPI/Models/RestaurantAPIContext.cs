using Microsoft.EntityFrameworkCore;

namespace RestaurantAPI.Models
{
  public class RestaurantAPIContext : DbContext
  {
    public RestaurantAPIContext(DbContextOptions<RestaurantAPIContext> options) : base(options) { }

    public DbSet<Restaurant> Restaurants { get; set; }
  }
}