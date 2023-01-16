using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace Back_end.Helpers
{
    public static class Helper
    {
        public static bool CheckFileType(this IFormFile file, string type)
        {
            return file.ContentType.Contains(type);
        }

        public static bool CheckFileSize(this IFormFile file, long size)
        {
            return (file.Length / 1024) < size;
        }

        public static string GetFilePath(string root, string folder, string fileName)
        {
            return Path.Combine(root, folder, fileName);
        }

        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
        }

        public static async Task SaveFile(string path, IFormFile photo)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await photo.CopyToAsync(stream);
            }
        }
    }
}