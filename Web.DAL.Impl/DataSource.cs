using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Web.Entities;

namespace Web.DAL.Impl
{
    public static class DataSource
    {
        public static void Initialize(WebContext context)
        {

            context.Database.EnsureCreated();

            if (context.Residents.Any())
            {
                return;
            }

            var Countries = new Country[]
            {
            new Country{Name="Ukraine"},
            };
            foreach (Country C in Countries)
            {
                context.Countries.Add(C);
            }

            context.SaveChanges();

            var Cities = new City[]
            {
            new City{Name="Kyiv",CountryID=1},
            };
            foreach (City C in Cities)
            {
                context.Cities.Add(C);
            }
            context.SaveChanges();

            var Streets = new Street[]
            {
            new Street{Name="MilkyWay 1",CityID=1},
            new Street{Name="MiklyWay 2",CityID=1},

            };
            foreach (Street S in Streets)
            {
                context.Streets.Add(S);
            }
            context.SaveChanges();

            var Buildings = new Building[]
            {
            new Building{Number="1B",Coordinates="41.40338, 2.17403",StreetID=1},
            new Building{Number="1C",Coordinates="41.40338, 2.17403",StreetID=2},

            };
            foreach (Building B in Buildings)
            {
                context.Buildings.Add(B);
            }
            context.SaveChanges();

            var Flats = new Flat[]
            {
            new Flat{Number=21,Square=9, BuildingID=1},
            new Flat{Number=22,Square=18, BuildingID=1},
            new Flat{Number=23,Square=18, BuildingID=2},
            new Flat{Number=24,Square=9, BuildingID=2},
            new Flat{Number=25, Square=18,BuildingID=2},
            };
            foreach (Flat F in Flats)
            {
                context.Flats.Add(F);
            }
            context.SaveChanges();

            var Residents = new Resident[]
            {
            new Resident{FullName="Eugene Nine",DateOfBirth = new DateTime(1990, 02, 1)},
            new Resident{FullName="Carmeliya Pirson",DateOfBirth = new DateTime(1991, 03, 1)},
            new Resident{FullName="Zombie Zoe",DateOfBirth = new DateTime(1994, 02, 9)},
            new Resident{FullName="Rosetta Hizenberg",DateOfBirth = new DateTime(2000, 02, 1)},
            new Resident{FullName="Armaliya Quad",DateOfBirth = new DateTime(2020, 02, 1)},
            };
            foreach (Resident R in Residents)
            {
                context.Residents.Add(R);
            }
            context.SaveChanges();

            var ResidentsOfFlats = new ResidentOfFlat[]
            {
            new ResidentOfFlat{ResidentID=1,FlatID=1},
            new ResidentOfFlat{ResidentID=2,FlatID=2},
            new ResidentOfFlat{ResidentID=3,FlatID=3},
            new ResidentOfFlat{ResidentID=4,FlatID=4},
            new ResidentOfFlat{ResidentID=5,FlatID=5},
            };
            foreach (ResidentOfFlat RoF in ResidentsOfFlats)
            {
                context.ResidentsOfFlats.Add(RoF);
            }
            context.SaveChanges();







        }
    }
}
