using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Windex_UI_Tests_Kaavya
{
    public interface IProcessRunner_Angelo
    {
        Task<int> Run(string fileName, string arguments);
    }

}
