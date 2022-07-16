using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] Sprite Dice1;
    [SerializeField] Sprite Dice2;
    [SerializeField] Sprite Dice3;
    [SerializeField] Sprite Dice4;
    [SerializeField] Sprite Dice5;
    [SerializeField] Sprite Dice6;

    private List<Sprite> SpriteList;

    private SpriteRenderer SR;

    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
        SpriteList = new List<Sprite>() { Dice1, Dice2, Dice3, Dice4, Dice5, Dice6 };
    }

    Dice dice = new Dice();
    public void GoDown()
    {
        dice.RollDown();
        SR.sprite = SpriteList[dice.getValue()-1];
    }
    public void GoUp()
    {
        dice.RollUp();
        SR.sprite = SpriteList[dice.getValue() - 1];
    }
    public void GoLeft()
    {
        dice.RollLeft();
        SR.sprite = SpriteList[dice.getValue() - 1];
    }
    public void GoRIght()
    {
        dice.RollRight();
        SR.sprite = SpriteList[dice.getValue() - 1];
    }
=======
    
}
