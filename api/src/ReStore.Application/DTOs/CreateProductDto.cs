﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ReStore.Application.DTOs;

public class CreateProductDto
{
     [Required]
     public string Name { get; set; }

     [Required]
     public string Description { get; set; }

     [Required]
     [Range(100, Double.PositiveInfinity)]
     public long Price { get; set; }

     [Required]
     public IFormFile File { get; set; }

     //[Required]
     //public string Type { get; set; }

     [Required]
     public string Brand { get; set; }

     [Required]
     public string Color { get; set; }

     [Required]
     public string Category { get; set; }

     [Required]
     [Range(0, 200)]
     public int QuantityInStock { get; set; }
}
