using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    public float scoreRecord;
    // Update is called once per frame
    void Update()
    {
        if (player.position.z.ToString("0") == "299")
        {
            score.text = "You Win!";
        }
        else if (player.position.y > 0)
        {
            score.text = "Score " + player.position.z.ToString("0");
        }
        else if (player.position.y.ToString("0") == "0")
        {
            scoreRecord = player.position.z;
            score.text = "Score " + scoreRecord.ToString("0");
        }
        else if (player.position.y < 0)
        {
            score.text = "Score " + scoreRecord.ToString("0");
        }
    }
}
