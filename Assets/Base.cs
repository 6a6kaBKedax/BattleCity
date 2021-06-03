using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public string Fracktion { get; set; }
    public int HP { get; set; }

    public void CreateTank()
    {
        Builder builder = new TankRepo("Green");
        Director director = new Director(builder);
        director.CreateCorpus(2);
        director.CreateGun(3, false);
        director.CreateTower(1);
    }
}

