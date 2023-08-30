using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeParking.Models
{
    public class Car
    {
        public int Weight { get; set; }
        public string? RegistrationNumber { get; set; }
        public Car(int weight, string registrationNumber)
        {
            Weight = weight;
            RegistrationNumber = registrationNumber;
        }
    }
}
