using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] Image bar;

    int hp;

    void Start() => hp = max;

    public void Damage(int d)
    {
        hp -= d;
        if (hp <= 0)
        {
            SceneManager.LoadScene("GameOverMenu");
            return;
        }
        if (bar) bar.fillAmount = (float)hp / max;
    }
}