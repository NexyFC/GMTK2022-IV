using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private int WhichRotationX=0;
    private int WhichRotationY = 0;
    private int WhichRRotationZ = 0;

    public void RotateDown()
    {
        transform.Rotate(new Vector3(90f, 0f, 0f));
        WhichRotationX++;
        Debug.Log(WhichRotationX);
        switch (WhichRotationX)
        {
            case 1:
                transform.position += new Vector3(0f, -0.5f, 0f);
                break;
            case 2:
                break;
            case 3:
                transform.position += new Vector3(0f, 1f, 0f);
                break;
            case 4:
                transform.position += new Vector3(0f, -0.5f, 0f);
                WhichRotationX = 0;
                break;
        }
    }
}
