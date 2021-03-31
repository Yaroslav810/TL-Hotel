using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public class BusinessRoom : IRoom
    {
        private int _price;
        private int _square;
        private List<string> _facilities;

        public BusinessRoom(int price, int square, List<string>? facilities)
        {
            _price = price;
            _square = square;
            _facilities = new List<string>();
            if (facilities != null)
            {
                _facilities.AddRange(facilities);
            }
        }

        public int Square
        {
            get
            {
                return _square;
            }

            set
            {
                _square = value;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public string Type
        {
            get
            {
                return "business";
            }
        }

        public void AddFacilities(List<string> facilities)
        {
            _facilities.AddRange(facilities);
        }

        public string GetFacilities()
        {
            string output = "";
            int count = _facilities.Count;

            foreach (string facilitie in _facilities)
            {
                output += "\"" + facilitie + "\"" + " ";
            }

            return output;
        }

        public override string ToString()
        {
            return $"Price: {_price}; Type: business; Facilities: { GetFacilities() }";
        }
    }
}
