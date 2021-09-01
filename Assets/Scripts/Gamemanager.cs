using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    bool gameEnd = false;
    public float delay = 1f;
    public GameObject completeLevelUI,gameRestart;

    public void GameOver()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            gameRestart.SetActive(true);
            Invoke("Restart", delay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void winLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
