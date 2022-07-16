using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Quaternion currentRotation = transform.rotation;
            Quaternion wantedRotation = Quaternion.Euler(-180, 0, 0);
            transform.localRotation = Quaternion.RotateTowards(currentRotation, wantedRotation, 10000f * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Quaternion currentRotation = transform.rotation;
            Quaternion wantedRotation = Quaternion.Euler(180, 0, 0);
            transform.localRotation = Quaternion.RotateTowards(currentRotation, wantedRotation, 10000f * Time.deltaTime);
        }
    }
}
