using System;

namespace prjCovidVac {
    class info {
        //Special student variables
        private static int iSizeArray = 0;
        private static int iCounter = 0;


        private static String strHospital_Name;
        private static String strAddress;
        private static bool bType; //privat or public hospital
        private static char cProvince;

        public string Hospital_Name {get => strHospital_Name; set => Hospital_Name = value;}
        public string Address{get => strAddress; set => Address = value;}
        public Boolean Type{get => bType; set => Type = value;}
        public char Province{get => cProvince; set => Province = value;}

        private static String[] ID_Number;
        private static String[] MedicalAid;
        private static String[] Name;
        private static String[] Surname;
        private static String[] RefDr;
        private static char[] BloodType;
        private static String[] Allergies;
        private static Boolean[] CovidPostive;
        private static String[] Vaccine;

        public void setArray(int num) {
            ID_Number = new string[num];
            MedicalAid = new string[num];
            Name = new string[num];
            Surname = new string[num];
            RefDr = new string[num];
            BloodType = new char[num];
            Allergies = new string[num];
            CovidPostive = new Boolean[num];
            Vaccine = new string[num];

            iSizeArray = num;

        }

        public void addPerson(String strID, String strMedic, String strName,
            String strSurname,
            String strRefDr, Char cBloodType,
            String strAllergies, Boolean bCovid, String strVac)
        {

            ID_Number[iCounter] = strID;
            MedicalAid[iCounter] = strMedic;
            Name[iCounter] = strName;
            Surname[iCounter] = strSurname;
            RefDr[iCounter] = strRefDr;
            BloodType[iCounter] = cBloodType;
            Allergies[iCounter] = strAllergies;
            CovidPostive[iCounter] = bCovid;
            Vaccine[iCounter] = strVac;

            iCounter++;
        }
        public int size() {
            return iSizeArray;
        }
    }
}

