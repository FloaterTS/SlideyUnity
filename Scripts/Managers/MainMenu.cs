using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartMenu() // Metoda care se apeleaza o singura data, la inceperea jocului
    {
        Debug.Log("STARTED");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit() // Metoda care se apeleaza o singura data, la terminarea jocului
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
