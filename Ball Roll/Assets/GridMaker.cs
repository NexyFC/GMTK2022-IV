using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMaker : MonoBehaviour
{
    [SerializeField] float GridHeight;
    [SerializeField] float GridWidth;
    [SerializeField] GameObject Cell;

    private void Start()
    {
        GenerateGrid(GridHeight,GridWidth);
    }
    private void GenerateGrid(float Height,float Width)
    {
        Grid grid = GetComponent<Grid>();
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                Vector3 GridPosition = grid.CellToWorld(new Vector3Int(x, y, 0));
                GridPosition.x += 0.5f;
                GridPosition.y += 0.5f;
                Instantiate(Cell, GridPosition, Quaternion.identity);
            }
        }
    }
}
