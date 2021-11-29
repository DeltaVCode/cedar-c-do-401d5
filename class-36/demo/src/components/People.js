import React from "react";

class PeopleClassComponent extends React.Component {
  render() {
    // destructuring
    // const people = this.props.people;
    const { people } = this.props;

    return (
      <ul>
        {people.map(person => (
          <li key={person.id}>{person.name}</li>
        ))}
      </ul>
    )
  }
}

export default PeopleClassComponent;
