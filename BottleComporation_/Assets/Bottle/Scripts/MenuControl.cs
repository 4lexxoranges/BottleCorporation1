﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    [SerializeField] Text coins;
    public int coinsCount;

    
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("coinsFinal"))
        {
            coinsCount = PlayerPrefs.GetInt("coinsFinal");
        }
        else
        {
            coinsCount = 0;
        }
        coins.text = "Coins:" + coinsCount.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
