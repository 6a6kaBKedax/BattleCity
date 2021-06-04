using UnityEngine;
using System;
using Assets.BuilderPattern.enums.Base;

public class Base : MonoBehaviour
{
    public UnityEngine.Color Fracktion;
    public int HP;
    public int ActiveTanks;

    public void Inicialization(UnityEngine.Color fracktion)
    {
        Fracktion = fracktion;
        HP = (int)BaseHp.Level1;
        ActiveTanks = (int)BaseTanks.Level1;
    }
}

