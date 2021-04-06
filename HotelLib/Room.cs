using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public class Room : IRoom
    {
        private int _price;
        private int _square;
        private string _type;
        private List<string> _facilities;

        public Room(string type, int price, int square, List<string>? facilities)
        {
            _price = price;
            _square = square;
            _type = type;
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
                return "suite";
            }
        }

        public void AddFacilities(List<string> facilities)
        {
            _facilities.AddRange(facilities);
        }

        public string? GetFacilities()
        {
            string output = "";

            foreach (string facilitie in _facilities)
            {
                output += "\"" + facilitie + "\"" + " ";
            }

            return (output == "") ? null : output;
        }

        public override string ToString()
        {
            string? facilities = GetFacilities();
            return $"Price: {_price}; Type: {_type}({_square} m^2); Facilities: " + ( facilities ?? "not specified" );
        }
    }
}
