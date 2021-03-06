﻿using Microsoft.EntityFrameworkCore;
using SyntacsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyntacsApp.Data
{
    public class SyntacsDbContext : DbContext
    {
        public SyntacsDbContext(DbContextOptions<SyntacsDbContext> options) : base(options)
        {

        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
