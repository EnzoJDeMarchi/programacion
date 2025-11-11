using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour, IHealthObserver
{
    [SerializeField] PlayerLife playerLife;
    [SerializeField] Slider healthBar;

    void Start()
    {
        playerLife.Subscribe(this);
    }

    public void OnHealthChanged(int value)
    {
        healthBar.value = value;
    }
}