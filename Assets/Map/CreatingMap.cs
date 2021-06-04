namespace Assets.Map
{
    using UnityEngine;

    class CreatingMap : MonoBehaviour
    {
        public GameObject Base;

        private bool RedBaseExist;
        private bool GreenBaseExist;

        public float SizeOfBlocks;

        public GameObject Block;
        public Vector2 Coordinates;
        public int Rows;
        public int Colums;

        GameObject[,] arrays;

        private GameObject CreateBase(Color Command, Vector2 vector2, bool isplayer) 
        {
            GameObject localBase = Base;
            GameObject a = Instantiate(localBase, localBase.transform.position, Quaternion.identity);
            a.GetComponent<Base>().Inicialization(Command, isplayer);
            a.transform.localPosition = vector2;
            return a;
        }

        public void Start()
        {
            Block.transform.localScale = new Vector3(SizeOfBlocks, SizeOfBlocks);
            Base.transform.localScale = new Vector3(SizeOfBlocks, SizeOfBlocks);

            arrays = new GameObject[Colums, Rows];
            for (int i = 0; i < Colums; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    if (UnityEngine.Random.Range(0, 3) == 2)
                    {
                        Vector2 vector = new Vector2(Coordinates.x + i, Coordinates.y + j);
                        Transform transform = Block.transform;
                        GameObject a = Instantiate(Block, Block.transform.position, Quaternion.identity);
                        a.transform.localPosition = vector;
                        arrays[i, j] = a;
                        continue;
                    }
                    if (GreenBaseExist == false && UnityEngine.Random.Range(0, 50) == 2)
                    {
                        arrays[i, j] = CreateBase(Color.green, new Vector2(Coordinates.x + i, Coordinates.y + j), true);
                        GreenBaseExist = true;
                        continue;
                    }
                    if (RedBaseExist == false && UnityEngine.Random.Range(0, 50) == 2)
                    {
                        arrays[i, j] = CreateBase(Color.red, new Vector2(Coordinates.x + i, Coordinates.y + j), false);
                        RedBaseExist = true;
                        continue;
                    }
                }
            }
            while (GreenBaseExist == false)
            {
                int i = UnityEngine.Random.Range(0, Colums - 1);
                int j = UnityEngine.Random.Range(0, Rows - 1);
                if (arrays[i , j] == null)
                {
                    CreateBase(Color.green, new Vector2(Coordinates.x + i, Coordinates.y + j), true);
                    GreenBaseExist = true;
                }
            }
            while (RedBaseExist == false)
            {
                int i = UnityEngine.Random.Range(0, Colums - 1);
                int j = UnityEngine.Random.Range(0, Rows - 1);
                if (arrays[i, j] == null)
                {
                    CreateBase(Color.red, new Vector2(Coordinates.x + i, Coordinates.y + j), false);
                    RedBaseExist = true;
                }
            }
        }
    }
}
