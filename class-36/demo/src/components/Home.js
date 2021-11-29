import React from 'react';

class HomeClassComponent extends React.Component {
  render() {
    return (
      <h1>Hi from Class Component</h1>
    )
  }
}

// export default HomeClassComponent;

function Home() {
  return (
    <h1>Hi from Function Component</h1>
  );
}

export default Home;
