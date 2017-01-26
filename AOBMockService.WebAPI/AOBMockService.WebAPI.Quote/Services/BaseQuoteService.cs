using AOBMockService.WebAPI.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOBMockService.WebAPI.Quote.Services
{
    public class BaseQuoteService
    {
        public string GetFileText(string fileName)
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var folderPath = Path.Combine(baseDirectory, "../AOBMockService.WebAPI.Quote/MockData");
            var fullFileName = Path.Combine(folderPath, string.Format("{0}.json", fileName));
            return FileReader.GetFileText(fullFileName);
        }
    }
}
