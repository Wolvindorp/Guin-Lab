using UnityEngine;
using UnityEngine.UI;

public class UiScreen : MonoBehaviour
{
    private Text timerText;
    private float currentTime = 0;
    public bool isTimeEnabled = false;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
        timerText.text = "Time: 00:00";
        isTimeEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimeEnabled) {
            currentTime += Time.deltaTime;
            DisplayTime(currentTime);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }
}
