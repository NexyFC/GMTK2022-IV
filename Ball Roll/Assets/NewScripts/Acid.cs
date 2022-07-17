using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acid : MonoBehaviour
{
    [SerializeField] Sprite Dice1;
    [SerializeField] Sprite Dice2;
    [SerializeField] Sprite Dice3;
    [SerializeField] Sprite Dice4;
    [SerializeField] Sprite Dice5;
    [SerializeField] Sprite Dice6;


    [SerializeField] GameObject Player;
    SpriteRenderer SR;

    private void Awake()
    {
        SR = Player.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Kolizja");
        if(SR.sprite == Dice2 || SR.sprite == Dice5)
        {
        }
        else
        {
            collision.GetComponent<CountingMoves>().Ending = true;
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("You are dead");
    }
}
