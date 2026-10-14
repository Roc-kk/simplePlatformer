using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void goToLevel()
    {

        SceneManager.LoadScene("gameScene");
    }

    public void options()
    {
        SceneManager.LoadScene("options");
    }

    public void quit()
    {
        Application.Quit();

        
    }
}
