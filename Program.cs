using System;

namespace PlaneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            for (var i = 0; i < plane.Seats.GetLength(0); i++){

                for (var j = 0; j < plane.Seats.GetLength(1); j++){
                    var letter = (char)(97 + j);
                    plane.Seats[i,j].seatNumber = $"{i+1}{letter}"; 
                }
            }
        }

        enum SeatPosition {
            Aisle,
            Middle,
            Window
        }

        public struct Seat {
            public string seatNumber;
            SeatPosition seatPosition;
            bool isAvailable;
        }

        public class Plane {
            public string tailNumber;
            public string flightNumber;
            public Seat[,] Seats = new Seat[10,6];
        }
    }
}
