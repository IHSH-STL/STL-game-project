using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character_Movement : MonoBehaviour
{
    public float speed = 10f;
    public float speedInWater = 5f;
    public static bool onWater = false;
    public Vector2 v = Vector2.zero;
    Rigidbody2D myRigidbody;
    


    void Start() 
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate() //방향키 조절
    {
        v = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            v += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            v += Vector2.right;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            v += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            v += Vector2.down;
        }
        v.Normalize();

        if(onWater)
            myRigidbody.velocity = v * speedInWater;
        else
            myRigidbody.velocity = v * speed;

    }

    private void Update()
    {
        Debug.Log(gameObject.layer);
    }
}
