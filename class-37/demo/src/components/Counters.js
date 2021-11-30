import React, { useState } from "react";

function Counters() {
  return (
    <>
      <h1>Counters!</h1>
      <h2>Function Component</h2>
      <CounterFunctionComponent />
      <h2>Function Component 2</h2>
      <CounterFunctionComponent />
      <h2>Class Component</h2>
      <CounterClassComponent />
    </>
  )
}

export default Counters;

function CounterFunctionComponent() {
  // destructure the array: first has state value, second has setter
  const [counter, setCounter] = useState(0); // Initial value = 0

  // Define handler functions inside the function
  function handleClick() {
    setCounter(counter + 1);
  }

  return (
    <p>
      Counter: {counter}
      {' '}
      <button onClick={handleClick}>+1</button>
    </p>
  )
}

class CounterClassComponent extends React.Component {
  constructor(props) {
    super(props);

    // Initial value
    this.state = {
      counter: 0,
    };
  }

  handleClick = e => {
    this.setState({
      counter: this.state.counter + 1,
    });
  }

  render() {
    return (
      <p>
        Counter: {this.state.counter}
        {' '}
        <button onClick={this.handleClick}>+1</button>
      </p>
    )
  }
}