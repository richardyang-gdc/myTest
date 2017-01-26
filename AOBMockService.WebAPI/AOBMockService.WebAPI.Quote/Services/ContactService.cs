using AOBMockService.WebAPI.Quote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOBMockService.WebAPI.Quote.Services
{
    public class ContactService : BaseQuoteService
    {
        public Contact GetContact()
        {
            return new Contact()
            {
                FirstName = "Richard",
                LastName = "Yang",
                Address = "Hangzhou, China Test33"
            };
        }

        public string GetCreateContactResponse()
        {
            return GetFileText("createContact");
        }

        public string GetRetrieveQuoteResponse()
        {
            return GetFileText("retrieveQuote");
        }

        public string GetRatingContactQuestions()
        {
            return GetFileText("ratingContactQuestions");
        }
    }
}
