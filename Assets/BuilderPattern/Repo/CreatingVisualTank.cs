namespace Assets.BuilderPattern.Repo
{
    using System;
    using UnityEngine;

    //Visuak creatic tank
    class CreatingVisualTank
    {
        TexturesList textures;
        GameObject CurrentTank;

        public void BuildTank(GameObject tank)
        {
            CurrentTank = tank;
            Gun(CurrentTank.GetComponent<Tank>().gun.Level, CurrentTank.GetComponent<Tank>().gun.Barrels);
            Tower(CurrentTank.GetComponent<Tank>().tower.Level);
            Corpus(CurrentTank.GetComponent<Tank>().corpus.Level);
        }

        private void Gun(int level, int burrel) 
        {
            Transform a = CurrentTank.transform.Find("Gun");
            try
            {
                Debug.Log("CurrentTank.GetComponent<Tank>().gun.Level " + CurrentTank.GetComponent<Tank>().gun.Level);
                Debug.Log("Level" + level);
                Debug.Log(a.GetComponent<SpriteRenderer>().sprite.name);
                if (burrel == 1)
                {
                    a.GetComponent<SpriteRenderer>().sprite = textures.GunsOneBurrel[level];
                }
                else if (burrel == 2)
                {
                    a.GetComponent<SpriteRenderer>().sprite = textures.GunsOneBurrel[level];
                }
            }
            catch (ArgumentOutOfRangeException ex) 
            {
                a.GetComponent<SpriteRenderer>().sprite = null;
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
