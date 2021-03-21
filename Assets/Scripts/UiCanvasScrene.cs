using UnityEngine;
using UnityEngine.UI;

public class UiCanvasScrene : MonoBehaviour
{
    private Text timerText;
    private Text personalHighscoreText;
    private TimerService timerService;
    // Start is called before the first frame update
    void Start()
    {
        timerService = FindObjectOfType<TimerService>();
        timerText = GameObject.Find("TimerText").GetComponent<Text>();
        personalHighscoreText = GameObject.Find("PersonalBestText").GetComponent<Text>();
        timerService.DisplayTime(personalHighscoreText, timerService.currentTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (timerService.isTimeEnabled) {
            timerService.DisplayTime(timerText, timerService.currentTime);
        }
    }
}
