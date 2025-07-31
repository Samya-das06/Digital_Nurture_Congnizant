import React, { useState } from 'react';
import CurrencyConvertor from './CurrencyConvertor.js';

function App() {
  const [count, setCount] = useState(0);

  const incrementValue = () => {
    setCount(prev => prev + 1);
    sayHello();
  };

  const sayHello = () => {
    alert('Hello! This is an increment message.');
  };

  const decrementValue = () => {
    setCount(prev => prev - 1);
  };

  const sayWelcome = (message) => {
    alert(message);
  };

  const handleSyntheticClick = () => {
    alert('I was clicked');
  };

  return (
    <div style={{ padding: 20, fontFamily: 'Arial' }}>
      <h2>Event Examples App</h2>

      <h3>Counter: {count}</h3>
      <button onClick={incrementValue}>Increment</button>
      <button onClick={decrementValue}>Decrement</button>

      <br /><br />

      <button onClick={() => sayWelcome("Welcome!")}>Say Welcome</button>

      <br /><br />

      <button onClick={handleSyntheticClick}>Click Me</button>

      <hr />

      <CurrencyConvertor />
    </div>
  );
}

export default App;
