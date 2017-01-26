using System;
using AOBMockService.WebAPI.Quote.Models;
using AOBMockService.WebAPI.Quote.Services;

namespace AOBMockService.WebAPI.Quote
{
    public class QuoteService : IQuoteService
    {
        ContactService _contactService = new ContactService();
        DriverService _driverService = new DriverService();
        VehicleService _vehicleService = new VehicleService();
        DriverAssignmentService _driverAssignmentService=new DriverAssignmentService();
        HistoryService _historyService=new HistoryService();
        CoverageService _coverageService = new CoverageService();
        AdditionalInfoService _additionalInfoService = new AdditionalInfoService();
        public Contact GetContact()
        {
            return _contactService.GetContact();
        }

        public string GetCreateContactResponse()
        {
            return _contactService.GetCreateContactResponse();
        }

        public string GetRetrieveQuoteResponse()
        {
            return _contactService.GetRetrieveQuoteResponse();
        }

        public string GetRatingContactQuestions()
        {
            return _contactService.GetRatingContactQuestions();
        }

        public Driver GetDriver()
        {
            return _driverService.GetDriver();
        }

        public string GetVehicleLookup()
        {
            return _vehicleService.GetVehicleLookup();
        }

        public string GetSelectedVehicle()
        {
            return _vehicleService.GetSelectedVehicle();
        }

        public string GetVehicles()
        {
            return _vehicleService.GetVehicles();
        }

        public string GetRatingVehicleQuestions(dynamic obj)
        {
            return _vehicleService.GetRatingVehicleQuestions(obj);
        }
        
        public string GetRatingDriverQuestions(dynamic obj)
        {
            return _driverService.GetRatingDriverQuestions(obj);
        }

        public string GetRatingDriverAssignmentQuestions()
        {
            return _driverAssignmentService.GetDriverAssignmentQuestions();
        }

        public string GetRatingHistoryQuestions()
        {
            return _historyService.GetRatingHistoryQuestions();
        }

        public string GetRatingCoverageQuestions()
        {
            return _coverageService.GetRatingCoverageQuestions();
        }

        public string GetQuickPremium()
        {
            return _coverageService.GetQuickPremium();
        }

        public string GetPremium()
        {
            return _coverageService.GetPremium();
        }

        public string GetLead()
        {
            return _coverageService.GetLead();
        }

        public string GetRatingAdditionalInfoOneQuestions()
        {
            return _additionalInfoService.GetRatingAdditionalInfoOneQuestions();
        }
    }
}
