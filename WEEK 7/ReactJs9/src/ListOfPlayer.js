// ListofPlayers.js
import React from 'react';

const ListofPlayers = () => {
  const players = [
    { name: 'Virat Kohli', score: 85 },
    { name: 'Rohit Sharma', score: 95 },
    { name: 'Shubman Gill', score: 65 },
    { name: 'KL Rahul', score: 70 },
    { name: 'Hardik Pandya', score: 60 },
    { name: 'Ravindra Jadeja', score: 45 },
    { name: 'R Ashwin', score: 88 },
    { name: 'Bumrah', score: 92 },
    { name: 'Shami', score: 73 },
    { name: 'Surya Yadav', score: 55 },
    { name: 'Ishan Kishan', score: 78 }
  ];

  
  const lowScorers = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>All Players</h2>
      {players.map((player, idx) => (
        <p key={idx}>{player.name} - {player.score}</p>
      ))}

      <h3>Players with Score below 70</h3>
      {lowScorers.map((player, idx) => (
        <p key={idx}>{player.name} - {player.score}</p>
      ))}
    </div>
  );
};

export default ListofPlayers;
