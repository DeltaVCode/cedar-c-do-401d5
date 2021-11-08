# E-commerce Sprint 1 - Milestone 1:  MVC

## Admin Dashboard

Create the general Administrative Dashboard workflow, User Interface/Design, screens, and initial database design and wiring.

### User Stories and Tasks

1. As an admin user, I would like to have a dashboard where I can see a list of product categories
1. As an admin user, I would like to view a detail page for each category so that I can eventually edit its data or delete it
1. As an admin user, I would like to see a list of the products assigned to a category on the category details page
1. As an admin user, I would like a detail page for each product so that I can eventually edit its data or delete it

*Note:* do not worry about Authorization, yet.

### Guidance

- You may use the `mvc` project template (**ASP.NET Core Web App (Model-View-Controller)** in Visual Studio) to streamline getting started
- What Data Models, Properties, Navigation Properties or DTOs do you need?
  - An ERD is a great place to start
- Configure your core:  `DbContext` with seed data, Interfaces/Services, Routing
- You may use the **MVC Controller with views, using Entity Framework** item scaffold
  - Are there any actions/views you can delete?
- You will need something like an `AdminController` for the dashboard, for which scaffolding won't work. Use what you know from Module 2 about getting data into your controller.
- Do you need any view models?

## To Submit this Assignment

- Create a new repository in GitHub
- Name your repo `E-Commerce-App`
- Push your Solution File and MVC Web Project to `main`
- Create a GitHub Action on a Pull Request and verify you have a green build; merge to `main`
- Create a branch named `sprint-#-milestone-#`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `main` branch.
- Submit a link to your PR in Canvas
- Merge your PR back into main
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)
