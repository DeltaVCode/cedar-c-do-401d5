import { Link } from 'react-router-dom';

function Header() {
  return (
    <nav>
      <ul>
        <li><Link to="/">Home</Link></li>
        <li><Link to="/people">People</Link></li>
        <li><Link to="/counters">Counters</Link></li>
      </ul>
    </nav>
  );
}

export default Header;
