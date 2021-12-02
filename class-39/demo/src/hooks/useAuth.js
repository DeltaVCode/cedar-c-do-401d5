import { createContext, useCallback, useContext, useEffect, useMemo, useState } from "react"
import jwt from 'jsonwebtoken'

// Normally get this from our environment
const usersAPI = 'https://deltav-todo.azurewebsites.net/api/v1/Users';

// React Magic!
export const AuthContext = createContext();

export default function useAuth() {
  const auth = useContext(AuthContext);
  if (!auth) throw new Error("You forgot AuthProvider!");
  return auth;
}

export function AuthProvider(props) {
  const [user, setUser] = useState(null);

  const hasPermission = useCallback(function (permission) {
    if (!user) return false;

    // No specific permission requested, but they are signed in!
    if (!permission) return true;

    // Asked for permission and user has none!
    if (!user.permissions) return false;

    // Can user do the specific thing?
    return user.permissions.includes(permission);
  }, [user]);

  const auth = useMemo(() => {
    console.log('New auth state!');

    return ({
      // user: null,
      // user: { username: 'Keith' },
      user,

      hasPermission,
      login,
      logout,
    });
  }, [user, hasPermission]);

  useEffect(() => {
    // Load token/user from cookie!
  }, []);

  useEffect(() => {
    // Set or remove cookie!
  }, [user])

  async function login(loginData) {
    // console.log(loginData);

    const result = await fetch(`${usersAPI}/Login`, {
      method: 'post',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(loginData),
    });

    const resultBody = await result.json();
    console.log(resultBody)

    if (result.ok) {
      let user = processUser(resultBody)
      setUser(user);
    } else {
      console.warn('auth failed', resultBody);
    }
  }

  function logout() {
    setUser(null);
  }

  return (
    <AuthContext.Provider value={auth}>
      {props.children}
    </AuthContext.Provider>
  )
}

function processUser(user) {
  if (!user) return null;

  try {
    const payload = jwt.decode(user.token);
    if (payload) {
      // Copy everything from payload into user
      Object.assign(user, payload);

      console.log(user)
      return user;
    }
  }
  catch (e) {
    console.warn(e);
  }

  return null;
}