using System;
using System.Collections.Generic;
using HotelLib;

namespace SimpleHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IGuest> guests = new List<IGuest>()
            {
                new Guest( "Ivan", "ivan@mail.ru", "+7 980 000 00 00" ),
                new Guest( "Yaroslav", "yaroslav@mail.ru", "+7 981 111 11 11" )
            };

            List<IRoom> rooms = new List<IRoom>()
            {
                new Room( "standart", 600, 18, new List<string>() { 
                    "TV", 
                    "Wi-Fi", 
                    "Air conditioning" 
                } ),
                new Room( "standart", 400, 18, null ),
                new Room( "business", 800, 24, new List<string>() { 
                    "TV set", 
                    "Orthopedic mattress", 
                    "Wi-Fi", 
                    "Phone", 
                    "Bathrobe" 
                } ),
                new Room( "suite", 1200, 48, new List<string>() { 
                    "Upholstered furniture (sofa and 2 armchairs)", 
                    "Fridge", 
                    "Upholstered armchair",
                    "Spacious wardrobe",
                    "Telephone",
                    "LCD TV"
                } )
            };

            IHotel hotel = new Hotel( "Space" );
            hotel.AddRooms( rooms );
            rooms[1].Square = 22;
            hotel.ShowRooms();

            Console.WriteLine("-----   -----   -----");

            hotel.AddGuests( guests );
            hotel.ShowGuests();

            Console.WriteLine("-----   -----   -----");

            hotel.EvictGuest( guests[0] );
            hotel.ShowGuests();
        }
    }
}
