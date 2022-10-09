using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers.FileHelper
{
    public interface IFileHelper
    {
        string Upload(List<IFormFile> formFile, string root);
        void Delete(string filePath);
        string Update(List<IFormFile> formFile, string filePath, string root);
    }
}
