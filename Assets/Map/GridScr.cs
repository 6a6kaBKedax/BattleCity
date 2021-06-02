using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScr
{
    // Ширина сетки
    private int columns;
    // Высота сетки
    private int rows;
    // Размер клетки
    private float cellSize;
    // Двумерный массив, в котором мы будем хранить значения ячеек
    private int[,] gridArray;

    /**
    * Конструктор для создания экземпляра класса Grid
    * Constructor <Grid>
    * @param {width} int 
    * @param {height} int 
    * @param {cellSize} float 
    **/
    public GridScr(int rows, int columns, float cellSize)
    {
        // Ассоциируем принятые значения с экземплярами класса 
        this.rows = rows;
        this.columns = columns;
        this.cellSize = cellSize;

        // Инициируем двумерный массив
        gridArray = new int[columns, rows];

        /**
        * Проходим весь двумерный массив при помощи циклов
        * Переменная masterIndex будет увеличиваться на единицу кажую пройденную ячейку массива
        **/
        for (int rowIndex = 0, masterIndex = 0; rowIndex < gridArray.GetLength(0); rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < gridArray.GetLength(1); columnIndex++, masterIndex++)
            {
                // Ассоциируем значение masterIndex в ячейки

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