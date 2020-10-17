using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberBottle : MonoBehaviour
{
    private int numberBottle;

    public GameObject bottle1;
    public GameObject bottle2;
    public GameObject bottle3;
    // Start is called before the first frame update
    void Start()
    {
        numberBottle = PlayerPrefs.GetInt("Bottle");
    }

    // Update is called once per frame
    void Update()
    {
        if (numberBottle == 1)
        {
            bottle1.SetActive(true);
            bottle2.SetActive(false);
            bottle3.SetActive(false);
        }
        if (numberBottle == 2)
        {
            bottle1.SetActive(false);
            bottle2.SetActive(true);
            bottle3.SetActive(false);
        }
        if (numberBottle == 3)
        {
            bottle1.SetActive(false);
            bottle2.SetActive(false);
            bottle3.SetActive(true);
        }
    }
}
