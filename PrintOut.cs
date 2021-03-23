using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCovidVac
{
    class PrintOut
    {
        public void print_Report()
        {
            info i = new info();
            Console.Clear();

            Console.WriteLine("Covid-19 Vaccine");
            Console.WriteLine("******************************************");
            Console.WriteLine("General Information");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Hospital name: " + i.getHospital_Name());
            Console.WriteLine("Address: " + i.getAddress());
            Console.WriteLine("Public or Private: " + i.getType());
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Information on each patient: ");
            Console.WriteLine("------------------------------------------");

            for (int x = 0; x < i.size(); x++)
            {
                Console.WriteLine("ID Number: {0} " +
                    "\nMedical Aid: {1} " +
                    "\nName: {2} " +
                    "\nSurname: {3} " +
                    "\nRefering Dr: {4} " +
                    "\nAllergies: {5}" +
                    "\nHad Covid: {6}" +
                    "\nVaccine they are getting: {6}", i.getIDNumber(x), i.getMedicalAid(x), i.getName(x),
                    i.getSurname(x), i.getRefDr(x), i.getAllergies(x),
                    i.getCovidPostive(x), i.getVaccine(x));
                Console.WriteLine("###############################################################");
            }
            Console.ReadLine();
        }
    }
}

