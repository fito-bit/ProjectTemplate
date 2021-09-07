using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;
using UnityEngine.UI;

public class WinUIScreen : UIScreen
{
    [SerializeField] private Button nextBtn;
    
    public override void Subscribe()
    {
        nextBtn.onClick.AddListener(()=>Bootstrap.GameRestart(0));
        base.Subscribe();
    }
}
