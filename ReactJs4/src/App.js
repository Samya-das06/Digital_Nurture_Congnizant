import React, { Component } from 'react';
import Posts from './Posts';

class App extends Component {
  render() {
    return (
      <div style={{ maxWidth: '800px', margin: 'auto', padding: '20px' }}>
        <Posts />
      </div>
    );
  }
}

export default App;
