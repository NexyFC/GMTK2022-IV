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
    public LayerMask whatStopsMovement;
    private PlayerMovement PM;

    private void Awake()
    {
        grid = GridObject.GetComponent<Grid>();
        PM = GetComponent<PlayerMovement>();
    }

    private void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, MovePoint.transform.position, movespeed * Time.deltaTime);

        if (transform.position == MovePoint.transform.position)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if (!Physics2D.OverlapCircle(MovePoint.transform.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopsMovement))
                {
                    MovePoint.transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                    if(Input.GetAxisRaw("Horizontal") > 0f)
                    {
                        //.MoveRight();
                    }else if (Input.GetAxisRaw("Horizontal") < 0f)
                    {
                        //PM.MoveLeft();
                    }
                }
            }else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(MovePoint.transform.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopsMovement))
                {
                    MovePoint.transform.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                    if(Input.GetAxisRaw("Vertical") < 0f)
                    {
                        PM.RotateDown();
                    }else if (Input.GetAxisRaw("Vertical") > 0f)
                    {
                        //PM.MoveUp();
                    }
                }
            }
        }
    }
}
