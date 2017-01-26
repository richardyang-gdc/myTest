using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOBMockService.WebAPI.Quote.Services
{
    public class HistoryService:BaseQuoteService
    {
        public string GetRatingHistoryQuestions()
        {
            return GetFileText("ratingHistoryQuestions");
        }
    }
}
