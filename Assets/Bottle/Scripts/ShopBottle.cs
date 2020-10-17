using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopBottle : MonoBehaviour
{
    public GameObject tick1;
    public GameObject tick2;
    public GameObject tick3;
    private int NumberBottle;
    // Start is called before the first frame update
    void Start()
    {
        NumberBottle = PlayerPrefs.GetInt("Bottle");
    }

    // Update is called once per frame
    void Update()
    {
      if(NumberBottle == 1)
      {
            tick1.SetActive(true);
            tick2.SetActive(false);
            tick3.SetActive(false);
      }
        if (NumberBottle == 2)
        {
            tick1.SetActive(false);
            tick2.SetActive(true);
            tick3.SetActive(false);
        }
        if (NumberBottle == 3)
        {
            tick1.SetActive(false);
            tick2.SetActive(false);
            tick3.SetActive(true);
        }
    }
    public void Bottle1()
    {
        NumberBottle = 1;
        PlayerPrefs.SetInt("Bottle", NumberBottle);
    }
    public void Bottle2()
    {
        NumberBottle = 2;
        PlayerPrefs.SetInt("Bottle", NumberBottle);
    }
    public void Bottle3()
    {
        NumberBottle = 3;
        PlayerPrefs.SetInt("Bottle", NumberBottle);
    }
}
