import useFetch from "../hooks/useFetch";

const todoApi = 'https://deltav-todo.azurewebsites.net/api/v1/Todos';

export default function Todos() {
  const { data, isLoading } = useFetch(todoApi);

  if (isLoading) {
    return (<h2>Loading...</h2>)
  }

  return (
    <ul>
      {data.map(todo => (
        <li key={todo.id}>{todo.title}</li>
      ))}
    </ul>
  )
}
