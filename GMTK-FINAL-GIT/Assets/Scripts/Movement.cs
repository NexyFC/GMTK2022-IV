using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 250f;
    private float horzmove = 0f;

    void Update()
    {
        horzmove = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            controller.Move(0f, false, true);
        }
    }

    void FixedUpdate()
    {
        controller.Move(horzmove * Time.fixedDeltaTime, false, false);
    }
}