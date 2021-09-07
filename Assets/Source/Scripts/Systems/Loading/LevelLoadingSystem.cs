using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Kuhpik;
using UnityEngine;

public class LevelLoadingSystem : GameSystem, IIniting
{
    [SerializeField] private string levelsPath;
    [SerializeField] private int maxLevel;

    public void OnInit()
    {
        int level;
        GameObject levelGo;
        level = Mathf.Clamp(player.earnedLevel, 0, maxLevel - 1);
        levelGo = new GameObject();
        levelGo = Resources.Load<GameObject>(String.Format(levelsPath, level + 1));
        game.level = Instantiate(levelGo, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
