import useAuth from "../../hooks/useAuth";

export default function Login() {
  const { login } = useAuth();

  function handleSubmit(event) {
    event.preventDefault();

    const form = event.target;
    const { username, password } = form.elements;

    const loginData = {
      username: username.value,
      password: password.value,
    };
    // console.log(loginData);

    login(loginData);

    // TODO: reset and keep focus if login fails
    // TODO: redirect to home page if succeeds
    form.reset();
  }

  return (
    <form onSubmit={handleSubmit}>
      <label>Username: <input name="username" /></label>
      <label>Password: <input name="password" type="password" /></label>
      <button type="submit">Log In</button>
    </form>
  )
}