﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G151210078.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace G151210078.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }

        public DbSet<Order> Orders { get; set; }
    }

}

