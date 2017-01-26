using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOBMockService.WebAPI.Quote.Models.Address
{
    public class Metadata
    {
        string CreationDateTime { get; set; }
        string RequestId { get; set; }
        string Channel { get; set; }
        string Message { get; set; }
    }
}
