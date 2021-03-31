using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public class Hotel : IHotel
    {
        private string _name;
        private List<IRoom> _rooms;
        private List<IGuest> _guests;

        public Hotel(string Name)
        {
            _name = Name;
            _rooms = new List<IRoom>();
            _guests = new List<IGuest>();
        }

        public void AddGuest( IGuest guest )
        {
            _guests.Add(guest);
        }

        public void AddGuests( List<IGuest> guests )
        {
            _guests.AddRange(guests);
        }

        public void ShowGuests()
        {
            foreach (IGuest guest in _guests)
            {
                Console.WriteLine(guest.ToString());
            }
        }

        public void EvictGuest(IGuest guest)
        {
            if (!_guests.Remove(guest))
            {
                Console.WriteLine("An error occurred while checking out the guest!");
            }
        }

        public void AddRooms( List<IRoom> rooms )
        {
            _rooms.AddRange( rooms );
        }

        public void ShowRooms()
        {
            foreach ( IRoom room in _rooms )
            {
                Console.WriteLine(room.ToString());
            }
        }
    }
}
