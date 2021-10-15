var q1 = features.Where(....);

var q2 = q1.Select(......);

var q3 = q2.Distinct();

foreach (var neighbor in q3)
  Console.WriteLine(neighbor)

// Equivalent single query

var q =
  features
    .Where(.....)
    .Select(.....)
    .Distinct();

Console.WriteLine($"All in one: {q.Count()}");

