using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Win();
    }

    private void Win()
    {
        SceneManager.LoadScene(0);//Loads Menu
    }
}
