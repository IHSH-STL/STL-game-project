using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;



public class Moving_Skills : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    public float dashPower = 100f;
    private float coolTime = 5;

    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {     
        if (Input.GetKeyDown(KeyCode.Z) && coolTime > 5) //Z키를 눌렀을 때 실행됨
        {
            Debug.Log(myRigidbody.velocity.normalized); //Z키가 입력되면 Console 창에 속도가 표시됨
            myRigidbody.AddForce(myRigidbody.velocity.normalized * dashPower);
            coolTime = 0;
        }
        coolTime += Time.fixedDeltaTime;
    }
}
