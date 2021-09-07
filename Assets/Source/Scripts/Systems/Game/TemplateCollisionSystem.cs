using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using NaughtyAttributes;
using UnityEngine;

public class TemplateCollisionSystem : GameSystem,IIniting
{
    public void OnInit()
    {
        //game.player.GetComponent<TriggerListenerComponent>().OnTriggerEnterEvent += BonusCollisionCheck;
    }
    void TemplateCollisionCheck(Transform other)
    {
        
    }
}
