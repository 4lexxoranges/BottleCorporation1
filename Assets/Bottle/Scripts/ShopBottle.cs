using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ShopBottle : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject buttonYes;
    public GameObject buttonNo;
    public GameObject buttonYes2;
    public GameObject buttonNo2;
    public GameObject buttonBuy;
    public GameObject buttonBuy2;
    public GameObject tick1;
    public GameObject tick2;
    public GameObject tick3;
    public GameObject imageChampange;
    public GameObject buttonEquip;
    public GameObject buttonEquip2;
    public GameObject buttonEquip3;
    private int NumberBottle;
    private int NumberEquip;
    private int NumberBuy;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (NumberBottle == 1)
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
        if (NumberEquip == 1)
        {
            tick1.SetActive(true);
            tick2.SetActive(false);
            tick3.SetActive(false);
            buttonEquip.SetActive(false);
            buttonEquip2.SetActive(true);
            buttonEquip3.SetActive(true);
        }
        if (NumberEquip == 2)
        {

            tick1.SetActive(false);
            tick2.SetActive(true);
            tick3.SetActive(false);
            buttonEquip.SetActive(true);
            buttonEquip2.SetActive(false);
            buttonEquip3.SetActive(true);
        }
        if (NumberEquip == 3)
        {
            buttonEquip.SetActive(true);
            buttonEquip2.SetActive(true);
            buttonEquip3.SetActive(false);
            buttonBuy2.SetActive(false);
            tick1.SetActive(false);
            tick2.SetActive(false);
            tick3.SetActive(true);
        }


    }
    public void Equip1()
    {
        NumberEquip = 1;
        PlayerPrefs.SetInt("Equip", NumberEquip);
    }
    public void Equip2()
    {
        NumberEquip = 2;
        PlayerPrefs.SetInt("Equip", NumberEquip);
    }
    public void Equip3()
    {
        NumberEquip = 3;
        PlayerPrefs.SetInt("Equip", NumberEquip);
    }
    /*public void Equip()
    {
        tick1.SetActive(true);
        tick2.SetActive(false);
        tick3.SetActive(false);
        buttonEquip.SetActive(false);
        buttonEquip2.SetActive(true);
        buttonEquip3.SetActive(true);
    }
    public void Equip2()
    {
        tick1.SetActive(false);
        tick2.SetActive(true);
        tick3.SetActive(false);
        buttonEquip.SetActive(true);
        buttonEquip2.SetActive(false);
        buttonEquip3.SetActive(true);
    }
    public void Equip3()
    {
        buttonEquip.SetActive(true);
        buttonEquip2.SetActive(true);
        buttonEquip3.SetActive(false);
        buttonBuy2.SetActive(false);
        tick1.SetActive(false);
        tick2.SetActive(false);
        tick3.SetActive(true);

    }*/

    public void ButtonBuy1()
    {
        panel1.SetActive(true);
        buttonBuy.SetActive(false);
        buttonBuy2.SetActive(false);
        imageChampange.SetActive(false);
    }
    public void ButtonBuy2()
    {
        panel2.SetActive(true);
        buttonBuy.SetActive(false);
        buttonBuy2.SetActive(false);
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
    public void ButtonYes()
    {
        panel1.SetActive(false);
        buttonEquip2.SetActive(true);
        buttonBuy.SetActive(false);
        buttonBuy2.SetActive(true);
        imageChampange.SetActive(true);
        
    }
    public void ButtonNo()
    {
        panel1.SetActive(false);
        buttonBuy.SetActive(true);
        buttonBuy2.SetActive(true);
        imageChampange.SetActive(true);
    }
    public void ButtonYes2()
    {
        panel2.SetActive(false);
        buttonEquip3.SetActive(true);
        buttonBuy.SetActive(true);
        buttonBuy2.SetActive(false);
    }
    public void ButtonNo2()
    {
        panel2.SetActive(false);
        buttonBuy.SetActive(true);
        buttonBuy2.SetActive(true);
    }

}
