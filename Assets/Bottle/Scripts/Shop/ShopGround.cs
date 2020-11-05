using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopGround : MonoBehaviour
{
    public GameObject tick1;
    public GameObject tick2;
    public GameObject tick3;
    private int NumberGround;
    // Start is called before the first frame update
    void Start()
    {
        NumberGround = PlayerPrefs.GetInt("Ground");
    }

    // Update is called once per frame
    void Update()
    {
        if (NumberGround == 1)
        {
            tick1.SetActive(true);
            tick2.SetActive(false);
            tick3.SetActive(false);
        }
        if (NumberGround == 2)
        {
            tick1.SetActive(false);
            tick2.SetActive(true);
            tick3.SetActive(false);
        }
        if (NumberGround == 3)
        {
            tick1.SetActive(false);
            tick2.SetActive(false);
            tick3.SetActive(true);
        }
    }
    public void Ground1()
    {
        NumberGround = 1;
        PlayerPrefs.SetInt("Ground", NumberGround);
    }
    public void Ground2()
    {
        NumberGround = 2;
        PlayerPrefs.SetInt("Ground", NumberGround);
    }
    public void Ground3()
    {
        NumberGround = 3;
        PlayerPrefs.SetInt("Ground", NumberGround);
    }
}
