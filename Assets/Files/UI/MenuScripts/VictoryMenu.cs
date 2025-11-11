using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("Level");
    }

    public void BackToMenu() =>
        SceneManager.LoadScene("MainMenu");
}