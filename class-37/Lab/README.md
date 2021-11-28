# LAB - Events & State

**To Do List Manager Phase 2:** Manage local state for the To Do Application

In this phase, we'll add interactivity, adding/updating/removing items on the page.

## Business Requirements

Refer to the [To Do System Overview](../../TodoApi/README.md) for a complete review of the application, including Business and Technical requirements along with the development roadmap.

## Phase 2 Requirements

- As a user, I would like an easy way to add a new to do item using an online interface
- As a user, I would like my to do items to have an assignee, due date, difficulty meter, status and the task itself
- As a user, I would like to delete to do items that are no longer needed
- As a user, I would like to easily mark to do items as completed

Note that the display of each To Do item has changed slightly.

![To Do Application](todo.png)

## Technical Requirements / Notes

Technical requirements for the core application are unchanged from **Phase 1**, with the following exceptions and notes:

- Manage state using the `useState()` hook
- Match the provided mockup for the design
  - Use `react-bootstrap` components and theming
  - Some interactivity notes:
    - Each item in list should show the text of the item as well as the assignee
    - When clicked, toggle the "complete" status of the item.
    - Items should be styled differently when complete/incomplete making their status visually obvious

### Stretch Goals

- Use [`useLocalStorage`](https://usehooks.com/useLocalStorage/) to persist todos in `localStorage`
- Allow the user to dynamically sort to do items by date, difficulty, or assignee
- Allow the user to filter to do items by date, difficulty, or assignee
