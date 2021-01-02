using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEngineService : MonoBehaviour
{
    public string sceneName;
    public void endGame() {
        Debug.Log("GameOver");
    }
    public void startGame()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void quit() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}