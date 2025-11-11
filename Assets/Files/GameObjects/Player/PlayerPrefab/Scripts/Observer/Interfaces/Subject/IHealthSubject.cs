using UnityEngine;

public interface IHealthSubject
{
    void Subscribe(IHealthObserver observer);
    void Unsubscribe(IHealthObserver observer);
}