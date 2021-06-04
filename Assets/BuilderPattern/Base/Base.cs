using UnityEngine;
using System;
using Assets.BuilderPattern.enums.Base;
using Assets.BuilderPattern.Repo;

public class Base : MonoBehaviour
{

    public GameObject ThisBase;
    public GameObject Tank;
    public UnityEngine.Color Fracktion;
    public int HP;
    public int ActiveTanks;
    public bool IsPlayer { get; set; }

    public void Inicialization(UnityEngine.Color fracktion, bool isPlayer)
    {
        Fracktion = fracktion;
        IsPlayer = isPlayer;
        HP = (int)BaseHp.Level1;
        ActiveTanks = (int)BaseTanks.Level1;
    }

    private void Start()
    {
        // ”кажи уроооовень в BaseRepo
        BaseRepo baseRepo = new BaseRepo();
        Tank logic = baseRepo.CreateTankLogical(Fracktion.ToString(), IsPlayer);
        GameObject Physic = Instantiate(Tank, ThisBase.transform.root.position, Quaternion.identity);
        Physic = baseRepo.TankRetuner(Physic, logic);
        CreatingVisualTank visualTank = new CreatingVisualTank();
        Debug.Log(logic.gun.Level);
        visualTank.BuildTank(Physic);
    }
}

