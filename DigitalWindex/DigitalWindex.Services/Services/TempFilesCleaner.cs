using System.IO;
using System.Linq;

namespace DigitalWindex.Services
{
    public class TempFilesCleaner
    {
        public (int FilesDeleted, int DirsDeleted) Clean(string folderPath)
        {
            var files = Directory.GetFiles(folderPath);
            int f = files.Count(f1 =>
            {
                try { File.Delete(f1); return true; }
                catch { return false; }
            });

            var dirs = Directory.GetDirectories(folderPath);
            int d = dirs.Count(d1 =>
            {
                try { Directory.Delete(d1, true); return true; }
                catch { return false; }
            });

            return (f, d);
        }
    }
}
