import { createContext, useContext } from "react"

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
  const state = {
    user: null,
    // user: { username: 'Keith' },

    login,
  };

  async function login(loginData) {
    console.log(loginData);

    const result = await fetch(`${usersAPI}/Login`, {
      method: 'post',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(loginData),
    });

    const resultBody = await result.json();
    console.log(resultBody)
  }

  return (
    <AuthContext.Provider value={state}>
      {props.children}
    </AuthContext.Provider>
  )
}
