public class KubernetesGraph
{
    public Dictionary<string, List<string>> Nodes { get; set; } = new();
    public List<(KubernetesNode From, KubernetesNode To, string Relation)> Edges { get; set; } = new();
}

public class KubernetesNode(string name, string kind)
{
    public string Name { get; set; } = name;
    public string Kind { get; set; } = kind;
    public string? CpuUsed { get; set; }
    public string? MemoryUsed { get; set; }
    public string? Logs { get;set; }

    public List<KubernetesNode> Dependencies { get; set; } = [];
}