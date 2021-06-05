namespace Assets.BuilderPattern.Repo
{
    using System;
    using UnityEngine;

    //Visuak creatic tank
    class CreatingVisualTank
    {
        TexturesList textures;
        GameObject CurrentTank;

        public void BuildTank(ref GameObject tank)
        {
            CurrentTank = tank;
            Gun(CurrentTank.GetComponent<Tank>().gun.Level, CurrentTank.GetComponent<Tank>().gun.Barrels);
            Tower(CurrentTank.GetComponent<Tank>().tower.Level);
            Corpus(CurrentTank.GetComponent<Tank>().corpus.Level);
            tank = CurrentTank;
        }

        private void Gun(int level, int burrel) 
        {
            if (burrel == 1)
            {
                CurrentTank.gameObject.transform.Find("Gun").GetComponent<SpriteRenderer>().sprite = textures.GunsOneBurrel[level];
            }
            else if (burrel == 2)
            {
                CurrentTank.gameObject.transform.Find("Gun").GetComponent<SpriteRenderer>().sprite = textures.GunsTwoBurrels[level];
            }
        }

        private void Tower(int level) 
        {
            Transform a = CurrentTank.transform.Find("Tower");
            a.GetComponent<SpriteRenderer>().sprite = textures.GunsOneBurrel[CurrentTank.GetComponent<Tank>().tower.Level - 1];
        }

        private void Corpus(int level)
        {
            Transform a = CurrentTank.transform.Find("Corpus");
            a.GetComponent<SpriteRenderer>().sprite = textures.GunsOneBurrel[CurrentTank.GetComponent<Tank>().corpus.Level - 1];
        }
    }
}
