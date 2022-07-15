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
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                Instantiate(Cell, new Vector3(x, y, 0f), Quaternion.identity);
            }
        }
    }
}
