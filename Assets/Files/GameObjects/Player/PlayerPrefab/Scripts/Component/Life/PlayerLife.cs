using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour, IHealthSubject
{
    [SerializeField] int maxHealth = 100;
    [SerializeField] Slider healthBar;

    int currentHealth;
    List<IHealthObserver> observers = new();

    // Observer action
    public event Action<int> OnHealthChanged;

    void Awake()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;

        NotifyObservers();
        OnHealthChanged?.Invoke(currentHealth); // action
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        healthBar.value = currentHealth;

        NotifyObservers();
        OnHealthChanged?.Invoke(currentHealth); // action

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverMenu");
        }
    }

    public void Subscribe(IHealthObserver observer)
    {
        if (!observers.Contains(observer))
            observers.Add(observer);
    }

    public void Unsubscribe(IHealthObserver observer)
    {
        if (observers.Contains(observer))
            observers.Remove(observer);
    }

    void NotifyObservers()
    {
        foreach (var obs in observers)
            obs.OnHealthChanged(currentHealth);
    }
}