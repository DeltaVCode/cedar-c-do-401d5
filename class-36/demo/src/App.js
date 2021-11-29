import './App.css';
import Home from './components/Home';
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
      <Home message="Welcome!" isAwesome />
      <People people={data} title="Family" />
    </div>
  );
}

export default App;
