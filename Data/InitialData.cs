namespace pokedata.Data
{
    using Microsoft.EntityFrameworkCore;
    using pokedata.Enums;
    using pokedata.Model;

    public class InitialData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new pokedataContext(
                               serviceProvider.GetRequiredService<DbContextOptions<pokedataContext>>());

            if (context == null || context.Sim == null)
            {
                throw new NullReferenceException("Null pokedataContext or Sim DbSet");
            }

            if (context.Sim.Any())
            {
                return; // Database seeded with initial data
            }

            context.Sim.AddRange(
                new Sim
                {
                    Title = "Ms",
                    FirstName = "Bella",
                    LastName = "Goth",
                    Sex = 'F',
                    DateOfBirth = new DateTime(2000, 2, 4),
                    AddressLine1 = "165 Sim Lane",
                    AddressLine2 = "Downtown",
                    PostalCode = "DT91KF",
                    HealthCondition = HealthConditions.DiabetesType1
                },
                new Sim
                {
                    Title = "Mr",
                    FirstName = "Puck",
                    LastName = "Summerdream",
                    Sex = 'M',
                    DateOfBirth = new DateTime(2005, 6, 17),
                    AddressLine1 = "71 Bard Boulevard",
                    AddressLine2 = "Veronaville",
                    PostalCode = "VV65SD",
                    HealthCondition = HealthConditions.ADHD
                },
                new Sim
                {
                    Title = "Ms",
                    FirstName = "Daisy",
                    LastName = "Greenman",
                    Sex = 'F',
                    DateOfBirth = new DateTime(2017, 3, 2),
                    AddressLine1 = "110 Old Farm Road",
                    AddressLine2 = "Riverblossom Hills",
                    PostalCode = "RB27JQ",
                    HealthCondition = HealthConditions.Asthma
                },
                new Sim
                {
                    Title = "Mr",
                    FirstName = "John",
                    LastName = "Mole",
                    Sex = 'M',
                    DateOfBirth = new DateTime(1988, 2, 26),
                    AddressLine1 = "153 Main Street",
                    AddressLine2 = "Desiderata Valley",
                    PostalCode = "DV18FL",
                    HealthCondition = HealthConditions.MultipleSclerosis
                },
                new Sim
                {
                    Title = "Ms",
                    FirstName = "Sofia",
                    LastName = "Baldwin",
                    Sex = 'F',
                    DateOfBirth = new DateTime(2008, 8, 26),
                    AddressLine1 = "2 Tech Terrace",
                    AddressLine2 = "Belladonna Cove",
                    PostalCode = "BC59PR",
                    HealthCondition = HealthConditions.Epilepsy
                }
            );
        }
    }
}
