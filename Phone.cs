using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneInfo
{
    internal class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;

        // Place for your 3 constructors
        public Phone()
        {
            Company = "unknown";
            Model = "unknown";
            ReleaseDay = "unknown";
        }
        public Phone(string company,string model)
        {
            Company = company;
            Model = model;
            ReleaseDay = "unknown";
        }
        public Phone(string company,string model,string releaseDay)
        {
            Company = company;
            Model = model;
            ReleaseDay = releaseDay;
        }
        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
            //Console.WriteLine($"It is {Model} created by {Company}. It was released {ReleaseDay}.");
        }
    }
}
