using System;

namespace Test.Flights
{
    public class Flight : IEquatable<Flight>, IComparable<Flight>
    {
        public string FlightId { get; }

        public DateTime ArrivalTime { get; }
        public DateTime DepartureTime { get; }

        public string ArrivalPlace { get; }
        public string DeparturePlace { get; }

        public Flight(string id, DateTime arrTime, DateTime depTime, string arrPlace, string depPlace)
        {
            FlightId = id;
            ArrivalTime = arrTime;
            DepartureTime = depTime;
            ArrivalPlace = arrPlace;
            DeparturePlace = depPlace;
        }

        public bool Equals(Flight other)
        {
            return FlightId.CompareTo(other.FlightId) == 0;
        }

        public override string ToString()
        {
            return "Fligth ID: " + FlightId + "\nArrival time: " + ArrivalTime.ToString() + "\nDeparture time: " + DepartureTime.ToString();
        }

        public int CompareTo(Flight other)
        {
            if (DepartureTime < other.DepartureTime)
                return -1;
            else if (DepartureTime == other.DepartureTime)
                return 0;
            return 1;
        }
    }
}