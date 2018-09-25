using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS2018WFA
{
    class Controller
    { Model M = new Model();
    public delegate void viewEventHandler(object sender, string textToWrite); // questo gestisce l'evento
    public event viewEventHandler FlushText; // questo genera l'evanto
    public Controller() { M.FlushText += controllerViewEventHandler; }
    private void controllerViewEventHandler(object sender, string textToWrite)
    { FlushText(this, textToWrite); }
    public void doSomething()
    { M.doSomathing(); }
}
}
