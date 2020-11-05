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
    public int priceCocaCola;
    public int priceChampange;
    public bool isPurchased = false;
    public bool isPurchased2 = false;
    private int numPurchased;
    int boolToInt(bool val)
    {
        if (val)
            return 1;
        else
            return 0;
    }

    bool intToBool(int val)
    {
        if (val != 0)
            return true;
        else
            return false;
    }
    // Start is called before the first frame update
    void Start()
    {
        isPurchased = intToBool(PlayerPrefs.GetInt("Purchased1"));
        isPurchased2 = intToBool(PlayerPrefs.GetInt("Purchased2"));
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
            if (isPurchased == true)
            {
                buttonEquip2.SetActive(true);
            }
            else
            {
                buttonEquip2.SetActive(false);
            }
            if (isPurchased2 == true)
            {
                buttonEquip3.SetActive(true);
            }
            else
            {
                buttonEquip3.SetActive(false);
            }
            Bottle1();
        }
        if (NumberEquip == 2)
        {
            tick1.SetActive(false);
            tick2.SetActive(true);
            tick3.SetActive(false);
            buttonEquip.SetActive(true);
            buttonEquip2.SetActive(false);
            if (isPurchased2 == true)
            {
                buttonEquip3.SetActive(true);
            }
            else
            {
                buttonEquip3.SetActive(false);
            }
            buttonBuy.SetActive(false);
            Bottle2();
        }

        if (NumberEquip == 3)
        {
            tick1.SetActive(false);
            tick2.SetActive(false);
            tick3.SetActive(true);
            buttonEquip.SetActive(true);
            buttonEquip2.SetActive(true);
            buttonEquip3.SetActive(false);
            if (isPurchased == true)
            {
                buttonEquip2.SetActive(true);
            }
            else
            {
                buttonEquip2.SetActive(false);
            }
            buttonBuy2.SetActive(false);
            Bottle3();
        }
        if (isPurchased == true)
        {
            buttonBuy.SetActive(false);
            buttonEquip2.SetActive(true);
        }
        else
        {
            buttonBuy.SetActive(true);
            buttonEquip2.SetActive(false);
        }
        if (isPurchased2 == true)
        {
            buttonBuy2.SetActive(false);
            buttonEquip3.SetActive(true);
        }
        else
        {
            buttonBuy2.SetActive(true);
            buttonEquip3.SetActive(false);
        }
    }
    public void SavePurchased()
    {
        if (isPurchased == true)
            PlayerPrefs.SetInt("Purchased1", boolToInt(isPurchased));
        Debug.Log("Save");
    }
    public void LoadPurchased()
    {
        var resultPurchased1 = intToBool(PlayerPrefs.GetInt("Purchased1"));
        Debug.Log("Load " + resultPurchased1);
    }
    public void SavePurchased2()
    {
        if (isPurchased2 == true)
            PlayerPrefs.SetInt("Purchased2", boolToInt(isPurchased));
        Debug.Log("Save2");
    }
    public void LoadPurchased2()
    {
        var resultPurchased2 = intToBool(PlayerPrefs.GetInt("Purchased2"));
        Debug.Log("Load2 " + resultPurchased2);
    }
    public void Bottle1()
    {
        NumberBottle = 1;
        PlayerPrefs.SetInt("Bottle", NumberBottle);
    }
    public void Bottle2()
    {
        if (isPurchased == true)
        {
            NumberBottle = 2;
            PlayerPrefs.SetInt("Bottle", NumberBottle);
        }
    }
    public void Bottle3()
    {
        if (isPurchased2 == true)
        {
            NumberBottle = 3;
            PlayerPrefs.SetInt("Bottle", NumberBottle);
        }
    }
    public void Equip()
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

    public void ButtonYes()
    {
        panel1.SetActive(false);
        buttonEquip2.SetActive(true);
        buttonBuy.SetActive(false);
        buttonBuy2.SetActive(true);
        imageChampange.SetActive(true);
        isPurchased = true;
        Bottle.coinsCount -= 2000;
    }
    public void ButtonYes2()
    {
        panel2.SetActive(false);
        buttonEquip3.SetActive(true);
        buttonBuy.SetActive(true);
        buttonBuy2.SetActive(false);
        isPurchased2 = true;
        Bottle.coinsCount -= 5000;
    }

    public void ButtonNo()
    {
        panel1.SetActive(false);
        buttonBuy.SetActive(true);
        buttonBuy2.SetActive(true);
        imageChampange.SetActive(true);
    }
    public void ButtonNo2()
    {
        panel2.SetActive(false);
        buttonBuy.SetActive(true);
        buttonBuy2.SetActive(true);
    }
}
