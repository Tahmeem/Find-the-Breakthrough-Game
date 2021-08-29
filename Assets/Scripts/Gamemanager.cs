using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    bool gameEnd = false;
    public float delay = 1f;
    public void GameOver()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("Game Over!");
            Invoke("Restart", delay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
