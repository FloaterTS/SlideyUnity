using UnityEngine;
using UnityEngine.UI;

public class ScoreTimer : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    private float score;

    void Start()
    {
        score = Time.time;
    }

    void Update() // un mic counter la scorul atins (secundele trecute de la inceput) - il folosim la endless mode
    {
        score += Time.deltaTime;
        scoreText.text = score.ToString("#.00");
    }
}
