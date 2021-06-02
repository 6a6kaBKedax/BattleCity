abstract class Builder
{
    public abstract void BuildGun(int level, bool type);
    public abstract void BuildTower(int level);
    public abstract void BuildCorpus(int level);
    public abstract Tank GetTank();
}
