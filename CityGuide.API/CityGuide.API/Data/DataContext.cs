using CityGuide.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        //Value sinifi ile veritabaninda ki Values tablosunun eşleştirilmesi.
        public DbSet<Value> Values { get; set; }
    }
}
