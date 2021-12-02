using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface ISave
    {
        public void Save(string source, string savedFile);
    }
}
