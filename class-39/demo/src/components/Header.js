import { Link } from 'react-router-dom';
import useAuth from '../hooks/useAuth';

function Header() {
  const { user, logout } = useAuth();

  return (
    <nav>
      <ul>
        <li><Link to="/">Home</Link></li>
        <li><Link to="/people">People</Link></li>
        <li><Link to="/todos">Todos</Link></li>
        <li><Link to="/counters">Counters</Link></li>
        {!user && <li><Link to="/login">Login</Link></li>}
        {user &&
          <>
            <li>Welcome back, {user.username}</li>
            <li><button onClick={() => logout()}>Log Out</button></li>
          </>
        }
      </ul>
    </nav>
  );
}

export default Header;
