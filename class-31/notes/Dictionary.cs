var d = new Dictionary<int, string>();

// add
d.Add(42, "Keith");
// throws if you add same key again

// get
string value = d[42];
Assert.Equal("Keith", value);
// Item[TKey key]
// throws if key not found

// set
d[42] = "Keith"; // exists
d[50] = "Stacey"; // new
// will replace existing value

// contains
d.ContainsKey(42); // bool - efficient
d.ContainsValue("Keith"); // inefficient

// Other Stuff!!

d.Clear(); // remove all

d.Keys; // enumerable of all Keys
foreach (int key in d.Keys) { ... }

Assert.Equals(new[] { 42, 50 }, d.Keys);

// Try Whatever

if (int.TryParse("12", out int num))
{
   // num has value, if valid
}

if (d.TryAdd(42, "Craig"))
{
    // only if 42 didn't exist
}

if (d.TryGetValue(75, out string value))
{
    // value = d[75], but only if exists
}
