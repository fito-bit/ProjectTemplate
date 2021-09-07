using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;
using UnityEngine.UI;

public class MenuUiScreen : UIScreen
{
    [SerializeField] private Button tapTSBtn;
    
    public override void Subscribe()
    {
        tapTSBtn.onClick.AddListener(() => Bootstrap.ChangeGameState(EGamestate.Game));
        base.Subscribe();
    }
}
