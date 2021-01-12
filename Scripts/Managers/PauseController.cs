using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public static bool gameIsPaused;

    public GameObject pauseMenuUI;
    public GameObject pauseButtonUI;

    private void Start()
    {
        // La inceutul jocului, meniul de pauza este ascuns
        gameIsPaused = false;
        pauseButtonUI.SetActive(false);
        pauseMenuUI.SetActive(false);
    }
    
    public void PauseOrResume()
    {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
    }

    public void Resume() // functie care da drumul la joc (permite trecerea timpului)
    {
        pauseMenuUI.SetActive(false);
        pauseButtonUI.SetActive(true);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    private void Pause() // functie care opreste trecerea timpului (pune pauza)
    {
        pauseMenuUI.SetActive(true);
        pauseButtonUI.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void LoadMenu() // functie care incarca scena meniului
    {
        Resume();
        SceneManager.LoadScene("Menu");
    }

    public void Restart() // functie care reincarca scena curenta (restart)
    {
        Resume();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame() // functie care inchide jocul
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}