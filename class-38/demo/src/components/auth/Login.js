export default function Login() {

  function handleSubmit(event) {
    event.preventDefault();

    const form = event.target;
    const { username, password } = form.elements;

    const loginData = {
      username: username.value,
      password: password.value,
    };
    console.log(loginData);
  }

  return (
    <form onSubmit={handleSubmit}>
      <label>Username: <input name="username" /></label>
      <label>Password: <input name="password" type="password" /></label>
      <button type="submit">Log In</button>
    </form>
  )
}