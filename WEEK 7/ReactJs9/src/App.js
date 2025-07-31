// App.js
import React from 'react';
import ListOfPlayer from './ListOfPlayer';
import IndianPlayer from './IndianPlayer';

function App() {
  const flag = false; 

  return (
    <div className="App">
      <h1>🏏 Indian Cricket Dashboard</h1>
      {flag ? <ListOfPlayer /> : <IndianPlayer />}
    </div>
  );
}

export default App;
