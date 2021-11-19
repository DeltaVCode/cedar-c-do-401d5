namespace DataStructures.Graphs;

class Graph
{
    public List<GraphNode> Nodes;
    IEnumerable<GraphNode> GetNodes()

    GraphNode AddNode(string value);

    AddEdge(string from, string to);
    AddEdge(Node from, Node to);
}

class GraphNode
{
    string Value; // generic?

    List<GraphEdge> Neighbors;
}

class GraphEdge
{
    GraphNode From;
    GraphNode To;
    int Weight;
}