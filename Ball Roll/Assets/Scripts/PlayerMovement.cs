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

    public void MoveDown()
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
    public void MoveUp()
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
    public void MoveRight()
    {
            if (presetSprite == m_six)
            {
                sp.sprite = m_five;
            }

            if (presetSprite == m_five)
            {
                sp.sprite = m_one;
            }

            if (presetSprite == m_one)
            {
                sp.sprite = m_two;
            }

            if (presetSprite == m_two)
            {
                sp.sprite = m_six;
            }
    }
    public void MoveLeft()
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

    void Update()
    {
        presetSprite = sp.sprite;

    }
}
