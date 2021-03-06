using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SurveillanceCamWinApp.Data
{
    public class DbCtx : DbContext
    {
        public DbSet<Models.AppSetting> AppSettings { get; set; }

        public DbSet<Models.Camera> Cameras { get; set; }

        public DbSet<Models.DateDir> DateDirs { get; set; }

        public DbSet<Models.ImageFile> ImageFiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Data/test.db");
        }
    }
}
