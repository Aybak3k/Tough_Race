using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
