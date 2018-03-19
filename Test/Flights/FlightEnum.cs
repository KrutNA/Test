using System;
using System.Collections;
using System.Collections.Generic;

namespace Test.Flights
{
    class FlightEnum : IEnumerator<Flight>
    {
        public List<Flight> flights;

        private int position;

        object IEnumerator.Current => Current;
        public Flight Current
        {
            get
            {
                try
                {
                    return flights[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public FlightEnum(List<Flight> flights)
        {
            position = -1;
            this.flights = flights;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            position++;
            return (position < flights.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
