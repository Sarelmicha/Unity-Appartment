using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMotion : MonoBehaviour
{
    [SerializeField] GameObject target = null;

    NavMeshAgent navMeshAgent = null;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        SetTargetDestination(target);
    }

    public void SetTargetDestination(GameObject target)
    {
        navMeshAgent.SetDestination(target.transform.position);
    }
}

