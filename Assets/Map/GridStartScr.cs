
using UnityEngine;

public class GridStartScr : MonoBehaviour
{
    // ���������� ����� �����
    public int gridRowsCount = 10;
    // ���������� ������ �����
    public int gridColumnsCount = 10;
    // ������ ������
    public float cellSize = 10f;
    // �������� ���������� ������ �����
    public Vector3 originPosition = new Vector3(0, 0, 0);

    public int FontSize;
    // ���������� ��� �������� ���������� ������ Grid
    private GridScr grid;

    /**
    * Start
    **/
    private void Start()
    {
        // ������ ����� ��������� ������ Grid, ��������� ��� � ����������
        grid = new GridScr(gridRowsCount, gridColumnsCount, cellSize, FontSize, originPosition);
    }
}