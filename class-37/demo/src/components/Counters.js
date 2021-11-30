import React from "react";

function Counters() {
  return (
    <>
      <h1>Counters!</h1>
      <h2>Class Component</h2>
      <CounterClassComponent />
    </>
  )
}

export default Counters;

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