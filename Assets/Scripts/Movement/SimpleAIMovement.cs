using UnityEngine;
using UnityEngine.AI;

public class SimpleAIMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    private NavMeshAgent meshAgent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
        meshAgent.SetDestination(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (meshAgent.remainingDistance < 0.2f)
            meshAgent.isStopped = true;
    }
}
