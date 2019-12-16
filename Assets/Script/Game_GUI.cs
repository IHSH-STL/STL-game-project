using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_GUI : MonoBehaviour
{
    public GameObject player;

    Vector3 StartingPos;
    Quaternion StartingRotate;
    bool isStarted = false;

    void Awake()
    {
        Time.timeScale = 0f;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
