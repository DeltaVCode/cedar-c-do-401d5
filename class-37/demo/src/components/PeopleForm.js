function PeopleForm(props) {

  function handleSubmit(e) {
    e.preventDefault();

    const form = e.target;
    const { name } = form.elements;

    const formData = {
      name,
      // other fields here
    };
    console.log(formData);

    e.target.reset();
    e.target.elements.name.focus();
  }

  return (
    <form onSubmit={handleSubmit}>
      <input type="text" name="name" placeholder="Name" />
      <button type="submit">Save</button>
    </form>
  )

}

export default PeopleForm;
