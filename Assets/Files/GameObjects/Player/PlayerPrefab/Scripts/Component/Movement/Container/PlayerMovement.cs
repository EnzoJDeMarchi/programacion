using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    IMovement movement;

    void Awake()
    {
        movement = GetComponent<IMovement>();
    }

    void Update()
    {
        Vector2 dir = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) dir += Vector2.up;
        if (Input.GetKey(KeyCode.S)) dir += Vector2.down;
        if (Input.GetKey(KeyCode.A)) dir += Vector2.left;
        if (Input.GetKey(KeyCode.D)) dir += Vector2.right;

        if (dir != Vector2.zero)
            movement?.Move(dir.normalized);

        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("PauseMenu");
        }
    }
}