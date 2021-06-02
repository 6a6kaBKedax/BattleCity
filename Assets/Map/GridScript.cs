using System.Collections;

using UnityEngine;

public class GridScript : MonoBehaviour
{
    private  GameObject[,] Grid;
    private GameObject Block;
    private GameObject BaseEnemy;
    private GameObject BaseFriend;

    private float SizeOfBlock; 

    private int Colums;
    private int Rows;

    private Vector2 FirstPos;

    private  bool BaseEnemyExist;
    private  bool BaseFriendExist;

    public GridScript(int Colums, int Rows)
    {

        for (int i = 0; i < Colums; i++)
        {
            for (int j = 0; j < Rows; j++)
            {
                if (Random.Range(0, 4) == 3)
                {
                    Grid[Colums, Rows] = Block;
                    continue;
                }
                if (Random.Range(0, 6) == 3)
                {
                    Grid[Colums, Rows] = BaseFriend;
                    BaseFriendExist = true;
                    continue;
                }
                if (Random.Range(0, 6) == 3)
                {
                    Grid[Colums, Rows] = BaseEnemy;
                    BaseEnemyExist = true;
                    continue;
                }
            }
        }
        if (BaseFriendExist == false)
        {
            int row = Random.Range(1, 39);
            int column = Random.Range(1, 39);

            if (Grid[column, row] != BaseEnemy)
            {
                Grid[column, row] = BaseFriend;
            }
        }
        if (BaseEnemyExist == false)
        {
            int row = Random.Range(1, 39);
            int column = Random.Range(1, 39);

            if (Grid[column, row] != BaseFriend)
            {
                Grid[column, row] = BaseEnemy;
            }
        }
    }

    private Vector2 GetCellWorldPosition(int rowIndex, int columnIndex)
    {
        return new Vector2(rowIndex, columnIndex) * SizeOfBlock + FirstPos;
    }

    private void CreateEntity(GameObject obj, Vector2 localPosition = default(Vector2))
    {
        GameObject gameObject = Block;
        Transform transform = gameObject.transform;
        transform.localPosition = localPosition;

        gameObject.transform.position = transform.localPosition;



    }
}
