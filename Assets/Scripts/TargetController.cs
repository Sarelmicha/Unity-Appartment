using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    [SerializeField] Transform[] positions;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 newPos;
        CharacterMotion characterMotion = other.GetComponent<CharacterMotion>() as CharacterMotion;

        if (characterMotion == null)
        {
            return;
        }

        do
        {
          newPos = positions[UnityEngine.Random.Range(0, positions.Length - 1)].position;
        }
        while (newPos == transform.position);


        transform.position = newPos;
        characterMotion.SetTargetDestination(gameObject);
        
    }
}
