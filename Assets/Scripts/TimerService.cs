using UnityEngine;
using UnityEngine.UI;
using System;


public class TimerService : MonoBehaviour
{
    public float currentTime = 0;
    public bool isTimeEnabled = false;

    void Start()
    {
        startTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimeEnabled)
        {
            currentTime += Time.deltaTime;
        }
    }

    public void DisplayTime(Text target, float timeToDisplay, string format = "mm\\:ss\\.fff")
    {
        target.text = TimeSpan.FromSeconds(timeToDisplay).ToString(format);
    }

    public void startTime()
    {
        isTimeEnabled = true;
    }

    public void stopTime()
    {
        isTimeEnabled = false;
    }

    public float getFinalTime()
    {
        return PlayerPrefs.GetFloat("finalTime", 0);
    }

    public void setFinalTime(float time)
    {
        PlayerPrefs.SetFloat("finalTime", time);
    }
}
