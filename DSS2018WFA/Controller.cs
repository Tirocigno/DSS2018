using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS2018WFA
{
    class Controller
    { Writer W = new Writer();
    public delegate void viewEventHandler(object sender, string textToWrite); // questo gestisce l'evento
    public event viewEventHandler FlushText; // questo genera l'evanto
    public Controller() { W.FlushText += controllerViewEventHandler; }
    private void controllerViewEventHandler(object sender, string textToWrite)
    { FlushText(this, textToWrite); }
    public void doSomething()
    { W.doSomathing(); }
}
}
