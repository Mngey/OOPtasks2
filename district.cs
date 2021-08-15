using System;

namespace OOPtasks
{
    public class District
    {
        private string title, city;
        private int districtID, numberOfOfficers;
 
        Officer[] officersInDistrict;
        private int lastIndexOfficer = -1;

        public District() { }

        public District(string title, string city, int districtID, int numberOfOfficers)
        {
            this.title = title;
            this.city = city;
            this.districtID = districtID;
            this.numberOfOfficers = numberOfOfficers;
            this.officersInDistrict = new Officer[numberOfOfficers];
        }
        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }

        public string City
        {
            get { return city; }
            set { this.city = value; }
        }

        public int DistrictID
        {
            get { return districtID; }
            set { this.districtID = value; }
        }

        public int NumberOfOfficers
        {
            get { return numberOfOfficers; }
            set { this.numberOfOfficers = value; }
        }

        public void addOfficerToDistrict(Officer officer)
        {
            if (lastIndexOfficer == this.officersInDistrict.Length - 1)
            {
                Console.WriteLine("No more officers can be added");
                return;
            }

            lastIndexOfficer++;
            this.officersInDistrict[lastIndexOfficer] = officer;

        }

        public void removeOfficerFromDistrict(Officer officer)
        {
            int position = -1;
            foreach (Officer officerInDistrict in officersInDistrict)
            {
                position++;
                if (officerInDistrict == officer)
                {
                    if (position != this.officersInDistrict.Length - 1)
                        Array.Copy(officersInDistrict, position + 1,
                         officersInDistrict, position, officersInDistrict.Length - position - 1);///shifting to right

                    this.officersInDistrict[this.lastIndexOfficer] = null;
                    this.lastIndexOfficer--;
                    return;
                }
            }
            Console.WriteLine("Officer does not exist in the district");
        }

        public int getNumberOfOfficerInDistrict()
        {
            int count = 0;
            foreach (Officer officer in this.officersInDistrict)
            {
                
                if (officer == null)
                    break;
                else
                    count++;
            }
            return count;

        }

  

        public override string ToString()
        {
            return "Title : " + this.title + "\n" +
           "City : " + this.city + "\n" +
           "District ID : " + this.districtID + "\n" +
           "Number of officers : " + getNumberOfOfficerInDistrict() + "\n";


        }
    }
  

}


