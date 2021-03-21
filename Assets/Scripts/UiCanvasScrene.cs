using UnityEngine;
using UnityEngine.UI;

public class UiCanvasScrene : MonoBehaviour
{
    private Text timerText;
    private Text personalHighscoreText;
    private TimerService timerService;
    private GameEngineService gameEngineService;
    // Start is called before the first frame update
    void Start()
    {
        timerService = FindObjectOfType<TimerService>();
        gameEngineService = FindObjectOfType<GameEngineService>();
        timerText = GameObject.Find("TimerText").GetComponent<Text>();
        personalHighscoreText = GameObject.Find("PersonalBestText").GetComponent<Text>();
        timerService.DisplayTime(personalHighscoreText, gameEngineService.getPersonalHighscore());
    }

    // Update is called once per frame
    void Update()
    {
        if (timerService.isTimeEnabled) {
            timerService.DisplayTime(timerText, timerService.currentTime);
        }
    }
}
