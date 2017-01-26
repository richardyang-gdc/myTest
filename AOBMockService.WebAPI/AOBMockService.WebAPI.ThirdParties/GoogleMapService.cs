using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOBMockService.WebAPI.ThirdParties;

namespace AOBMockService.WebAPI.ThirdParties
{
    public class GoogleMapService:IGoogleMapService
    {
        public string GetPredictionsJson(string callback)
        {
            var currentRunPath = AppDomain.CurrentDomain.BaseDirectory;
            var folderPath = Path.Combine(currentRunPath, "../AOBMockService.WebAPI.ThirdParties/MockData/GoogleService");
            var fullFileName = Path.Combine(folderPath, "GetPredictionsJson.js");

            var message = string.Format("/**/{0} && {1} {2}",callback,callback,File.ReadAllText(fullFileName));
            
            return message;
        }

        public string GetGeocode(string callback)
        {
            var currentRunPath = AppDomain.CurrentDomain.BaseDirectory;
            var folderPath = Path.Combine(Directory.GetParent(currentRunPath).Parent.FullName, "AOBMockService.WebAPI.ThirdParties\\MockData\\GoogleService");
            var fullFileName = Path.Combine(folderPath, "GetGeocode.js");

            var message = string.Format("/**/{0} && {1} {2}", callback, callback, File.ReadAllText(fullFileName));

            return message;
        }

        public string GetCountyValidation()
        {
            var currentRunPath = AppDomain.CurrentDomain.BaseDirectory;
            var folderPath = Path.Combine(currentRunPath, "../AOBMockService.WebAPI.ThirdParties/MockData/GoogleService");
            var fullFileName = Path.Combine(folderPath, "validateCounty.json");

            return File.ReadAllText(fullFileName);
        }
    }
}
