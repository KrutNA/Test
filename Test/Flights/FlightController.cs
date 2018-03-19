using System.Collections;
using System.Collections.Generic;

namespace Test.Flights
{
    class FlightController : IEnumerable<Flight>
    {
        private List<Flight> flights;

        public FlightController(List<Flight> flights)
        {
            this.flights = flights;
        }

        public void Add(Flight flight)
        {
            flights.Add(flight);
        }

        public bool Delete(Flight flight)
        {
            return flights.Remove(flight);
        }

        public Flight Find(string id)
        {
            foreach (Flight flight in flights)
                if (flight.FlightId.CompareTo(id) == 0)
                    return flight;
            return null;
        }

        public void Sort()
        {
            flights.Sort();
        }

        public IEnumerator<Flight> GetEnumerator()
        {
            return new FlightEnum(flights);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
