using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionListenerComponent : MonoBehaviour
{
    public event Action<Transform> OnCollisionEnterEvent;

    private void OnCollisionEnter(Collision other)
    {
        OnCollisionEnterEvent?.Invoke(other.transform);
    }
}
