using System;

namespace PlaneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        enum SeatPosition {
            Aisle,
            Middle,
            Window
        }

        public struct Seat {
            string seatNumber;
            SeatPosition seatPosition;
            bool isAvailable;
        }

        public class Plane {
            string tailNumber;
            string flightNumber;
            Seat[,] Seats = new Seat[10,6];
        }
    }
}
