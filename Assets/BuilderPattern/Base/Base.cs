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
        Tank logic = baseRepo.CreateTankLogical(Fracktion.ToString(), IsPlayer, UnityEngine.Random.Range(1, 3), UnityEngine.Random.Range(1, 3), UnityEngine.Random.Range(1, 3), UnityEngine.Random.Range(1, 2));
        GameObject Physic = Instantiate(Tank, ThisBase.transform.root.position, Quaternion.identity);
        Physic = baseRepo.TankRetuner(Physic, logic);
        CreatingVisualTank visualTank = new CreatingVisualTank();
        visualTank.BuildTank(ref Physic);
    }
}

