namespace pokedata.Validation
{
    public class NameFilterValidation : INameFilterValidation
    {
        public bool IsValidName(string nameFilterQuery)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z\s'-]+$");
            return regex.IsMatch(nameFilterQuery);
        }
    }
}
