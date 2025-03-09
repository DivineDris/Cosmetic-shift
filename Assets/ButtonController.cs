using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private string playLevel = "Level1";
    public void PlayButton()
    {
        SceneManager.LoadScene(playLevel);
    }
     public void QuitButton()
    {
        Application.Quit();
    }
}
