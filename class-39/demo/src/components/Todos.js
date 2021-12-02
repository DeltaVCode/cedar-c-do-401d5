import useAuth from "../hooks/useAuth";
import useFetch from "../hooks/useFetch";
import Auth from "./auth";

const todoApi = 'https://deltav-todo.azurewebsites.net/api/v1/Todos';

export default function Todos() {
  const { data, isLoading } = useFetch(todoApi);
  const { user } = useAuth();

  async function handleDelete(todo) {
    console.log('Deleting...', todo);
    if (!user) {
      console.warn("Anonymous should not be allowed to delete!");
      return;
    }

    // Ideally this would also be encapsulated in useFetch
    await fetch(`${todoApi}/${todo.id}`, {
      method: 'delete',
      headers: {
        'Authorization': `Bearer ${user.token}`
      }
    })
  }

  if (isLoading) {
    return (<h2>Loading...</h2>)
  }

  return (
    <ul>
      {data.map(todo => (
        <li key={todo.id}>
          {todo.title}

          <Auth permission='delete'>
            <button onClick={() => handleDelete(todo)}>Delete</button>
          </Auth>
        </li>
      ))}
    </ul>
  )
}
