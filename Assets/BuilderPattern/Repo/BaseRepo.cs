using UnityEngine;
class BaseRepo
{
    GameObject TankZagl;

    public Tank CreateTankLogical(string team, bool isplayer)
    {
        Builder builder = new TankRepo(team, isplayer);
        Director director = new Director(builder);
        director.CreateCorpus(2);
        director.CreateGun(3, 2);
        director.CreateTower(1);

        return builder.GetTank();
    }

    public GameObject TankRetuner(GameObject Physial, Tank Logial) 
    {
        Physial.GetComponent<Tank>().corpus = Logial.corpus;
        Physial.GetComponent<Tank>().tower = Logial.tower;
        Physial.GetComponent<Tank>().gun = Logial.gun;
        Physial.GetComponent<Tank>().TankId = Logial.TankId;
        Physial.GetComponent<Tank>().Fracktion = Logial.Fracktion;
        Physial.GetComponent<Tank>().IsPlayer = Logial.IsPlayer;

        return Physial;
    }
}
