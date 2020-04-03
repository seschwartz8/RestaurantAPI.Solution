using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }

    [StringLength(100)]
    [Required]
    public string Name { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public int Rating { get; set; }
  }
}