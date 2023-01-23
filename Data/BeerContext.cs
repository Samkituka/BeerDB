using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using BeerDB.Models;

namespace BeerDB.Data
{
    public class BeerContext : DbContext
    {

        public BeerContext ()
        {

        }

        public BeerContext(DbContextOptions <BeerContext>  options ) : base (options )
        {

        }

        public DbSet <Beer> Beers { get; set; } 

    }
}
