using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScroolPanController : MonoBehaviour
{
    public Button btn;
    public Text txt;
    public Image img;
    public void Init(string txt)
    {
        this.txt.text = txt;
    }
    public void Init(string txt, Sprite img)
    {
        this.txt.text = txt;
        this.img.sprite = img;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
