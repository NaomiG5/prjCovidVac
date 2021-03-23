using System;

namespace prjCovidVac {
    class Program {
        static void Main(string[] args)
        {
            capture cp = new capture();
            info i = new info();
            PrintOut p = new PrintOut();
            cp.getInfo();
            p.print_Report();
          
        }
        
    }
}