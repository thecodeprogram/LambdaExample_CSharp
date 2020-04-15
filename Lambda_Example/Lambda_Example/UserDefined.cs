using System;
using System.Collections.Generic;

namespace Lambda_Example
{
    class Aircraft
    {
        public string Brand;
        public string MajorModel;
        public string MinorModel;
        public bool isInService;

        public Aircraft(string _brand, string _major, string _minor, bool _isInService)
        {
            Brand = _brand;
            MajorModel = _major;
            MinorModel = _minor;
            isInService = _isInService;
        }
    }

    class UserDefined
    {
        public List<Aircraft> aircrafts;

        public UserDefined()
        {
            aircrafts = new List<Aircraft>()
            {
                new Aircraft("Airbus", "A330", "300", true),
                new Aircraft("Boeing", "777", "300ER", true),
                new Aircraft("Boeing", "707", "10", false)
            };
            listAllAircrafts();
            listAircraftsInService();
        }

        private void listAllAircrafts()
        {
            //Here first we print all aircrafts which are inside the list.
            Console.WriteLine(Environment.NewLine + "All Aircraft List : ");
            for (int i = 0; i < this.aircrafts.Count; i++)
            {
                Console.WriteLine(this.aircrafts[i].Brand + " " +
                    this.aircrafts[i].MajorModel + " " +
                    this.aircrafts[i].MinorModel + " " +
                    this.aircrafts[i].isInService);
            }
        }

        private void listAircraftsInService()
        {
            //Here are going to make a statement to specify the in service aircrafts.
            //We use here the class which defined by the user.
            Console.WriteLine(Environment.NewLine + "All aircrafts which are in service : ");
            List<Aircraft> aircraftInService = aircrafts.FindAll(x => (x.isInService) == true);
            foreach (var item in aircraftInService)
            {
                Console.WriteLine(item.Brand + " " +
                    item.MajorModel + " " +
                    item.MinorModel + " " +
                    item.isInService);
            }
        }
    }
}
