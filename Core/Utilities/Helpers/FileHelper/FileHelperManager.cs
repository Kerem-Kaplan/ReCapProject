using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Helpers.GuidHelper;
using Core.Utilities.Helpers.FileHelper;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string Update(List<IFormFile> formFile, string filePath, string root)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            return Upload(formFile, root);
        }

        public string Upload(List<IFormFile> formFile, string root)
        {
            StringBuilder builder = new StringBuilder();

            if (formFile.Count > 0)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }

                foreach (var item in formFile)
                {
                    var extension = Path.GetExtension(item.FileName);
                    string guid = Guid.NewGuid().ToString();
                    var path = guid + extension;

                    builder.Append(path + ";");
                    using FileStream fileStream = File.Create(root + path);
                    item.CopyTo(fileStream);
                    fileStream.Flush();
                }
            }

            return builder.ToString();
        }
    }
}
