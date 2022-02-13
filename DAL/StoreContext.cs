﻿using FreshFruitsStore.Models;
using System.Data.Entity;
namespace FreshFruitsStore.DAL
{
    public class StoreContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        
    }
}