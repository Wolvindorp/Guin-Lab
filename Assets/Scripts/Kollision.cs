using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Hier ist was passiert");
    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        
    }

    private void OnCollisionExit(Collision collisionInfo)
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
