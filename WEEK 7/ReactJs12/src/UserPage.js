import React from 'react';
import FlightList from './FlightList';

function UserPage() {
  return (
    <div>
      <h2>Welcome Back </h2>
      <h2>Book Your Tickets</h2>
      <FlightList showBooking={true} />
    </div>
  );
}

export default UserPage;
