using UnityEngine;

public interface IPrototype<T>
{
    T Clone();
}