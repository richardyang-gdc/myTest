using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOBMockService.WebAPI.Common
{
    public class FileReader
    {
        public static string GetFileText(string fullFileName)
        {
            //var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //var folderPath = Path.Combine(baseDirectory, "MockData");
            //var fullFileName = Path.Combine(folderPath, string.Format("{0}.json", fileName));
            return File.ReadAllText(fullFileName);
        }
    }
}
