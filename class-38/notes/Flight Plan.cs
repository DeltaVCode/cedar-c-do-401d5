// Pandora => Arendelle => Monstropolis
// 0          1            2

int? GetFlight(string[] itinerary, Graph map)
{
    // 1. FROM = starting node
    var from = map.Nodes.First(n => n.Value == itinerary[0]);

    // 2. TO = check if FROM can get to next destination

    // 3. If found, add to total cost
          and FROM <- TO

    int sum = 0;

    // Starting at first destination (second value)
    // Check each destination
    for (int i = 1; i < itinerary.Length; i++) {

        // Can we get to the next stop?
        var toEdge = from.Neighbors
            .First(edge => edge.Node.Value == itinerary[i]);

        if (toEdge == null) return null; // route not found

        sum += toEdge.Weight; // Weight = Price

        from = toEdge.Node;
    }

    return sum;
}