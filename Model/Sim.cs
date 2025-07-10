namespace pokedata.Model
{
    using pokedata.Enums;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Sim
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public char Sex { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string PostalCode { get; set; }

        public HealthConditions HealthCondition { get; set; }
    }
}
