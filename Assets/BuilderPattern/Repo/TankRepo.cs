public class TankRepo : Builder
{
    private string Fracktion;
    public Tank Tank = new Tank();
    public TankRepo(string Fracktion)
    {
        this.Fracktion = Fracktion;
        Tank.Fracktion = this.Fracktion;
    }
    override public void BuildTower(int Level)
    {
        Tower tower = new Tower();
        tower.Level = Level;
        switch (Level)
        {
            case 1 : tower.Accuracy = 0.1 * (int)TowerAccurace.Level1; break;
            case 2 : tower.Accuracy = 0.1 * (int)TowerAccurace.Level2; break;
            case 3 : tower.Accuracy = 0.1 * (int)TowerAccurace.Level3; break;
            default:
                break;
        }
    }

    public override void BuildGun(int level, bool type)
    {
        Gun gun = new Gun();
        gun.Level = level;
        gun.Type = type;
        if (type)
        {
            switch (level)
            {
                case 1: gun.Damage = (int)TrueGunDamage.Level1; gun.Range = (int)TrueGunAccuracy.Level1; break;
                case 2: gun.Damage = (int)TrueGunDamage.Level2; gun.Range = (int)TrueGunAccuracy.Level2; break;
                case 3: gun.Damage = (int)TrueGunDamage.Level3; gun.Range = (int)TrueGunAccuracy.Level3; break;
                default:
                    break;
            }
        }
        else
        {
            switch (level)
            {
                case 1: gun.Damage = (int)FalseGunDamage.Level1; gun.Range = (int)FalseGunAccuracy.Level1; break;
                case 2: gun.Damage = (int)FalseGunDamage.Level2; gun.Range = (int)FalseGunAccuracy.Level2; break;
                case 3: gun.Damage = (int)FalseGunDamage.Level3; gun.Range = (int)FalseGunAccuracy.Level3; break;
                default:
                    break;
            }
        }
    }

    public override void BuildCorpus(int level)
    {
        Corpus corpus = new Corpus();
        corpus.Level = level;
        switch (level)
        {
            case 1: corpus.HP = (int)CorpusHP.Level1; corpus.Speed = (int) CorpusSpeed.Level1; break;
            case 2: corpus.HP = (int)CorpusHP.Level2; corpus.Speed = (int) CorpusSpeed.Level2; break;
            case 3: corpus.HP = (int)CorpusHP.Level3; corpus.Speed = (int) CorpusSpeed.Level3; break;
            default:
                break;
        }
    }

    public override Tank GetTank()
    {
        return Tank;
    }
}
