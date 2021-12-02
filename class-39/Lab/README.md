# LAB -  API Integration

**To Do List Manager Phase 4:** Integrating with a live API

In this final phase, we'll be requiring that users be logged in through a live authentication server, in order to see the to do items. Additionally, based on their user type, they will be allowed (or denied) to perform actions such as editing or deleting them. All To Do items will be stored in a database, accessed through a deployed API

## Before you begin

Refer to *Getting Started*  in the [lab submission instructions](../../../reference/submission-instructions/labs/README.md) for complete setup, configuration, deployment, and submission instructions.

> Building off of your previous day's branch, create a new branch for today called 'auth' and continue to work in your 'todo' repository.

## Business Requirements

Refer to the [To Do System Overview](../../TodoApi/README.md) for a complete review of the application, including Business and Technical requirements along with the development roadmap.

## Phase 4 Requirements

In Phase 4, we will finalize the functionality of the application by connecting to live servers for login, authorization, and data access

## Technical Requirements / Notes

> Technical requirements for the core application are unchanged from the prior phases, with the addition of Performing actual HTTP requests with an Authenticated API server:

1. Alter the Add, Toggle Complete, and Delete functions within your to do application to use your API instead of in memory state.
   - Fetch the current list of items from the database on application start
   - Whenever you add/update/delete an item, refresh the state so the user can instantly see the change
     - Consider: Do you re-fetch from the server every time you make a change?
       - If so, how?
       - If not, how will you stay in sync?

### Strech Goals

- Use Axios or Superagent instead of plain `fetch`
- Use [`react-query`](https://react-query.tanstack.com/) or [SWR](https://swr.vercel.app/) instead of Axios, Superagent or plain `fetch`
- Look up React Testing Library docs and try to test anything

### Assignment Submission Instructions

Refer to the the [Submitting React Apps Lab Submission Instructions](../../../reference/submission-instructions/labs/react-apps.md) for the complete lab submission process and expectations
