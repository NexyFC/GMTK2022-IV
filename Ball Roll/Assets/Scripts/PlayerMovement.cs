using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Sprite m_six;
    public Sprite m_five;
    public Sprite m_four;
    public Sprite m_three;
    public Sprite m_two;
    public Sprite m_one;

    private Sprite presetSprite;

    public SpriteRenderer sp;

    
    void Update()
    {
        presetSprite = sp.sprite;

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(presetSprite == m_six)
            {
                sp.sprite = m_five;
            }

            if(presetSprite == m_five)
            {
                sp.sprite = m_one;
            }

            if(presetSprite == m_one)
            {
                sp.sprite = m_two;
            }

            if(presetSprite == m_two)
            {
                sp.sprite = m_six;
            }
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (presetSprite == m_six)
            {
                sp.sprite = m_two;
            }
            if (presetSprite == m_two)
            {
                sp.sprite = m_one;
            }

            if (presetSprite == m_one)
            {
                sp.sprite = m_five;
            }

            if (presetSprite == m_five)
            {
                sp.sprite = m_six;
            }
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (presetSprite == m_six)
            {
                sp.sprite = m_three;
            }
            if (presetSprite == m_three)
            {
                sp.sprite = m_one;
            }

            if (presetSprite == m_one)
            {
                sp.sprite = m_four;
            }

            if (presetSprite == m_four)
            {
                sp.sprite = m_six;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (presetSprite == m_six)
            {
                sp.sprite = m_four;
            }
            if (presetSprite == m_four)
            {
                sp.sprite = m_one;
            }

            if (presetSprite == m_one)
            {
                sp.sprite = m_three;
            }

            if (presetSprite == m_three)
            {
                sp.sprite = m_six;
            }
        }

    }
}
