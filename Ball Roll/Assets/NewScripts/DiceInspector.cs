using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceInspector : MonoBehaviour
{
    [SerializeField] GameObject Face;
    [SerializeField] GameObject FaceUp;
    [SerializeField] GameObject FaceDown;
    [SerializeField] GameObject FaceLeft;
    [SerializeField] GameObject FaceRight;

    [SerializeField] Sprite Dice1;
    [SerializeField] Sprite Dice2;
    [SerializeField] Sprite Dice3;
    [SerializeField] Sprite Dice4;
    [SerializeField] Sprite Dice5;
    [SerializeField] Sprite Dice6;

    List<Sprite> LS;

    Dice dice = new Dice();

    [SerializeField] GameObject Player;
    PlayerMovement PM;

    private void Awake()
    {
        PM = Player.GetComponent<PlayerMovement>();
        LS = new List<Sprite>() { Dice1, Dice2, Dice3, Dice4, Dice5, Dice6 };
    }

    private void Update()
    {
        Face.GetComponent<SpriteRenderer>().sprite = LS[dice.getValue() - 1];
        dice.currentStateIndex = PM.CurrentDice;

        dice.RollDown();
        FaceUp.GetComponent<SpriteRenderer>().sprite = LS[dice.getValue() - 1];
        dice.currentStateIndex = PM.CurrentDice;

        dice.RollRight();
        FaceLeft.GetComponent<SpriteRenderer>().sprite = LS[dice.getValue() - 1];
        dice.currentStateIndex = PM.CurrentDice;

        dice.RollUp();
        FaceDown.GetComponent<SpriteRenderer>().sprite = LS[dice.getValue() - 1];
        dice.currentStateIndex = PM.CurrentDice;

        dice.RollLeft();
        FaceRight.GetComponent<SpriteRenderer>().sprite = LS[dice.getValue() - 1];
        dice.currentStateIndex = PM.CurrentDice;
    }
}
