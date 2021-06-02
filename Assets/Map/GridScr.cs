using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScr
{
    // ������ �����
    private int columns;
    // ������ �����
    private int rows;
    // ������ ������
    private float cellSize;
    // ��������� ������, � ������� �� ����� ������� �������� �����
    private int[,] gridArray;

    /**
    * ����������� ��� �������� ���������� ������ Grid
    * Constructor <Grid>
    * @param {width} int 
    * @param {height} int 
    * @param {cellSize} float 
    **/
    public GridScr(int rows, int columns, float cellSize)
    {
        // ����������� �������� �������� � ������������ ������ 
        this.rows = rows;
        this.columns = columns;
        this.cellSize = cellSize;

        // ���������� ��������� ������
        gridArray = new int[columns, rows];

        /**
        * �������� ���� ��������� ������ ��� ������ ������
        * ���������� masterIndex ����� ������������� �� ������� ����� ���������� ������ �������
        **/
        for (int rowIndex = 0, masterIndex = 0; rowIndex < gridArray.GetLength(0); rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < gridArray.GetLength(1); columnIndex++, masterIndex++)
            {
                // ����������� �������� masterIndex � ������

                if (Random.Range(0, 4) == 3)
                {
                    gridArray[rowIndex, columnIndex] = 1;
                    continue;
                }
                gridArray[rowIndex, columnIndex] = 0;

            }
        }
    }
}