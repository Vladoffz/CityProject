using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Web.Entities;
using System.Configuration;
using Web.Models;

namespace Web.DAL.Impl
{
    public class WebContext : DbContext
    {

        public WebContext(DbContextOptions<WebContext> options) : base(options)
        { }

        public DbSet<Resident> Residents { get; set; }
        public DbSet<Flat> Flats { get; set; }
        public DbSet<ResidentOfFlat> ResidentsOfFlats { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ResidentDTO> ResidentDtos { get; set; }
    }
}
