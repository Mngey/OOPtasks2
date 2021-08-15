using System;
using System.Collections;

namespace OOPtasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Officer officer1 = new Officer();
            officer1.setCrimesSolved(10);
            officer1.setName("Jack");
            officer1.setSurname("Tall");
            officer1.setOfficerId(833232);
            // Console.WriteLine(officer1 + "\n");// the method ToString will be called

            Officer officer2 = new Officer();
            officer2.setCrimesSolved(60);
            officer2.setName("Thom");
            officer2.setSurname("Ricchy");
            officer2.setOfficerId(9374232);
            // Console.WriteLine(officer2 + "\n");

            Officer officer3 = new Officer("John", "Oliverio", 8723232, 38);
            // Console.WriteLine(officer3 + "\n");

            Officer officer4 = new Officer("Dart", "Fooling", 34564576, 22);
            // Console.WriteLine(officer4 + "\n");

            Officer officer5 = new Officer("Leo", "Cart", 334534, 27);
            Officer officer6 = new Officer("Anthony", "Capullo", 12345, 33);
            Officer officer7 = new Officer("Brad", "Snowden", 235235, 21);

            District district1 = new District("LA District", "Los Angeles", 1234, 3);
            district1.addOfficerToDistrict(officer1);
            district1.addOfficerToDistrict(officer2);
            district1.addOfficerToDistrict(officer3);

            District district2 = new District("NY District", "New York", 4321, 4);
            district2.addOfficerToDistrict(officer4);
            district2.addOfficerToDistrict(officer5);
            district2.addOfficerToDistrict(officer6);
            district2.addOfficerToDistrict(officer7);

            Console.WriteLine(district1 + "\n");
            Console.WriteLine(district2 + "\n");

            district2.removeOfficerFromDistrict(officer5);

            Console.WriteLine("Average level in District 1: " + district1.calculateAvgLevelInDistrict() + " and average level in District 2: " + district2.calculateAvgLevelInDistrict());

            ArrayList Districts = new ArrayList();
            Districts.Add(district1);
            Districts.Add(district2);
            int countBothDistricts = district1.getNumberOfOfficerInDistrict() + district2.getNumberOfOfficerInDistrict();
            Console.WriteLine("Two districts have " + countBothDistricts + " officers");
            float avgLevelOfDistricts = district1.calculateAvgLevelInDistrict() + district2.calculateAvgLevelInDistrict();
            Console.WriteLine("The average level of both districts is " + avgLevelOfDistricts);

            float avgLevel1 = district1.calculateAvgLevelInDistrict();
            float avgLevel2 = district2.calculateAvgLevelInDistrict();
            if (avgLevel1 > avgLevel2)
                Console.WriteLine("The average level of District 1 is better that of District 2");
            else if (avgLevel1 == avgLevel2)
                Console.WriteLine("The average level of both districts is the same");
            else
                Console.WriteLine("The average level of District 2 is better that of District 1");

            Districts.Remove(district1);
            Console.WriteLine(officer2);
        }


    }
}


