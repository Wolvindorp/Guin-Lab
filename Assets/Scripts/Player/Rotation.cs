using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float x_rota = 0;
    public float y_rota = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow)) {
            x_rota = 20* Time.deltaTime;
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            x_rota = -20* Time.deltaTime;
        } else if (Input.GetKey(KeyCode.UpArrow)) {
            y_rota = 20* Time.deltaTime;
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            y_rota = -20* Time.deltaTime;
        } else {
            x_rota = 0;
            y_rota = 0;
        }
        
        // transform.rotation = transform.rotation += transform.Rotate(x_rota);
        transform.Rotate(x_rota, y_rota, 0);
    }
}
