using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Win();
    }

    private void Win()
    {
        //Load next scene or exit to the menu
    }
}
