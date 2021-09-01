using UnityEngine;
using UnityEngine.SceneManagement;


public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Game Quitted");
        Application.Quit();
    }
    public void Replay()
    {
        SceneManager.LoadScene("Level1");
    }
}
