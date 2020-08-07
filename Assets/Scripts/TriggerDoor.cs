using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{

    [SerializeField] GameObject doorAxis;


    private void OnTriggerEnter(Collider other)
    {
       
        doorAxis.GetComponent<DoorMotion>().Open();
    }

    private void OnTriggerExit(Collider other)
    {
        doorAxis.GetComponent<DoorMotion>().Close();
    }


}
