﻿using Microsoft.EntityFrameworkCore;
using REST_EF_06_Migrazioni.Models;

namespace REST_EF_06_Migrazioni.Context
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
        }

        public DbSet<Film> Pellicole { get; set; }

       
    }
}