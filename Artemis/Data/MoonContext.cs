using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoonData.Domain;
namespace Moon_Phase_App.Data
{
    public class MoonContext : DbContext
    {

        public DbSet<Moon> Moons { get; set; }
        public string DbPath { get; }

        public MoonContext() 
        {
            
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Moons.db");
         
           
        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source= {DbPath}");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Moon>().HasKey(m => new { m.ID,m.Year,m.Month,m.Day });
           
        }

    }
}
