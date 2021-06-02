public class TankRepo
{
    public Tower AddTower(int Level)
    {
        Tower tower = new Tower();
        tower.Accuracy = 0.1 * (int)TowerAccurace.Level1;
        switch (Level)
        {
            case 1 : tower.Accuracy = 0.1 * (int)TowerAccurace.Level1; break;
            case 2 : tower.Accuracy = 0.1 * (int)TowerAccurace.Level2; break;
            case 3 : tower.Accuracy = 0.1 * (int)TowerAccurace.Level3; break;
            default:
                break;
        }
        return tower;
    }

    public void Add(int Level, bool Type)
    {

    }
}
