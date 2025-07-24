// src/App.js
import React, { useState } from 'react';
import { CalculateScore } from './CalculateScore';

function App() {
  const [student, setStudent] = useState({
    name: '',
    school: '',
    rollNo: '',
    dob: '',
    scores: ['', '', '', ''], // 4 subjects
  });

  const [result, setResult] = useState(null);

  const handleChange = (e, index = null) => {
    const { name, value } = e.target;
    if (index !== null) {
      const updatedScores = [...student.scores];
      updatedScores[index] = value;
      setStudent(prev => ({ ...prev, scores: updatedScores }));
    } else {
      setStudent(prev => ({ ...prev, [name]: value }));
    }
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    const { total, percentage } = CalculateScore(student.scores);
    setResult({ total, percentage });
  };

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      <h2 style={{ color: '#2a52be' }}>Student Score Calculator</h2>

      <form onSubmit={handleSubmit}>
        <div style={{ marginBottom: '10px', color: '#e91e63' }}>
          <label>Student Name: </label>
          <input type="text" name="name" value={student.name} onChange={handleChange} required />
        </div>

        <div style={{ marginBottom: '10px', color: '#4caf50' }}>
          <label>School Name: </label>
          <input type="text" name="school" value={student.school} onChange={handleChange} required />
        </div>

        <div style={{ marginBottom: '10px', color: '#f57c00' }}>
          <label>Roll No: </label>
          <input type="text" name="rollNo" value={student.rollNo} onChange={handleChange} required />
        </div>

        <div style={{ marginBottom: '10px', color: '#9c27b0' }}>
          <label>Date of Birth: </label>
          <input type="date" name="dob" value={student.dob} onChange={handleChange} required />
        </div>

        <h4 style={{ color: '#009688' }}>Enter Marks for 4 Subjects (out of 100)</h4>
        {student.scores.map((score, index) => (
          <div key={index}>
            <input
              type="number"
              value={score}
              onChange={(e) => handleChange(e, index)}
              required
              placeholder={`Subject ${index + 1}`}
              min="0"
              max="100"
            />
          </div>
        ))}

        <button type="submit" style={{ marginTop: '10px' }}>Calculate</button>
      </form>

      {result && (
        <div style={{ marginTop: '20px', borderTop: '1px solid #ccc', paddingTop: '10px' }}>
          <h3 style={{ color: '#3f51b5' }}>Results</h3>
          <p><strong>Name:</strong> {student.name}</p>
          <p><strong>School:</strong> {student.school}</p>
          <p><strong>Roll No:</strong> {student.rollNo}</p>
          <p><strong>DOB:</strong> {student.dob}</p>
          <p><strong>Total Score:</strong> {result.total}</p>
          <p><strong>Percentage:</strong> {result.percentage}%</p>
        </div>
      )}
    </div>
  );
}

export default App;
