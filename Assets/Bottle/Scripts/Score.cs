using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public int hightScore;
    [SerializeField] Text score2;
    [SerializeField] Text hightScore2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score > hightScore)
        {
            PlayerPrefs.SetInt("savesscore", score);
            PlayerPrefs.Save();
        }
        
        hightScore = PlayerPrefs.GetInt("savesscore");
        if(Input.GetKeyDown(KeyCode.E))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
