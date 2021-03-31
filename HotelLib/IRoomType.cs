using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public interface IRoomType
    {
        string RoomType { get; }

        List<string> Additions { get; set; }
    }
}
