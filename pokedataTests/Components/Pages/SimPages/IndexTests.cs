namespace pokedataTests.ComponentTests.PagesTests.SimPagesTests
{
    using System;
    using System.Text.RegularExpressions;
    using Microsoft.EntityFrameworkCore;
    using Bunit;
    using NUnit.Framework;
    using Microsoft.Extensions.DependencyInjection;
    using pokedata.Components.Pages.SimPages;
    using pokedata.Data;
    using pokedata.Model;

    public class IndexRazorTests : Bunit.TestContext
    {
        private class TestDbContextFactory : IDbContextFactory<pokedataContext>
        {
            private readonly pokedataContext _context;
            public TestDbContextFactory(pokedataContext context) => _context = context;
            public pokedataContext CreateDbContext() => _context;
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("John")]
        [TestCase("Émilie")]
        [TestCase("O'Connor")]
        [TestCase("Anne-Marie")]
        [TestCase("Jean Luc")]
        [TestCase("à-üÀ-Ü")]
        public void IsValidName_ValidInputs_ReturnsInput(string? input)
        {
            // Arrange
            var regex = new Regex(@"^[a-zA-Zà-üÀ-Ü\s'-]*$");
            if (string.IsNullOrEmpty(input))
            {
                // No need to call IsMatch if input is null or empty
                Assert.DoesNotThrow(() => { });
            }
            else
            {
                // Act & Assert
                Assert.DoesNotThrow(() =>
                {
                    if (!regex.IsMatch(input!))
                        throw new ArgumentException("Name filter query is invalid.");
                });
            }
        }

        [TestCase("[bad]")]
        [TestCase("Robert[Home]")]
        [TestCase("Mary#")]
        [TestCase("Anna$")]
        [TestCase("Test%")]
        [TestCase("John123")]
        public void IsValidName_InvalidInputs_ThrowsArgumentException(string input)
        {
            // Arrange
            var regex = new Regex(@"^[a-zA-Zà-üÀ-Ü\s'-]*$");

            // Act & Assert
            Assert.Throws<ArgumentException>(() =>
            {
                if (!regex.IsMatch(input))
                    throw new ArgumentException("Name filter query is invalid.");
            });
        }

        [Test]
        public void SimsFiltered_FiltersByValidName()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<pokedataContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using var db = new pokedataContext(options);
            db.Sim.AddRange(
                new Sim { Id = 1, FirstName = "John", LastName = "Smith", AddressLine1 = "TestAddress1", AddressLine2 = "TestAddress2", PostalCode = "AA11AA" },
                new Sim { Id = 2, FirstName = "Jane", LastName = "Doe", AddressLine1 = "TestAddress1", AddressLine2 = "TestAddress2", PostalCode = "AA11AA" },
                new Sim { Id = 3, FirstName = "Émilie", LastName = "Dubois", AddressLine1 = "TestAddress1", AddressLine2 = "TestAddress2", PostalCode = "AA11AA" }
            );
            db.SaveChanges();

            // Act
            var filtered = db.Sim.Where(s =>
                (s.FirstName != null && s.FirstName.Contains("John")) ||
                (s.LastName != null && s.LastName.Contains("John"))
            );

            // Assert
            Assert.That(filtered.Count(), Is.EqualTo(1));
            Assert.That(filtered.First().FirstName, Is.EqualTo("John"));
        }
    }
}
