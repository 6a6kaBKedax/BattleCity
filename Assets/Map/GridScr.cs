using UnityEngine;

// Объявляем структуру GridCell
public struct GridCell
{
    public int cellValue;
    public TextMesh textMesh;
}

public class GridScr
{
    // Ширина сетки
    private int columns;
    // Высота сетки
    private int rows;
    // Размер клетки
    private float cellSize;

    private int FontSize;
    // Координата, с которой будет начинаться наша сетка
    private Vector3 originPosition;

    // Двумерный массив, в котором мы будем хранить значения ячеек и объекты textMesh
    private GridCell[,] gridCellsArray;

    /**
    * Конструктор для создания экземпляра класса Grid
    * Constructor <Grid>
    * @param {width} int 
    * @param {height} int 
    * @param {cellSize} float 
    **/
    public GridScr(int rows, int columns, float cellSize, int fontsize, Vector3 originPosition)
    {
        // Ассоциируем принятые значения с экземплярами класса 
        this.rows = rows;
        this.columns = columns;
        this.cellSize = cellSize;
        this.originPosition = originPosition;
        this.FontSize = fontsize;

        // Инициируем двумерный массив
        gridCellsArray = new GridCell[columns, rows];

        /**
        * Проходим весь двумерный массив при помощи циклов
        * Переменная masterIndex будет увеличиваться на единицу кажую пройденную ячейку массива
        **/
        for (int rowIndex = 0, masterIndex = 0; rowIndex < gridCellsArray.GetLength(0); rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < gridCellsArray.GetLength(1); columnIndex++, masterIndex++)
            {
                // Ассоциируем значение masterIndex в ячейки
                if (Random.Range(0, 4) == 3)
                {
                    gridCellsArray[rowIndex, columnIndex].cellValue = 1;
                    continue;
                }
                gridCellsArray[rowIndex, columnIndex].cellValue = 0;
                // Создаём текст при помощи TextMesh, сохраняем созданные объекты в массиве debugTextArray
                gridCellsArray[rowIndex, columnIndex].textMesh = CreateWorldTextMesh(
                  masterIndex.ToString(),
                  GetCellWorldPosition(rowIndex, columnIndex) + new Vector3(cellSize, cellSize) * .5f
                );

                // Рисуем линии сетки. Если они не нужны, можно их не добавлять
                Debug.DrawLine(GetCellWorldPosition(rowIndex, columnIndex), GetCellWorldPosition(rowIndex, columnIndex + 1), Color.white, 100f);
                Debug.DrawLine(GetCellWorldPosition(rowIndex, columnIndex), GetCellWorldPosition(rowIndex + 1, columnIndex), Color.white, 100f);
            }
        }

        // Закрываем внешнии линии сетки
        Debug.DrawLine(GetCellWorldPosition(0, columns), GetCellWorldPosition(rows, columns), Color.white, 100f);
        Debug.DrawLine(GetCellWorldPosition(rows, 0), GetCellWorldPosition(rows, columns), Color.white, 100f);
    }

    /** 
    * Получаем координаты левого нижнего угла текущей ячейки
    * @param {int} rowIndex 
    * @param {int} columnIndex 
    * @return {Vector3} position 
    **/
    private Vector3 GetCellWorldPosition(int rowIndex, int columnIndex)
    {
        return new Vector3(rowIndex, columnIndex) * cellSize + originPosition;
    }

    /**
      * Создание и вывод на экран текста при помощи TextMesh
      * @param {string} text 
      * @param {Vector3} localPosition 
      * @param {int} fontSize 
      * @return {TextMesh} TextMesh object
      **/
    private TextMesh CreateWorldTextMesh(string text, Vector3 localPosition = default(Vector3))
    {
        GameObject gameObject = new GameObject("World_Text", typeof(TextMesh));
        Transform transform = gameObject.transform;
        TextMesh textMesh = gameObject.GetComponent<TextMesh>();

        transform.localPosition = localPosition;
        textMesh.anchor = TextAnchor.MiddleCenter;
        textMesh.alignment = TextAlignment.Center;
        textMesh.text = text;
        textMesh.fontSize = FontSize;
        textMesh.color = Color.black;

        return textMesh;
    }
}