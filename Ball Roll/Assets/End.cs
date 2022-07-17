using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 currentPos = transform.position;

        if(playerPos.x == currentPos.x && playerPos.y == currentPos.y)
        {
            // Go To level completed screen
            Debug.Log("Next Level");
        }
    }
}
