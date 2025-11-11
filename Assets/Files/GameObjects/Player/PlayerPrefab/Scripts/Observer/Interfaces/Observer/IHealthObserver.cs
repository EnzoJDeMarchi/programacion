using UnityEngine;

public interface IHealthObserver
{
    void OnHealthChanged(int value);
}