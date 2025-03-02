public static class KubernetesResourceKinds
{
    public const string Pod = "Pod";
    public const string Deployment = "Deployment";
    public const string ReplicaSet = "ReplicaSet";
    public const string Service = "Service";
    public const string ConfigMap = "ConfigMap";
    public const string Secret = "Secret";
    //public const string PersistentVolume = "PersistentVolume";
    //public const string PersistentVolumeClaim = "PersistentVolumeClaim";
    public const string Ingress = "Ingress"; // Osef c'est pas dans le client
    //public const string Node = "Node"; // TODO pourrait être interessant de garder les nodes pour savoir sur quel noeud tourne un pod
    public const string Namespace = "Namespace";
    public const string StatefulSet = "StatefulSet";
    public const string DaemonSet = "DaemonSet";
    public const string Job = "Job";
    //public const string CronJob = "CronJob";
    //public const string NetworkPolicy = "NetworkPolicy";
    //public const string Role = "Role";
    //public const string RoleBinding = "RoleBinding";
    //public const string ClusterRole = "ClusterRole";
    //public const string ClusterRoleBinding = "ClusterRoleBinding";
    //public const string CustomResourceDefinition = "CustomResourceDefinition";
}

public enum KubernetesKindEnum
{
    Pod,
    Deployment,
    ReplicaSet,
    Service,
    ConfigMap,
    Secret,
    Ingress,
    Namespace,
    StatefulSet,
    DaemonSet,
    Job,
}