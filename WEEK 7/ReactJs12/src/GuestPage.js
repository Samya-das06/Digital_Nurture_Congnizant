import React from 'react';
import FlightList from './FlightList';

function GuestPage() {
  return (
    <div>
      <h2> Please Sign up to Book Tickets</h2>
      <FlightList showBooking={false} />
    </div>
  );
}

export default GuestPage;
