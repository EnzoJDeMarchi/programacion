using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseTrigger : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            SceneManager.LoadScene("PauseMenu");
    }
}