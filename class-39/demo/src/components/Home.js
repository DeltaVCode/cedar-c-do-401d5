import React from 'react';

// eslint-disable-next-line no-unused-vars
class HomeClassComponent extends React.Component {
  render() {
    return (
      <h1>Hi from Class Component</h1>
    )
  }
}

// export default HomeClassComponent;

function Home(props) {
  console.log('Home props', props);
  const { message } = props;

  return (
    <h1>{message} from Function Component</h1>
  );
}

export default Home;
