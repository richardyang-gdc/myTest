﻿using AOBMockService.WebAPI.Quote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOBMockService.WebAPI.Quote.Services
{
    public class VehicleService : BaseQuoteService
    {
        //public VehicleLookup GetVehicleLookup()
        //{
        //    return new VehicleLookup()
        //    {
        //        OutVehcde = "SCBGR3ZA",
        //        year = "2012",
        //        OutActivto = "99/99/9999",
        //        OutEffectdte = "12/22/2012",
        //        OutMakecode = "BENT",
        //        OutMakenum = "0047",
        //        OutMakename = "BENTLEY",
        //        OutSeriesnum = "0019",
        //        OutSeriesname = "CONTINENTAL GTC CONV 4WD",
        //        OutModelnum = "0000",
        //        OutModelname = "",
        //        OutModel = "CONTINENTAL GTC",
        //        OutMvvehtyp = "REGL",
        //        OutEnginename = "12-FI 6.0L T/C",
        //        OutTransmission = "",
        //        OutCylinders = "2",
        //        OutDisplacement = "6000",
        //        OutTonnage = "",
        //        OutIncompind = "N",
        //        OutBodystyle = "2 DOOR",
        //        OutDrivetype = "4WD",
        //        OutMvsizename = "VERY LARGE",
        //        OutLength = "189.2",
        //        OutWidth = " 76.5",
        //        OutHeight = " 55.2",
        //        OutGrayMarketVin = "",
        //        OutUtilind = "N",
        //        OutAcceptind = "",
        //        OutMvvsrsym = "38",
        //        OutEvrcode = "",
        //        OutValidVin = "Y"
        //    };
        //}

        public string GetRatingVehicleQuestions(dynamic obj)
        {
            string fileName;

            if(obj.Vin=="")
            {
                fileName = "ratingVehicleQuestionsMain";
            }
            else
            {
                fileName = "ratingVehicleQuestionsOther";
            }

            return GetFileText(fileName);
        }

        public string GetVehicleLookup()
        {
            return GetFileText("vehicleLookup");
        }

        public string GetSelectedVehicle()
        {
            return GetFileText("selectedVehicleData");
        }

        public string GetVehicles()
        {
            return GetFileText("vehiclesData");
        }
    }
}
