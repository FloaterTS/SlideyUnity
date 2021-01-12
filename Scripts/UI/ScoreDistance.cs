using UnityEngine;
using UnityEngine.UI;
public class ScoreDistance : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    
    void Update() // Un mic counter la scorul atins (distanta fata de start) - il folosim la endless mode
    {
        scoreText.text = player.position.z.ToString("0");
    }
}