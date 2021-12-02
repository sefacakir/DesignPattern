using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class SaveToCDAdapter : ISave
    {
        public void Save(string source, string savedFile)
        {
            SaveToCD saveToCD = new SaveToCD();
            saveToCD.SavetoCd(source,savedFile);
        }
    }
}
