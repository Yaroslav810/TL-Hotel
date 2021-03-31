using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public interface IHotel
    {
        void AddGuest( IGuest guest );
        void AddGuests( List<IGuest> guests );
        void ShowGuests();
        void EvictGuest( IGuest guest );
        void AddRooms( List<IRoom> rooms );
        void ShowRooms();
    }
}
