using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAvatar : MonoBehaviour
{
    public Animator a;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        a.SetFloat("Forward", (Input.GetAxis("Vertical")));
        a.SetFloat("Turn", Input.GetAxis("Horizontal"));
    }
}
