using UnityEngine;

// ��������� ��������� GridCell
public struct GridCell
{
    public int cellValue;
    public TextMesh textMesh;
}

public class GridScr
{
    // ������ �����
    private int columns;
    // ������ �����
    private int rows;
    // ������ ������
    private float cellSize;

    private int FontSize;
    // ����������, � ������� ����� ���������� ���� �����
    private Vector3 originPosition;

    // ��������� ������, � ������� �� ����� ������� �������� ����� � ������� textMesh
    private GridCell[,] gridCellsArray;

    /**
    * ����������� ��� �������� ���������� ������ Grid
    * Constructor <Grid>
    * @param {width} int 
    * @param {height} int 
    * @param {cellSize} float 
    **/
    public GridScr(int rows, int columns, float cellSize, int fontsize, Vector3 originPosition)
    {
        // ����������� �������� �������� � ������������ ������ 
        this.rows = rows;
        this.columns = columns;
        this.cellSize = cellSize;
        this.originPosition = originPosition;
        this.FontSize = fontsize;

        // ���������� ��������� ������
        gridCellsArray = new GridCell[columns, rows];

        /**
        * �������� ���� ��������� ������ ��� ������ ������
        * ���������� masterIndex ����� ������������� �� ������� ����� ���������� ������ �������
        **/
        for (int rowIndex = 0, masterIndex = 0; rowIndex < gridCellsArray.GetLength(0); rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < gridCellsArray.GetLength(1); columnIndex++, masterIndex++)
            {
                // ����������� �������� masterIndex � ������
                if (Random.Range(0, 4) == 3)
                {
                    gridCellsArray[rowIndex, columnIndex].cellValue = 1;
                    continue;
                }
                gridCellsArray[rowIndex, columnIndex].cellValue = 0;
                // ������ ����� ��� ������ TextMesh, ��������� ��������� ������� � ������� debugTextArray
                gridCellsArray[rowIndex, columnIndex].textMesh = CreateWorldTextMesh(
                  masterIndex.ToString(),
                  GetCellWorldPosition(rowIndex, columnIndex) + new Vector3(cellSize, cellSize) * .5f
                );

                // ������ ����� �����. ���� ��� �� �����, ����� �� �� ���������
                Debug.DrawLine(GetCellWorldPosition(rowIndex, columnIndex), GetCellWorldPosition(rowIndex, columnIndex + 1), Color.white, 100f);
                Debug.DrawLine(GetCellWorldPosition(rowIndex, columnIndex), GetCellWorldPosition(rowIndex + 1, columnIndex), Color.white, 100f);
            }
        }

        // ��������� ������� ����� �����
        Debug.DrawLine(GetCellWorldPosition(0, columns), GetCellWorldPosition(rows, columns), Color.white, 100f);
        Debug.DrawLine(GetCellWorldPosition(rows, 0), GetCellWorldPosition(rows, columns), Color.white, 100f);
    }

    /** 
    * �������� ���������� ������ ������� ���� ������� ������
    * @param {int} rowIndex 
    * @param {int} columnIndex 
    * @return {Vector3} position 
    **/
    private Vector3 GetCellWorldPosition(int rowIndex, int columnIndex)
    {
        return new Vector3(rowIndex, columnIndex) * cellSize + originPosition;
    }

    /**
      * �������� � ����� �� ����� ������ ��� ������ TextMesh
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