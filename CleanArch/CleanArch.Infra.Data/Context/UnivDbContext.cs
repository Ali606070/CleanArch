﻿using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Context
{
    public class UnivDbContext:DbContext
    {
        public UnivDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Course> courses { get; set; }
    }
}
