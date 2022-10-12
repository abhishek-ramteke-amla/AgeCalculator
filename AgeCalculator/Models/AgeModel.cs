namespace AgeCalculator.Models
{
    public class AgeModel
    {
        public DateTime BirthDate { get; set; }
        public DateTime CurrentDate { get; set; } = DateTime.Now;

        public string Message { get; set; } = string.Empty;
    }
}
