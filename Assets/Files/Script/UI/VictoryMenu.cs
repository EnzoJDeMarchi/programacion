using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    public void PlayAgain() => SceneManager.LoadScene("Level");
    public void GoToMainMenu() => SceneManager.LoadScene("MainMenu");
}