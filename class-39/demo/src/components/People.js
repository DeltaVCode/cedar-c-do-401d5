import React, { useEffect, useMemo, useState } from "react";

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
  const { people, title } = props;

  // Only log if people changed
  useEffect(() => {
    console.log('People props', people);
  }, [people])

  const [toggle, setToggle] = useState(false);

  const fiveLetterCount = useMemo(() => {
    console.log('Count five-letters')
    return people.filter(p => p.name.length === 5).length;
  }, [people])

  return (
    <>
      <h2>{title} ({fiveLetterCount})</h2>
      <button onClick={() => setToggle(!toggle)}>{toggle ? 'Off' : 'On'}</button>
      <ul>
        {people.map(person => (
          <li key={person.id}>{person.name}</li>
        ))}
      </ul>
    </>
  )
}

export default People;
