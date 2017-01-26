using AOBMockService.WebAPI.Quote.Models;
using System;

namespace AOBMockService.WebAPI.Quote.Services
{
    public class CoverageService : BaseQuoteService
    {
        public string GetRatingCoverageQuestions()
        {
            return GetFileText("ratingCoverageQuestions");
        }

        public string GetQuickPremium()
        {
            return GetFileText("quickPremium");
        }

        public string GetPremium()
        {
            return GetFileText("premium");
        }

        public string GetLead()
        {
            return GetFileText("lead");
        }
    }
}
