using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            SceneManager.LoadScene("PauseMenu");
    }

    public void ContinueGame() => SceneManager.LoadScene("Level");
    public void GoToMainMenu() => SceneManager.LoadScene("MainMenu");
}