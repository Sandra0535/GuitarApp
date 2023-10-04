using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    internal class Guitar
    {
        private string _serialNumber;
        private double _price;
        private GuitarSpec Spec;
        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            _serialNumber = serialNumber;
            _price = price;
            Spec = spec;
        }
        public string GetSerialNumber()
        {
            return _serialNumber;
        }
        public double GetPrice()
        {
            return _price;
        }
        public void SetPrice(float newPrice)
        {
            _price = newPrice;
        }
        public GuitarSpec GetSpec()
        {
            return Spec;
        }
    }
}
