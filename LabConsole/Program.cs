using k8s;
using k8s.KubeConfigModels;

Console.WriteLine("Hello world");
// Configurer le client pour pointer vers le proxy
var config = new KubernetesClientConfiguration
{
    Host = "http://192.168.1.71:8080"  // Port redirigé via SSH
};

using var client = new Kubernetes(config);

// Obtenir la liste des pods
var pods = await client.CoreV1.ListNamespacedPodAsync("ipd-via");

foreach (var pod in pods.Items)
{
    Console.WriteLine($"Pod: {pod.Metadata.Name}");
}