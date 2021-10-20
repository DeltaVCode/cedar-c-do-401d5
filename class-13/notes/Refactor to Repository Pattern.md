1. Create repository Interface in Services folder
2. Add dependency on that interface in our Controller constructor
3. Add an implementation of that interface in Services/Data (or Data/Repositories or wherever you want, really)
4. Update `ConfigureServices()` to register the interface with its "concrete" implementation
5. Confirm the controller still works, but with its new dependency
6. Add your DbContext as a constructor dependency of the implementation class, saved to a `private readonly` field
7. Confirm again the controller works with its dependency's new dependency
8. Add method to interface, implement in the class, use in controller. Repeat.
