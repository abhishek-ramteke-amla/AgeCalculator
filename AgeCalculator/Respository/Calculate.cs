using AgeCalculator.Models;

namespace AgeCalculator.Respository
{
    public class Calculate
    {
        public AgeModel CalculateAge(AgeModel ageModel)
        {
            string age = string.Empty;
            string dateOfBirth = string.Empty;
            dateOfBirth = ageModel.CurrentDate.ToString("DD-MM-YYYY");
            string[] dates = dateOfBirth.Split("-");
            int currentDate = Convert.ToInt32(dates[0]);
            int currentMonth = Convert.ToInt32(dates[1]);
            int currentYear = Convert.ToInt32(dates[2]);

            if (currentDate == 0 || currentDate > 31)
            {
                return new AgeModel { Message = "Please Enter Valid Date" };
            }    
            else if((currentDate != 0 || currentDate < 31) && (currentMonth != 0 || currentMonth <= 12))
            {
                return new AgeModel { Message = "Please Enter Valid Month" };
            }
            return new AgeModel();
        }
    }
}
