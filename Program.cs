using System;
using System.Linq;

namespace PlaneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane("", "");
            plane.PrintAvailable();
        }

        internal enum SeatPosition
        {
            Aisle,
            Middle,
            Window
        }

        public struct Seat
        {
            public string SeatNumber { get; set; }
            public SeatPosition SeatPosition { get; set; }
            public bool IsAvailable { get; set; }
        }

        public class Plane
        {
            string _tailNumber;
            string _flightNumber;
            private Seat[,] Seats = new Seat[10, 6];

            public Plane(string tailNumber, string flightNumber)
            {
                this._tailNumber = tailNumber;
                this._flightNumber = flightNumber;

                for (int i = 0; i < this.Seats.GetLength(0); i++)
                {
                    for (int j = 0; j < this.Seats.GetLength(1); j++)
                    {
                        char letter = (char) (97 + j);
                        this.Seats[i, j].SeatNumber = $"{i + 1}{letter}";

                        if (j is 0 or 5)
                        {
                            this.Seats[i, j].SeatPosition = SeatPosition.Window;
                            this.Seats[i, j].IsAvailable = true;
                        }
                        else if (j is 1 or 4)
                        {
                            this.Seats[i, j].SeatPosition = SeatPosition.Middle;
                            this.Seats[i, j].IsAvailable = true;
                        }
                        else if (j is 2 or 3)
                        {
                            this.Seats[i, j].SeatPosition = SeatPosition.Aisle;
                            this.Seats[i, j].IsAvailable = false;
                        }
                    }
                }
            }

            public void PrintAvailable()
            {
                foreach (Seat seat in this.Seats)
                {
                    if (seat.IsAvailable)
                    {
                        Console.WriteLine(seat.SeatNumber + " - " + seat.SeatPosition);
                    }
                }
            }
        }
    }
}