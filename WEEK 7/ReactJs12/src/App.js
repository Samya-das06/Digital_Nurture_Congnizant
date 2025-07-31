import React, { useState } from 'react';
import GuestPage from './GuestPage';
import UserPage from './UserPage';
import LoginButton from './LoginButton';

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLogin = () => setIsLoggedIn(true);
  const handleLogout = () => setIsLoggedIn(false);

  return (
    <div style={{ textAlign: 'center' }}>
      <h1>Welcome to Flight Ticket Booking App</h1>
      <LoginButton
        isLoggedIn={isLoggedIn}
        onLogin={handleLogin}
        onLogout={handleLogout}
      />
      {isLoggedIn ? <UserPage /> : <GuestPage />}
    </div>
  );
}

export default App;
