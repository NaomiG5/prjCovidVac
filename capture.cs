using System;

namespace prjCovidVac {
    class capture {

        private static string iD;
        private static string medicalAid;
        private static string name;
        private static string surname;
        private static string refDr;
        private static char bloodType;
        private static string allergies;
        private static bool hadcovid;
        private static string vac;

        info i = new info();

        public void getHospitalInfo()
        {
            
            Console.Write("Enter the hospital Name: ");
            i.Hospital_Name = Console.ReadLine();
            Console.Write("Enter the hospital Address: ");
            i.Address = Console.ReadLine();
            Console.Write("Enter the hospital Type(Private or Public): ");
            i.Type = Console.ReadLine();
            Console.Write("Enter the hospital Province: ");
            i.Province = Console.ReadLine();
            Console.Clear();
        }

        public void getPatientInfo()
        {
            Console.WriteLine("Enter the number of patients: ");
            i.setArray(Convert.ToInt32(Console.ReadLine()));

            for (int x = 0; x < i.size(); x++)
            {
                Console.Clear();
                Console.Write("Patient: " + (x + 1) + " Enter Patient ID: ");
                iD = Console.ReadLine();

                Console.Write("Patient: " + (x + 1) + " Enter Patient Medical Aid: ");
                medicalAid = Console.ReadLine();

                Console.Write("Patient: " + (x + 1) + " Enter Patient Name: ");
                name = Console.ReadLine();

                Console.Write("Patient: " + (x + 1) + " Enter Patient Surname: ");
                surname = Console.ReadLine();

                Console.Write("Patient: " + (x + 1) + " Enter Refering Doctor: ");
                refDr = Console.ReadLine();

                Console.Write("Patient: " + (x + 1) + " Enter Patient Blood Type: ");
                bloodType = Convert.ToChar(Console.ReadLine());

                Console.Write("Patient: " + (x + 1) + " Enter Patient Allergies: ");
                allergies = Console.ReadLine();

                Console.Write("Patient: " + (x + 1) + " Enter if Patient had covid (true/false: ");
                hadcovid = Convert.ToBoolean(Console.ReadLine());

                Console.Write("Patient: " + (x + 1) + " Enter Patient Vaccine: ");
                vac = Console.ReadLine();

                i.addPerson(iD, medicalAid, name, surname, refDr, bloodType, allergies, hadcovid, vac);
            }


        }

    }
}
