namespace pokedata.Model
{
    using pokedata.Enums;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Sim
    {
        public int Id { get; set; }

        [MaxLength(12)]
        public string? Title { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-zà-üÀ-Ü\s'-]*$")]
        [MaxLength(26)] // In line with HMRC name length limits
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-zà-üÀ-Ü\s'-]*$")]
        [MaxLength(26)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(1)]
        [RegularExpression(@"[MF]")]
        public char Sex { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-z0-9'\s-]*")]
        public string AddressLine1 { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-z0-9'\s-]*")]
        public string AddressLine2 { get; set; }

        [Required]
        [RegularExpression(@"([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9][A-Za-z]?))))\s?[0-9][A-Za-z]{2})")]
        public string PostalCode { get; set; }

        [Required]
        public HealthConditions HealthCondition { get; set; }
    }
}
