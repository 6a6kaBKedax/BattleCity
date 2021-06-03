using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.BuilderPattern.enums.Base;

public class Base : MonoBehaviour
{
    private string Fracktion;
    public int HP;
    public int ActiveTanks;

    public Base(string Fracktion, Transform transform)
    {
        this.Fracktion = Fracktion;
        this.HP = (int)BaseHp.Level1;
        this.ActiveTanks = (int)BaseTanks.Level1;
    }
}

