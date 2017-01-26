using System;

namespace AOBMockService.WebAPI.ThirdParties
{
    public interface IGoogleMapService
    {
        string GetPredictionsJson(string callback);
        string GetGeocode(string callback);
        string GetCountyValidation();
    }
}
