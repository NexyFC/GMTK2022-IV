using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    public Sprite m_six;
    public Sprite m_five;
    public Sprite m_four;
    public Sprite m_three;
    public Sprite m_two;
    public Sprite m_one;

    private Sprite presetSprite;

    public SpriteRenderer sp;
    public Transform wall;

    void Update()
    {
        presetSprite = sp.sprite;

        if (presetSprite == m_six)
        {
            return;
        }

        if(presetSprite == m_five)
        {
            return;
        }

        if(presetSprite == m_four)
        {
            if(transform.position.y == 0.5 || transform.position.y == 1.5)
            {
                Debug.Log("Activate");
            }
        }
    }
}
