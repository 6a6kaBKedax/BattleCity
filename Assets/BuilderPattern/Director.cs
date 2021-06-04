public class Director
{
    Builder builder;
    public Director(Builder builder)
    {
        this.builder = builder;
    }

    public void CreateGun(int level, int type) 
    {
        builder.BuildGun(level, type);
    }
    public void CreateCorpus(int level)
    {
        builder.BuildCorpus(level);
    }
    public void CreateTower(int level)
    {
        builder.BuildTower(level);
    }
}
