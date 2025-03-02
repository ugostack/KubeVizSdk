// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using k8s;
using k8s.Models;

Console.WriteLine("Hello, World!");
var stopWatch = Stopwatch.StartNew();
var config = KubernetesClientConfiguration.BuildConfigFromConfigFile(Environment.GetEnvironmentVariable("KUBECONFIG").Split(';').First(s => s.Contains("alpha3")));

var client = new Kubernetes(config);
var podsCount = 0;

Console.WriteLine("---------------------- NAMESPACES ----------------------");
var namespaces = await client.CoreV1.ListNamespaceAsync();

//var kubernetesGraphService = new KubernetesGraphService(client);
//await kubernetesGraphService.GetFilteredGraphAsync("ipd-via", new[] { "Deployment", "Pod", "Service" });

//Console.WriteLine("Nodes:");
//foreach (var node in graph.Nodes)
//{
//    Console.WriteLine($"{node.Key}");
//    foreach (var value in node.Value)
//    {
//        Console.WriteLine($"    |-- {value}");
//        Console.WriteLine($"    |");
//    }
//}

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine("\nEdges:");
//foreach (var edge in graph.Edges)
//{
//    Console.WriteLine($"[{edge.From.Kind}] {edge.From.Name} --[{edge.Relation}]--> [{edge.From.Kind}] {edge.To.Name}");
//}


stopWatch.Stop();

Console.WriteLine($"Number of pod : {podsCount} in {stopWatch.Elapsed}");