var dict = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);

foreach(var w in words)
{
    if (dict.ContainsKey(w)) {
       // pick one of these; they're all equivalent
       dict[w] = dict[w] + 1;
       dict[w] += 1;
       dict[w]++;
    }
    else
    {
       // pick one of these; they're also equivalent
       dict[w] = 1; // add or replace value at key
       dict.Add(w, 1); // only works 1st time
    }
}

// now have a dictionary of our words + counts
// but what is the most common word?!

int maxCount = 0;
int maxWord = null;

// kvp = KeyValuePair<string, int>
foreach (var kvp in dict)
{
    if (kvp.Value > maxCount)
    {
        maxWord = kvp.Key;
        maxCount = kvp.Value;
    }
}

return maxWord;


// LINQ!
return dict.MaxBy(kvp => kvp.Value).Key;

// More LINQ!
return dict.GroupBy(kvp => kvp.Value, kvp => kvp.Key).MaxBy(g => g.Key);
