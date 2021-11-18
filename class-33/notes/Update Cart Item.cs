class CartItem
{
    int ProductId {get;set;}
    string UserId {get;set;}
    int Quantity {get;set;}
}

// Composite Key ^

DatabaseCartRepo : ICartRepo
{
  private readonly EcomDbContext _context;

  public DatabaseCartRepo(EcomDbContext ctx)
  {
     _context = ctx;
  }

AddToCart(int productId, int qty)
{
  string userId = userSvc.GetId();

  var cartItem = await this._context.CartItems
          // Option 1: Find by PK values
          .FindAsync(userId, productId);
          // Option 2: FirstOrDefaultAsync
          .FirstOrDefaultAsync(ci =>
              ci.UserId == userId &&
              ci.ProductId == productId);

  // Not found! Add one
  if (cartItem == null)
  {
     cartItem = new CartItem { ... };
     _context.CartItems.Add(cartItem);
  }
  else
  {
     cartItem.Quantity += qty;
     _context.Entry(cartItem).State = Modified;
  }

  // Update done; save to database
  await _context.SaveChangesAsync();
}

}


