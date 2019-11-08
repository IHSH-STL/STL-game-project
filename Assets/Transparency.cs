using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour
{
    SpriteRenderer render;
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A)) //A키를 눌렀을 때 실행됨
        {
            render.color = new Color(1, 1, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S)) //A키를 눌렀을 때 실행됨
        {
            render.color = new Color(1, 1, 1, 1);
        }
    }
}
