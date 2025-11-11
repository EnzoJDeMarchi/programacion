using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void Retry() =>
        SceneManager.LoadScene("Level"); // reinicia el nivel

    public void BackToMenu() =>
        SceneManager.LoadScene("MainMenu"); // vuelve al menú principal
}