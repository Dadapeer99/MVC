﻿using Microsoft.EntityFrameworkCore;

namespace SimpleDb.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Precision(18, 2)] // Specify precision and scale
        public decimal Price { get; set; }
    }
}
