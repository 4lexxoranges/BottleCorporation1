﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGround : MonoBehaviour
{
    private int numberGround;

    public GameObject ground1;
    public GameObject ground2;
    public GameObject ground3;
    // Start is called before the first frame update
    void Start()
    {
        numberGround = PlayerPrefs.GetInt("Ground");
    }

    // Update is called once per frame
    void Update()
    {
        if (numberGround == 1)
        {
            ground1.SetActive(true);
            ground2.SetActive(false);
            ground3.SetActive(false);
        }
        if (numberGround == 2)
        {
            ground1.SetActive(false);
            ground2.SetActive(true);
            ground3.SetActive(false);
        }
        if (numberGround == 3)
        {
            ground1.SetActive(false);
            ground2.SetActive(false);
            ground3.SetActive(true);
        }
    }
}
