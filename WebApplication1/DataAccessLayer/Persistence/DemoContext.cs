using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Persistence
{
    public class DemoContext : DbContext
    {
        public DbSet<DemoEntity> DemoEntities { get; set; }

        public DbSet<StudentEntity> StudentEntities { get; set; }

        public DemoContext(DbContextOptions options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }
    }
}