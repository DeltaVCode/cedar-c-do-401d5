// For every new model

1. Create class `Whatever` in `Models/`
2. Add `DbSet<Whatever> Whatevers` to `DbContext`
3. Add our migration *and fix any errors*
   - Often fixing requires changes in `OnModelCreating`
4. Look at the migration - does it look about right?
   - If wrong, `dotnet ef migrations remove` and try again
5. `dotnet ef database update`
6. Either generate (scaffold) a controller OR
   add new action method(s) to existing controller
7. Either create a new `IWhateverRepository` + implementation OR
   add methods to an existing one
8. Do we need reverse navigation properties to see the things we can now CRUD?
