using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Rigidbody2D myRigidBody2D;


    void Start()
    {
       //PrintingToOurconsol();
    }

    void Update()
    {
        MovingOurCube();
    }

    public string PrintingFromOutside(int value)
    {
        string printingSomething = "The value we were sent is" + value;

        return printingSomething;
    }

    private void MovingOurCube()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myRigidBody2D.velocity = new Vector2(0f, 10f);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myRigidBody2D.velocity = new Vector2(0f, -10f);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myRigidBody2D.velocity = new Vector2(-10f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myRigidBody2D.velocity = new Vector2(10f, 0f);
        }
    }
}
