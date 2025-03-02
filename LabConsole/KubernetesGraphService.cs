using k8s;
using k8s.Models;

public class KubernetesGraphService
{
    private readonly IKubernetes _client;

    public KubernetesGraphService(IKubernetes client)
    {
        _client = client;
    }

    public async Task GetFilteredGraphAsync(string ns, string[] resourceKinds)
    {
        var graph = new KubernetesGraph();

        // Chargement des ressources demandées
        var pods = resourceKinds.Contains(KubernetesResourceKinds.Pod) ? await _client.CoreV1.ListNamespacedPodAsync(ns) : null;
        var deployments = resourceKinds.Contains(KubernetesResourceKinds.Deployment) ? await _client.AppsV1.ListNamespacedDeploymentAsync(ns) : null;
        var replicaSets = resourceKinds.Contains(KubernetesResourceKinds.ReplicaSet) ? await _client.AppsV1.ListNamespacedReplicaSetAsync(ns) : null;
        var services = resourceKinds.Contains(KubernetesResourceKinds.Service) ? await _client.CoreV1.ListNamespacedServiceAsync(ns) : null;
        var configMaps = resourceKinds.Contains(KubernetesResourceKinds.ConfigMap) ? await _client.CoreV1.ListNamespacedConfigMapAsync(ns) : null;
        var secrets = resourceKinds.Contains(KubernetesResourceKinds.Secret) ? await _client.CoreV1.ListNamespacedSecretAsync(ns) : null;
        var ingress = resourceKinds.Contains(KubernetesResourceKinds.Ingress) ? await _client.NetworkingV1.ListNamespacedIngressAsync(ns) : null;
        var stateFulSet = resourceKinds.Contains(KubernetesResourceKinds.StatefulSet) ? await _client.AppsV1.ListNamespacedStatefulSetAsync(ns) : null;
        var daemonSet = resourceKinds.Contains(KubernetesResourceKinds.DaemonSet) ? await _client.AppsV1.ListNamespacedDaemonSetAsync(ns) : null;
        var jobs = resourceKinds.Contains(KubernetesResourceKinds.Job) ? await _client.BatchV1.ListNamespacedJobAsync(ns) : null;




    //Ingress,
    // Namespace,
    // StatefulSet,
    // DaemonSet,
    // Job,
}