using Back_end.Services.Interfaces;
using System.IO;

namespace Back_end.Services
{
    public class FileService : IFileService
    {
        public string ReadFile(string path, string template)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                template = reader.ReadToEnd();
            }

            return template;
        }
    }
}
