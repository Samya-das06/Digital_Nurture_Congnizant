import React, { useState } from 'react';

function CurrencyConvertor() {
  const [rupees, setRupees] = useState('');
  const [euros, setEuros] = useState('');

  const handleSubmit = () => {
    const rupeeValue = parseFloat(rupees);
    if (!isNaN(rupeeValue)) {
      const euroValue = (rupeeValue / 90).toFixed(2); 
      setEuros(euroValue);
    } else {
      alert("Please enter a valid number.");
    }
  };

  return (
    <div>
      <h3>Currency Converter (INR to Euro)</h3>
      <input
        type="text"
        value={rupees}
        onChange={(e) => setRupees(e.target.value)}
        placeholder="Enter amount in INR"
      />
      <button onClick={handleSubmit}>Convert</button>
      {euros && <p>Equivalent in Euro: €{euros}</p>}
    </div>
  );
}

export default CurrencyConvertor;
