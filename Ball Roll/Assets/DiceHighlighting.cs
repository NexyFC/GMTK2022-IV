using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceHighlighting : MonoBehaviour
{
    public Sprite m_six;
    public Sprite m_five;
    public Sprite m_four;
    public Sprite m_three;
    public Sprite m_two;
    public Sprite m_one;

    private Sprite presetSprite;

    public SpriteRenderer sp;

    // Update is called once per frame
    void Update()
    {
        presetSprite = sp.sprite;
    }
}
