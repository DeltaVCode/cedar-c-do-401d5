import React from "react";

// eslint-disable-next-line no-unused-vars
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

// export default PeopleClassComponent;

// Function component must ask for props parameter
// instead of using this.props
function People(props) {
  console.log('People props', props);
  const { people, title } = props;

  return (
    <>
      <h2>{title}</h2>
      <ul>
        {people.map(person => (
          <li key={person.id}>{person.name}</li>
        ))}
      </ul>
    </>
  )
}

export default People;
