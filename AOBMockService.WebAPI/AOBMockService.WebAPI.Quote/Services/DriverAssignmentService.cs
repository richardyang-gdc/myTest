using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOBMockService.WebAPI.Quote.Services
{
    public class DriverAssignmentService:BaseQuoteService
    {
        public string GetDriverAssignmentQuestions()
        {
            return GetFileText("ratingDriverAssignmentQuestions");
        }
    }
}
