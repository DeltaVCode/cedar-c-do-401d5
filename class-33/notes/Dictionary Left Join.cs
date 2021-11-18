LeftJoin(
   Dictionary<string,string> left,
   Dictionary<string, string> right) {

var result = new List<string[]>();

// Dictionary => IEnumerable<KeyValuePair<string, string>>
foreach (var kvp in left) {
    string[] addMe = new string[3];

    addMe[0] = kvp.Key;
    addMe[1] = kvp.Value;

    // Check if we have an antonym!
    if (right.TryGetValue(kvp.Key, out string antonym)) {
        addMe[2] = antonym;
    }

    result.Add(addMe);
}

return result;
}