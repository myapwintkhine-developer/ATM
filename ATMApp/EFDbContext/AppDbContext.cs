﻿using ATMApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ATMApp.EFDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
