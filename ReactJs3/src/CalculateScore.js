import  React from 'react';
export function CalculateScore(inputs) {
  let total = 0;

  inputs.forEach(value => {
    const num = parseFloat(value);
    if (!isNaN(num)) {
      total += num;
    }
  });

  const percentage = inputs.length > 0 ? (total / (inputs.length * 100)) * 100 : 0;

  return {
    total,
    percentage: percentage.toFixed(2)
  };
}