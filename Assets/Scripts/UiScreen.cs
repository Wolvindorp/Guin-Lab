using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiScreen : MonoBehaviour
{
    private Text playerName;
    // Start is called before the first frame update
    void Start()
    {
        playerName = GetComponent<Text>();
        playerName.text = "Spielername: Tombert";
    }

    // Update is called once per frame
    void Update()
    {
    }
}
