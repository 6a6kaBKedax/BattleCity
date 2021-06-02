
using UnityEngine;

public class GridStartScr : MonoBehaviour
{
    // Количество строк сетки
    public int gridRowsCount = 10;
    // Количество колонн сетки
    public int gridColumnsCount = 10;
    // Размер клетки
    public float cellSize = 10f;
    // Выбираем координаты начала сетки
    public Vector3 originPosition = new Vector3(0, 0, 0);

    public int FontSize;
    // Переменная для хранения экземпляра класса Grid
    private GridScr grid;

    /**
    * Start
    **/
    private void Start()
    {
        // Создаём новый экземпляр класса Grid, сохраняем его в переменной
        grid = new GridScr(gridRowsCount, gridColumnsCount, cellSize, FontSize, originPosition);
    }
}