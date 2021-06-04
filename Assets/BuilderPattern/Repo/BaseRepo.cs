class BaseRepo
{
    public void CreateTank()
    {
        Builder builder = new TankRepo("Green", true);
        Director director = new Director(builder);
        director.CreateCorpus(2);
        director.CreateGun(3, false);
        director.CreateTower(1);
    }
}
