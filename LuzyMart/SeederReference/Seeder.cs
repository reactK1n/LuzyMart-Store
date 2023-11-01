using LuzyMart.Data;
using LuzyMart.Models.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace LuzyMart.SeederReference
{
    public static class Seeder
    {
        public static void SeedData(this IApplicationBuilder app)
        {
            var serviceScope = app.ApplicationServices.CreateScope();
            Seeding(serviceScope.ServiceProvider.GetRequiredService<MartDbContext>());
        }
        private static void Seeding(MartDbContext martDb)
        {

            string jsonString = File.ReadAllText("myData.json");
            
            var categories = JsonConvert.DeserializeObject<List<Category>>(jsonString);
            foreach (var myCategory in categories)
            {
                martDb.Add(myCategory);
            }
            martDb.SaveChanges();

        }
    }
}
