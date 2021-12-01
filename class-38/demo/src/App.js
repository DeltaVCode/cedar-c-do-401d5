import './App.css';
import { Switch, Route } from 'react-router-dom';
import Home from './components/Home';
import Counters from './components/Counters';
import People from './components/People'
import PeopleForm from './components/PeopleForm';
import { useState } from 'react';
import Header from './components/Header';
import Login from './components/auth/Login';

const data = [
  { id: 12, name: 'Keith' },
  { id: 15, name: 'Stacey' },
  { id: 18, name: 'Craig' },
  { id: 21, name: 'Andy' },
];
let nextId = 75;

function App() {
  const [peeps, setPeeps] = useState(data);

  function handleSave(formData) {
    const newPeep = {
      ...formData, // Copy all the properties into the new object
      id: nextId++, // Guess what next Id will be from API
    };

    const newPeeps = [
      ...peeps, // Spread = copy all of peeps into the new array
      newPeep,
    ];

    setPeeps(newPeeps);
  }

  return (
    <div className="App">
      <Header />
      <Switch>
        <Route path="/" exact>
          <Home message="Welcome!" isAwesome />
        </Route>
        <Route path="/people">
          <People people={peeps} title="Family" />
          <PeopleForm onSave={handleSave} />
        </Route>
        <Route path="/counters">
          <Counters />
        </Route>
        <Route path="/login">
          <Login />
        </Route>
        <Route>
          <h1>Not Found!</h1>
        </Route>
      </Switch>
    </div>
  );
}

export default App;
