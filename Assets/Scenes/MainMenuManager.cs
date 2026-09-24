
using UnityEngine.SceneManagement;
using UnityEngine;


public class MainMenuManager : MonoBehaviour
{
    public void LoadScene(string MainGame)
    {
        SceneManager.LoadScene(MainGame);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}