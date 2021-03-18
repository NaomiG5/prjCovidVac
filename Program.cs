using System;

namespace prjCovidVac {
    class Program {
        static void Main(string[] args) {

            capture cp = new capture();
            PrintOut p = new PrintOut();
            cp.getHospitalInfo();
            cp.getPatientInfo();
            p.printHospital();
            p.printPatients();
           ;
        }
        
    }
}
