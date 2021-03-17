using System;

namespace prjCovidVac {
    class capture {
        
        public void getInfo() {
            info i = new info();
            Console.Clear();

            for(int x = 0; x < i.size(); x++) {
                Console.WriteLine( "Please enter the Hospital Name "+(x+1)+" :");
            }

            Console.WriteLine("Hospital name");
            i.Hospital_Name = Console.ReadLine();
            Console.WriteLine(i.Hospital_Name);
        }
        
    }
}
