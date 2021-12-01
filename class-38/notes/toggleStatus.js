// DOES NOT WORK
function toggleStatus(todo)
{
   todo.completed = !todo.completed;
   // React does not know that we need to update!
}

// SHOULD WORK
const [todoList, setTodoList] = useState([]);

function toggleStatus(todo)
{
  let newList = todoList.map(t => {
    // Is t the todo to update?
    if (todo === t) {
      // Make a copy of todo, then toggle
      return {
        ...todo,
        completed: !todo.completed,
      };
    }

    return t;
  });
   setTodoList(newList);
}







