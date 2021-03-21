using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEngineService : MonoBehaviour
{
    public string sceneName;
    public float personalHighscore;
    private TimerService timerService;

    void Start() {
        Debug.Log("Welcome to the game");
        timerService = FindObjectOfType<TimerService>();
        personalHighscore = getPersonalHighscore();
        Debug.Log(personalHighscore);
    }
    public void endGame() {
        Debug.Log("GameOver");
    }

    public void wonGame() {
        Debug.Log("Win");
        
        // 1. Stop timer
        timerService.stopTime();
        // 2. Set final time
        timerService.setFinalTime(timerService.currentTime);
        // 3. Set new Highscore, if possible
        setPersonalHighscore(timerService.getFinalTime());
        // 4. FInally Load Success Screne
        SceneManager.LoadScene("SuccessScrene");
    }

    public void goToScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void resetHighscore() {
        PlayerPrefs.DeleteKey("PersonalHighscore");
    }

    public float getPersonalHighscore() {
        return PlayerPrefs.GetFloat("PersonalHighscore");
    }

    public void setPersonalHighscore(float newHighscore) {
        if (personalHighscore > newHighscore || personalHighscore == 0) {
            PlayerPrefs.SetFloat("PersonalHighscore", newHighscore);
        }
    }

    public void quit() {
        // two ways of ending the game
        // 1. End game in editor
        // 2. End game while playing
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}