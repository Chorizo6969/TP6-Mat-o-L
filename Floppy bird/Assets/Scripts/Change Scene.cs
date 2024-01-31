using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Flop");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
