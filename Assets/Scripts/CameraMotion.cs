using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour
{

    [SerializeField] private float _forwardSpeed = 1f;
    [SerializeField] private float angularSpeed = 1f;
    
    private CharacterController _characterController;

    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        Walk();
    }

    private void Walk()
    {
        float verticalInput = Input.GetAxis("Vertical");
        
        //Walk according to user vertical key board input
        _characterController.Move(transform.TransformDirection(Vector3.forward * verticalInput * _forwardSpeed));
    }

    private void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
     
        //Rotate according to user mouse input
        transform.Rotate(0, mouseX * angularSpeed * Time.deltaTime, 0);
    }
}
