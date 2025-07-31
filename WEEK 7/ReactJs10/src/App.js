// src/App.js
import React from 'react';
import './App.css';

import image1 from './Screenshot 2025-07-13 125438.png';
import image2 from './Screenshot 2025-07-13 125304.png';
import image3 from './Screenshot 2025-07-13 125137.png';

function App() {
  const officeSpaces = [
    {
      id: 1,
      name: 'Corporate World',
      rent: 70000,
      address: 'Tower A, MG Road, Delhi',
      image: image1
    },
    {
      id: 2,
      name: 'TechGig Hub',
      rent: 72000,
      address: 'Tech Road, Pune',
      image: image2
    },
    {
      id: 3,
      name: 'SunView Park',
      rent: 74000,
      address: 'Bandra West, Mumbai',
      image: image3
    }
  ];

  return (
    <div className="App">
      <h1 className="page-title">Office Space Rental App</h1>

      <div className="office-list">
        {officeSpaces.map((office) => (
          <div key={office.id} className="office-card">
            <img src={office.image} alt={office.name} className="office-img" />
            <h2>{office.name}</h2>
            <p><strong>Address:</strong> {office.address}</p>
            <p>
              <strong>Rent:</strong>{' '}
              <span className={office.rent < 70000 ? 'rent-low' : 'rent-high'}>
                ₹{office.rent.toLocaleString()}
              </span>
            </p>
          </div>
        ))}
      </div>
    </div>
  );
}

export default App;
