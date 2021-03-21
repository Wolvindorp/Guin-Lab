using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jump = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump")) {
            jump = 20* Time.deltaTime;
        } else {
            jump = 0;
        }
        transform.Translate(0, jump, 0);
    }
}
