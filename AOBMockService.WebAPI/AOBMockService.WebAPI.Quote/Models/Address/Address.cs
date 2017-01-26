using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOBMockService.WebAPI.Quote.Models.Address
{
    class Address
    {
        string Line1 { set; get; }
        string Line2 { set; get; }
        string City { set; get; }
        string State { set; get; }
        string Zip { set; get; }
        string Zip_4 { set; get; }
        string[] County { set; get; }
    }
}
