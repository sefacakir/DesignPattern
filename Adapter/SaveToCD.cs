using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class SaveToCD
    {
        public void SavetoCd(string source, string savedFile)
        {
            Connect();
            SaveToCd();
            UnConnect();
        }
        private void Connect() { }
        private void UnConnect() { }
        private void SaveToCd() 
        {
           Console.WriteLine("Files from source saved to CD");
        }
    }
}
