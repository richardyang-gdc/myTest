using AOBMockService.WebAPI.Quote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOBMockService.WebAPI.Quote
{
    public interface IQuoteService
    {
        Contact GetContact();
        Driver GetDriver();

        string GetCreateContactResponse();
        string GetRetrieveQuoteResponse();
        string GetRatingContactQuestions();

        string GetVehicleLookup();
        string GetSelectedVehicle();
        string GetVehicles();
        string GetRatingVehicleQuestions(dynamic obj);

        string GetRatingDriverQuestions(dynamic obj);

        string GetRatingDriverAssignmentQuestions();

        string GetRatingHistoryQuestions();

        string GetRatingCoverageQuestions();
        string GetQuickPremium();
        string GetPremium();
        string GetLead();
        string GetRatingAdditionalInfoOneQuestions();
    }
}
