using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Open()
    {
       
        animator.SetBool("isOpen", true);
    }

    public void Close()
    {
       
        animator.SetBool("isOpen", false);
    }
}
