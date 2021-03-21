using UnityEngine;
using UnityEngine.UI;

public class UiSuccess : MonoBehaviour
{
    private Text currentTimeText;
    private Text highscoreText;
    private TimerService timerService;
    private GameEngineService gameEngineService;

    // Start is called before the first frame update
    void Start()
    {
        timerService = FindObjectOfType<TimerService>();
        gameEngineService = FindObjectOfType<GameEngineService>();
        currentTimeText = GetComponent<Text>();
        timerService.DisplayTime(currentTimeText, timerService.getFinalTime());
        highscoreText = GameObject.Find("HighscoreText").GetComponent<Text>();
        timerService.DisplayTime(highscoreText, gameEngineService.getPersonalHighscore());
    }
}
