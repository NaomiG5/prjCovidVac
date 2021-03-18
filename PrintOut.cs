using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCovidVac
{
    class PrintOut
    {
        info i = new info();
        public void printHospital()
        {
            Console.Clear();
            Console.WriteLine("HOSPITAL REPORT\n---------------------------------------------------");
            Console.WriteLine("Hospital Name: \t\t\t" + i.Hospital_Name) ;
            Console.WriteLine("Hospital Address: \t\t" + i.Address);
            Console.WriteLine("Hospital Type: \t\t\t" + i.Type);
            Console.WriteLine("Hospital Province: \t\t" + i.Province);
            Console.WriteLine("---------------------------------------------------");
        }
        public void printPatients()
        {
            for (int x = 0; x < i.size(); x++)
            {
                Console.WriteLine("PATIENT: " + (x + 1) + " REPORT\n---------------------------------------------------");
                Console.WriteLine("Patient ID: \t\t\t" + i.getIDNumber(x));
                Console.WriteLine("Patient Name: \t\t\t" + i.getName(x));
                Console.WriteLine("Patient Surname: \t\t" + i.getSurname(x));
                Console.WriteLine("Patient Referring Doctor: \t" + i.getRefDr(x));
                Console.WriteLine("Patient Blood Type: \t\t" + i.getBloodType(x));
                Console.WriteLine("Patient Allergies: \t\t" + i.getAllergies(x));
                Console.WriteLine("Patient had Covid?: \t\t" + i.getCovidPostive(x));
                Console.WriteLine("Patient Vaccine: \t\t" + i.getVaccine(x));
                Console.WriteLine("---------------------------------------------------");
            }
        }
    }
}
