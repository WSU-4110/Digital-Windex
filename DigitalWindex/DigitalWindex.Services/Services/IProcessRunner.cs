using System.Threading.Tasks;

namespace DigitalWindex.Services
{
    public interface IProcessRunner
    {
        Task<int> Run(string fileName, string arguments);
    }
}
