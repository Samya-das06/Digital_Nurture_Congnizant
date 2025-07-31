import React from 'react';

const flights = [
  { id: 1, from: 'Kolkata', to: 'Bhubaneshwar', time: '10:00 AM', price: 2000 },
  { id: 2, from: 'Kolkata', to: 'Chennai', time: '3:00 PM', price: 4500 },
  { id: 3, from: 'Kolkata', to: 'Pune', time: '7:00 PM', price: 3500 },
];

function FlightList({ showBooking }) {
  return (
    <div>
      <h2>Available Flights</h2>
      <table border="1" align="center">
        <thead>
          <tr>
            <th>From</th>
            <th>To</th>
            <th>Time</th>
            <th>Price</th>
            {showBooking && <th>Action</th>}
          </tr>
        </thead>
        <tbody>
          {flights.map(flight => (
            <tr key={flight.id}>
              <td>{flight.from}</td>
              <td>{flight.to}</td>
              <td>{flight.time}</td>
              <td>₹{flight.price}</td>
              {showBooking && (
                <td>
                  <button onClick={() => alert("Ticket Booked!")}>Book</button>
                </td>
              )}
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default FlightList;
