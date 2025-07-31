// IndianPlayers.js
import React from 'react';

const IndianPlayers = () => {
  
  const team = ['Kohli', 'Rohit', 'Gill', 'Pant', 'Dhoni', 'Jadeja', 'Ashwin', 'Bumrah'];
  const [p1, p2, p3, p4, p5, p6, p7, p8] = team;

  const oddTeam = [p1, p3, p5, p7];
  const evenTeam = [p2, p4, p6, p8];

  const T20players = ['Surya', 'Hardik', 'Iyer'];
  const RanjiTrophy = ['Pujara', 'Rahane', 'Unadkat'];
  const mergedPlayers = [...T20players, ...RanjiTrophy];

  return (
    <div>
      <h2>Odd Team Players</h2>
      <ul>
        {oddTeam.map((player, idx) => <li key={idx}>{player}</li>)}
      </ul>

      <h2>Even Team Players</h2>
      <ul>
        {evenTeam.map((player, idx) => <li key={idx}>{player}</li>)}
      </ul>

      <h2>Merged Players (T20 + Ranji)</h2>
      <ul>
        {mergedPlayers.map((player, idx) => <li key={idx}>{player}</li>)}
      </ul>
    </div>
  );
};

export default IndianPlayers;
