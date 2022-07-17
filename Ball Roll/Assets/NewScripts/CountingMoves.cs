using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountingMoves : MonoBehaviour
{
    public int RemainingMoves;

    [SerializeField] GameObject EndingText;
    [SerializeField] GameObject ScoreText;

    private Text ST;

    public bool Ending = false;

    private void Awake()
    {
        ST = ScoreText.GetComponent<Text>();
    }

    public void Moved()
    {
        RemainingMoves--;
        if(RemainingMoves <= 0)
        {
            Ending = true;
        }
        ST.text = "Remaining Moves: " + RemainingMoves.ToString();
    }
    public void Update()
    {
        if (Ending)
        {
            GetComponent<PlayerMovement1>().enabled = false;
            EndingText.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
