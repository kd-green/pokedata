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
                    DateOfBirth = new DateOnly(2000, 2, 4),
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
                    DateOfBirth = new DateOnly(2005, 6, 17),
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
                    DateOfBirth = new DateOnly(2017, 3, 2),
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
                    DateOfBirth = new DateOnly(1988, 2, 26),
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
                    DateOfBirth = new DateOnly(2008, 8, 26),
                    AddressLine1 = "2 Tech Terrace",
                    AddressLine2 = "Belladonna Cove",
                    PostalCode = "BC59PR",
                    HealthCondition = HealthConditions.Epilepsy
                },
                new Sim
                {
                    Title = "Ms",
                    FirstName = "Lilith",
                    LastName = "Pleasant",
                    Sex = 'F',
                    DateOfBirth = new DateOnly(2004, 1, 5),
                    AddressLine1 = "215 Sim Lane",
                    AddressLine2 = "Pleasantview",
                    PostalCode = "PV17WO",
                    HealthCondition = HealthConditions.Endometriosis
                },
                new Sim
                {
                    Title = "Mr",
                    FirstName = "Joshua",
                    LastName = "Ruben",
                    Sex = 'M',
                    DateOfBirth = new DateOnly(2002, 11, 19),
                    AddressLine1 = "20 Peanut Street",
                    AddressLine2 = "Sim State",
                    PostalCode = "SS86VC",
                    HealthCondition = HealthConditions.MultipleSclerosis
                },
                new Sim
                {
                    Title = "Mr",
                    FirstName = "Frances",
                    LastName = "Worthington",
                    Sex = 'F',
                    DateOfBirth = new DateOnly(2003, 12, 14),
                    AddressLine1 = "134 Aridestra Drive",
                    AddressLine2 = "La Fiesta",
                    PostalCode = "LF32LU",
                    HealthCondition = HealthConditions.AtrialFibrillation
                },
                new Sim
                {
                    Title = "Ms",
                    FirstName = "Roxie",
                    LastName = "Sharpe",
                    Sex = 'F',
                    DateOfBirth = new DateOnly(2002, 5, 30),
                    AddressLine1 = "58 Focaccia Place",
                    AddressLine2 = "Le Tour",
                    PostalCode = "LT41GK",
                    HealthCondition = HealthConditions.Epilepsy
                },
                new Sim
                {
                    Title = "Ms",
                    FirstName = "Jill",
                    LastName = "Smith",
                    Sex = 'F',
                    DateOfBirth = new DateOnly(2008, 9, 12),
                    AddressLine1 = "101 Road to Nowhere",
                    AddressLine2 = "Strangetown",
                    PostalCode = "ST25MC",
                    HealthCondition = HealthConditions.Asthma
                }
            );

        context.SaveChanges();
        }
    }
}
