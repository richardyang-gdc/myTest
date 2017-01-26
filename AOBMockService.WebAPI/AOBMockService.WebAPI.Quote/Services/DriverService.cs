using AOBMockService.WebAPI.Quote.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOBMockService.WebAPI.Quote.Services
{
    public class DriverService : BaseQuoteService
    {
        public Driver GetDriver()
        {
            return new Driver()
            {
                Name = "Tom",
                Gender = "M",
                Age = "23"
            };
        }

        public string GetRatingDriverQuestions(dynamic obj)
        {
            string fileName;
            string email = obj.Email;
            string birthDateString = obj.BirthDate;
            DateTime birthDate;
            DateTime.TryParse(birthDateString, out birthDate);
            int age = DateTime.Now.Subtract(birthDate).Days / 365;

            if (email != "" && email != null)
            {
                fileName = "ratingDriverQuestionsMain";
            }
            else if (age < 20)
            {
                fileName = "ratingDriverQuestionsStudent";
            }
            else
            {
                fileName = "ratingDriverQuestionsOther";
            }

            return GetFileText(fileName);
        }
    }
}
