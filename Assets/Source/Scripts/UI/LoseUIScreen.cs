using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;
using UnityEngine.UI;

public class LoseUIScreen : UIScreen
{
    [SerializeField] private Button retryBtn;
    
    public override void Subscribe()
    {
        retryBtn.onClick.AddListener(()=>Bootstrap.GameRestart(0));
        base.Subscribe();
    }
}
