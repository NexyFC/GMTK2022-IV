using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Sprite m_six;
    public SpriteRenderer sp;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(sp.sprite == m_six)
            {
                Debug.Log("Turn to 5");
            }
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (sp.sprite == m_six)
            {
                Debug.Log("Turn to 2");
            }
        }

    }
}
