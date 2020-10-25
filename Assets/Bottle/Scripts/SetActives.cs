using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActives : MonoBehaviour
{
    public GameObject howToPlay;
    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HowToPlayOn()
    {
        menu.SetActive(false);
        howToPlay.SetActive(true);
    }
    public void HowToPlayOff()
    {
        menu.SetActive(true);
        howToPlay.SetActive(false);
    }
}
