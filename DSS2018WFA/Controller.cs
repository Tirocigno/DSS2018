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
    {
            string dbpath = @"C:\Users\feden\Documents\Visual Studio 2015\Projects\DSS2018WFA\testDb.sqlite";
            Console.WriteLine(dbpath);
            string connString = @"Data Source=" + dbpath + "; Version=3";
            M.doSomathing();
            M.readClients(connString);
    }

    public void searchClients(string dbPath)
        {
            Console.WriteLine(dbPath);
            string connString = @"Data Source=" + dbPath + "; Version=3";
            M.readClients(connString);
        }
    }
}

