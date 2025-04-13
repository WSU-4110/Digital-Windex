using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWindexUI.Tests
{
    [CollectionDefinition("=Tests Collection", DisableParallelization = true)]
    public class TestsCollection
    {
        // Marking Log tests to be run in series, not parallel
    }
}
