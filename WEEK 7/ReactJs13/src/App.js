import React from 'react';
import CourseDetails from './CourseDetails';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';

function App() {
  return (
    <div style={{ textAlign: 'left', padding: '20px' }}>
      <h1>Blogger App</h1>

      
      <div style={{ display: 'flex', marginTop: '40px' }}>
        
        
        <div style={{ paddingRight: '15px', borderRight: '4px solid green' }}>
          <CourseDetails />
        </div>

        
        <div style={{ padding: '0 15px', borderRight: '4px solid green' }}>
          <BookDetails />
        </div>

        
        <div style={{ paddingLeft: '15px' }}>
          <BlogDetails />
        </div>

      </div>
    </div>
  );
}

export default App;
