using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() =>
        SceneManager.LoadScene("Level"); // carga la escena principal

    public void QuitGame() =>
        Application.Quit(); // cierra el juego
}