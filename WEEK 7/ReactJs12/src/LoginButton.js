import React from 'react';

function LoginButton({ isLoggedIn, onLogin, onLogout }) {
  return (
    <div style={{ margin: '20px' }}>
      {isLoggedIn ? (
        <button onClick={onLogout}>Logout</button>
      ) : (
        <button onClick={onLogin}>Login</button>
      )}
    </div>
  );
}

export default LoginButton;
