using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    [SerializeField] GameObject GridObject;
    public LayerMask gridl;
    private Grid grid;
    [SerializeField] GameObject MovePoint;
    [SerializeField] float movespeed = 3f;

    private void Awake()
    {
        grid = GridObject.GetComponent<Grid>();
    }

    private void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, MovePoint.transform.position, movespeed * Time.deltaTime);

        if (transform.position == MovePoint.transform.position)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                MovePoint.transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
            }
            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                MovePoint.transform.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
            }
        }
    }
}
