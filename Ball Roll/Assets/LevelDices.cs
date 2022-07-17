using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDices : MonoBehaviour
{
    public void Dice4Click()
    {
        SceneManager.LoadScene(4);
    }
    public void Dice1Click()
    {
        SceneManager.LoadScene(1);
    }
    public void Dice3Click()
    {
        SceneManager.LoadScene(3);
    }
    public void Dice2Click()
    {
        SceneManager.LoadScene(2);
    }
    public void Dice5Click()
    {
        SceneManager.LoadScene(5);
    }
}
