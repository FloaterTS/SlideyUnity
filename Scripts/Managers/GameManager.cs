using UnityEngine;
using UnityEngine.SceneManagement;

// GameManager este o clasa "service", care contine cele 3 outcome-uri posibile pentru trecerea dintr-o scena in alta.
public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public float restartDelay = 2f;
    public bool gameHasEnded = false;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
