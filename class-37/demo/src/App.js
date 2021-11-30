import './App.css';
import { Switch, Route, Link } from 'react-router-dom';
import Home from './components/Home';
import Counters from './components/Counters';
import People from './components/People'

const data = [
  { id: 12, name: 'Keith' },
  { id: 15, name: 'Stacey' },
  { id: 18, name: 'Craig' },
  { id: 21, name: 'Andy' },
];

function App() {
  return (
    <div className="App">
      <nav>
        <ul>
          <li><Link to="/">Home</Link></li>
          <li><Link to="/people">People</Link></li>
          <li><Link to="/counters">Counters</Link></li>
        </ul>
      </nav>
      <Switch>
        <Route path="/" exact>
          <Home message="Welcome!" isAwesome />
        </Route>
        <Route path="/people">
          <People people={data} title="Family" />
        </Route>
        <Route path="/counters">
          <Counters />
        </Route>
        <Route>
          <h1>Not Found!</h1>
        </Route>
      </Switch>
    </div>
  );
}

export default App;
