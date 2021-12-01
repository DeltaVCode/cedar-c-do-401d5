import { createContext, useContext } from "react"

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
  };

  return (
    <AuthContext.Provider value={state}>
      {props.children}
    </AuthContext.Provider>
  )
}
