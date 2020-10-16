using System.Collections;
using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour

{
    public GameObject pp1;
    public GameObject pp2;
    public GameObject pp3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Bottle()
    {
        pp1.SetActive(true);
        pp2.SetActive(false);
        pp3.SetActive(false);
        
    }
    public void Location()
    {
        pp1.SetActive(false);
        pp2.SetActive(true);
        pp3.SetActive(false);
        
    }
    public void Currency()
    {
        pp1.SetActive(false);
        pp2.SetActive(false);
        pp3.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
