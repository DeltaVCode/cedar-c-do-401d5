# LAB -  `<Login />` and `<Auth />`

**To Do List Manager Phase 3:** Adding security and access controls to the application.

In this next phase, we'll be requiring that users be logged in, in order to see the to do items. Additionally, based on their user type, they will be allowed (or denied) to perform actions such as editing or deleting them.

## Before you begin

Refer to *Getting Started*  in the [lab submission instructions](../../../reference/submission-instructions/labs/README.md) for complete setup, configuration, deployment, and submission instructions.

> Building off of your previous day's branch, create a new branch for today called 'auth' and continue to work in your 'todo' repository.

## Business Requirements

Refer to the [To Do System Overview](../../TodoApi/README.md) for a complete review of the application, including Business and Technical requirements along with the development roadmap.

## Phase 3 Requirements

In Phase 3, we'd like to extend the functionality of the application by requiring users be logged in to view items and also restrict access based on user type. The user stories from **Phases 1, and 2** remain unchanged. For this phase, we are now adding the following new user stories.

- As a user, I want to provide a way for all users to login to their account
- As a user, I want to make sure that my To Do items are only viewable to users that have logged in with a valid account.
- As a user, I want to ensure that only fellow users that are allowed to "create", based on their user type, can add new To Do Items
- As a user, I want to ensure that only fellow users that are allowed to "update", based on their user type, can mark To Do Items complete
- As a user, I want to ensure that only fellow users that are allowed to "delete", based on their user type, can delete new To Do Items

Logged-Out User:

![LoggedOut](todo-logged-out.png)

Logged-In User:

![LoggedIn](todo-user.png)

## Technical Requirements / Notes

> Technical requirements for the core application are unchanged from the prior phases, with the addition of an Authentication Context Provider and Components that consume the Context Values and Behaviors.

1. Implement a Login/Auth React Context, "protect" the To Do application by restricting access to the various application features based on the users' login status and capabilities.
   - Define a `useAuth` hook to expose the current context
   - Define a function that can simulate a `login` event.
     - Parameters: username and password as strings.
     - Sets a `User` on the auth context, and changes login status to `true`.
   - Define a function that can simulate a `logout` event.
     - Resets the `User` object and changes login status to `false.
   - Define a function that can `authorize` a User based on a capabilty.
     - Parameters: a capability as a string.
     - Returns a boolean whether the `user` has the capabililty parameter.

2. Create an `<Auth />` component with the following features:
   - Given a capability prop of type string, conditionally render components based on the `user` stored in `context`.
   - **Hide the entire interface until the user has logged in.**
   - **Implements the following RBAC rules:**
     - Logged In Users with 'read' permissions can see the summary/count.
     - Logged In Users with 'read' permissions can see the list of To Do Items.
     - Logged In Users with 'update' permissions can click the records to mark them as complete.
     - Logged In Users with 'create' permissions can create new items.
     - Logged In Users with 'delete' permissions can delete items.

3. Implement a `<Login />` Component that has the following features:
   - Provide an account login screen with a form.
     - Accepts Username and Password
   - If a user returns and has a valid login token, hide the login form and consider them "Logged In"
     - Display a logout button instead of a form if they are "Logged In".

### Tools you will need to complete the above requirements

### Stretch Goals

- Add a `/register` route with a form to a create new accounts
- Find a cookie library to save/restore the user token, so users stay logged in

### Assignment Submission Instructions

Refer to the the [Submitting React Apps Lab Submission Instructions](../../../reference/submission-instructions/labs/react-apps.md) for the complete lab submission process and expectations
