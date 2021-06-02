using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridStartSCr : MonoBehaviour
{

    public int gridRowsCount = 10;
   
    public int gridColumnsCount = 10;
    
    public float cellSize = 10f;

    private GridScr grid;

    /**
    * Start
    **/
    private void Start()
    {
        grid = new GridScr(gridRowsCount, gridColumnsCount, cellSize);
    }
}