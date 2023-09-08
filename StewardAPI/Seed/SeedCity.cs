using Microsoft.EntityFrameworkCore;
using Model;

namespace StewardAPI.Seed
{
    public class SeedCity
    {
        private readonly ModelBuilder modelBuilder;


        public SeedCity(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<CityList>().HasData(
            new CityList() { CityName = "Adoni", Id = 1 },
            new CityList() { CityName = "Amaravati", Id = 2 },
            new CityList() { CityName = "Anantapur", Id = 3 },
            new CityList() { CityName = "Chandragiri", Id = 4 },
            new CityList() { CityName = "Chittoor", Id = 5 },
            new CityList() { CityName = "Dowlaiswaram", Id = 6 },
            new CityList() { CityName = "Panipat", Id = 7 },
            new CityList() { CityName = "Karnal", Id = 8 },
            new CityList() { CityName = "Delhi", Id = 9 },
            new CityList() { CityName = "Nainital", Id = 10 });


        }
    }
}
