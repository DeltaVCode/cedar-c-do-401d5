import useAuth from "../hooks/useAuth";

function PeopleForm(props) {
  const { hasPermission } = useAuth();
  const { onSave } = props;

  function handleSubmit(e) {
    e.preventDefault();

    const form = e.target;
    const { name } = form.elements;

    const formData = {
      name: name.value,
      // other fields here
    };
    // console.log(formData);
    onSave(formData);

    e.target.reset();
    e.target.elements.name.focus();
  }

  let canCreate = hasPermission('create');

  return (
    <form onSubmit={handleSubmit}>
      <input type="text" name="name" placeholder="Name" />
      <button type="submit" disabled={!canCreate}>Save</button>
    </form>
  )

}

export default PeopleForm;
