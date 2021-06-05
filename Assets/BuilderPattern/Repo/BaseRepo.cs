using UnityEngine;
class BaseRepo
{
    GameObject TankZagl;

    public Tank CreateTankLogical(string team, bool isplayer, int corpusLevel, int towerLevel, int gunLevel, int burrelsGun)
    {
        Builder builder = new TankRepo(team, isplayer);
        Director director = new Director(builder);
        director.CreateCorpus(corpusLevel);
        director.CreateGun(gunLevel, burrelsGun);
        director.CreateTower(towerLevel);

        //Tank a = builder.GetTank();
        //Debug.Log($"Corpus stats. Level: {a.corpus.Level}, HP: {a.corpus.HP}, Speed: {a.corpus.Speed}");
        //Debug.Log($"Gun stats. Level: {a.gun.Level}, Damage: {a.gun.Damage}, Barels: {a.gun.Barrels}, Range {a.gun.Range} ");
        //Debug.Log($"Tower stats. Level: {a.tower.Level}, HP: {a.tower.Accuracy}");

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
