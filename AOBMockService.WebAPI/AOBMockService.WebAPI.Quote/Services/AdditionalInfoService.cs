using AOBMockService.WebAPI.Quote.Models;
using System;

namespace AOBMockService.WebAPI.Quote.Services
{
    public class AdditionalInfoService : BaseQuoteService
    {
        public string GetRatingAdditionalInfoOneQuestions()
        {
            return GetFileText("ratingAdditionalInfoOneQuestions");
        }
    }
}
