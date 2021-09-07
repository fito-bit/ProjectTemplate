using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerListenerComponent : MonoBehaviour
{
    public event Action<Transform> OnTriggerEnterEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        OnTriggerEnterEvent?.Invoke(other.transform);
    }
}
