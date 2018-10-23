﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WelfareDenmarkLiveMap.Models
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<ExerciseType> ExerciseTypes { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
