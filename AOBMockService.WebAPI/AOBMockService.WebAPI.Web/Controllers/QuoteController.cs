using System;
using System.IO;
using System.Web.Http;
using System.Net.Http;
using AOBMockService.WebAPI.Quote;
using AOBMockService.WebAPI.Quote.Models;
using AOBMockService.WebAPI.Web.Models;
using AOBMockService.WebAPI.Web.Common;
using AOBMockService.WebAPI.ThirdParties;

namespace AOBMockService.WebAPI.Web.Controllers
{
    [RoutePrefix("api/Quote")]
    public class QuoteController: ApiController
    {
        private IQuoteService _quoteService = null;
        private IGoogleMapService _googleMapService = null;

        public QuoteController(IQuoteService quoteService, IGoogleMapService googleMapService): base()
        {
            if (quoteService == null)
            {
                throw new ArgumentNullException("quoteService");
            }

            _quoteService = quoteService;

            if (googleMapService == null)
            {
                throw new ArgumentNullException("googleMapService");
            }

            _googleMapService = googleMapService;
        }

        [HttpGet]
        [Route("Contact")]
        public JSendResponse<Contact> GetContact()
        {
            var contact = _quoteService.GetContact();
            return JSendResponse<Contact>.CreateSuccess(contact);
        }

        [HttpGet]
        [Route("Contact/{name}")]
        public JSendResponse<Contact> GetContact(string name)
        {
            var contact = _quoteService.GetContact();
            contact.FirstName = "this is parameter: " + name;
            return JSendResponse<Contact>.CreateSuccess(contact);
        }


        [HttpGet]
        [Route("Driver")]
        public JSendResponse<Driver> GetDriver()
        {
            var driver = _quoteService.GetDriver();
            return JSendResponse<Driver>.CreateSuccess(driver);
        }

        [HttpGet]
        [Route("GetPredictionsJson")]
        public HttpResponseMessage GetPredictionsJson(string callback)
        {
            var message = _googleMapService.GetPredictionsJson(callback);
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpGet]
        [Route("GetGeocode")]
        public HttpResponseMessage GetGeocode(string callback)
        {
            var message = _googleMapService.GetGeocode(callback);
            return JsonHelper.GetHttpResponseMessage(message);
        }
        [HttpPost]
        [Route("verify/address")]
        public HttpResponseMessage PostAddress()
        {
            var message = _googleMapService.GetCountyValidation();
            return JsonHelper.GetHttpResponseMessage(message);
        }


        [HttpPost]
        [Route("quote")]
        public HttpResponseMessage PostCreateContact()
        {
            var message = _quoteService.GetCreateContactResponse();
            return JsonHelper.GetHttpResponseMessage(message);
        }
        [HttpPut]
        [Route("quote")]
        public Object PutUpdateContact(dynamic obj)
        {
            return JSendResponse<Object>.CreateSuccess(obj).Data;
        }

        [HttpPost]
        [Route("retrieveQuote")]
        public HttpResponseMessage RetrieveQuote()
        {
            var message = _quoteService.GetRetrieveQuoteResponse();
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpGet]
        [Route("contact/{address}/{effectDate}")]
        public HttpResponseMessage GetRatingContactQuestions()
        {
            var message = _quoteService.GetRatingContactQuestions();
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpGet]
        [Route("Vehicle/{condition}/{address}/{effectDate}")]
        public HttpResponseMessage GetVehicleLookup()
        {
            var message = _quoteService.GetVehicleLookup();
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpGet]
        [Route("Vehicle/parts/{condition}/{address}/{effectDate}")]
        public HttpResponseMessage GetParts()
        {
            var message = _quoteService.GetSelectedVehicle();
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpGet]
        [Route("Vehicles/{condition}/{address}/{effectDate}")]
        public HttpResponseMessage Search()
        {
            var message = _quoteService.GetVehicles();
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpGet]
        [Route("vehicles/{address}/{effectDate}")]
        public HttpResponseMessage GetRatingVehicleQuestions(dynamic obj)
        {
            var message = _quoteService.GetRatingVehicleQuestions(obj);
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpPost]
        [Route("vehicles/{address}/{effectDate}")]
        public HttpResponseMessage PostRatingVehicleQuestions(dynamic obj)
        {
            var message = _quoteService.GetRatingVehicleQuestions(obj);
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpPost]
        [Route("drivers/{address}/{effectDate}")]
        public HttpResponseMessage PostRatingDriverQuestions(dynamic obj)
        {
            var message = _quoteService.GetRatingDriverQuestions(obj);
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpPost]
        [Route("driverassignment/{address}/{effectDate}")]
        public HttpResponseMessage PostRatingDriverAssignmentQuestions()
        {
            var message = _quoteService.GetRatingDriverAssignmentQuestions();
            return JsonHelper.GetHttpResponseMessage(message);
        }


        [HttpGet]
        [Route("history/{address}/{effectDate}")]
        public HttpResponseMessage PostRatingHistoryQuestions()
        {
            var message = _quoteService.GetRatingHistoryQuestions();
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpGet]
        [Route("coverage/{address}/{effectDate}")]
        public HttpResponseMessage GetRatingCoverageQuestions()
        {
            var message = _quoteService.GetRatingCoverageQuestions();
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpPost]
        [Route("quickpremium")]
        public HttpResponseMessage PostQuickPremium()
        {
            var message = _quoteService.GetQuickPremium();
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpPost]
        [Route("premium")]
        public HttpResponseMessage PostCustomPremium()
        {
            var message = _quoteService.GetPremium();
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpPost]
        [Route("lead")]
        public HttpResponseMessage PostLead()
        {
            var message = _quoteService.GetLead();
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpPost]
        [Route("additionalinfo1/{address}/{effectDate}")]
        public HttpResponseMessage PostRatingAdditonalInfoOneQuestions()
        {
            var message = _quoteService.GetRatingAdditionalInfoOneQuestions();
            return JsonHelper.GetHttpResponseMessage(message);
        }

        [HttpGet]
        [Route("additionalinfo1/{address}/{effectDate}")]
        public HttpResponseMessage GetRatingAdditonalInfoOneQuestions()
        {
            var message = _quoteService.GetRatingAdditionalInfoOneQuestions();
            return JsonHelper.GetHttpResponseMessage(message);
        }
    }
}