using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS2018WFA
{
    class Writer
    {
        public delegate void viewEventHandler(object sender, string textToWrite);
        public viewEventHandler FlushText;

        public void doSomathing()
        {
            //devo flushare il testo in qualche modo
            for (int i = 0; i < 10; i++)
                FlushText(this, $"i={i}");
        }
    }
}
