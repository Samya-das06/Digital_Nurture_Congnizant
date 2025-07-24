import React, { Component } from 'react';

class Posts extends Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
    };
  }

  loadPosts() {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then((response) => {
        if (!response.ok) {
          throw new Error('Failed to fetch posts');
        }
        return response.json();
      })
      .then((data) => {
        this.setState({ posts: data });
      })
      .catch((error) => {
        console.error('Error fetching posts:', error);
      });
  }

  
  componentDidMount() {
    this.loadPosts();
  }


  componentDidCatch(error, info) {
    alert('An error occurred in Posts component: ' + error.toString());
    console.error('Component error info:', info);
  }

  
  render() {
    return (
      <div>
        <h1 style={{ color: '#2E8B57' }}>Blog Posts</h1>
        {this.state.posts.map((post) => (
          <div key={post.id} style={{ borderBottom: '1px solid #ccc', padding: '10px 0' }}>
            <h3>{post.title}</h3>
            <p>{post.body}</p>
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;
