using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public interface IRoom
    {
        int Square { get; set; }
        int Price { get; set; }
        string Type { get; }
        void AddFacilities( List<string> facilities );
        string GetFacilities();
    }
}
