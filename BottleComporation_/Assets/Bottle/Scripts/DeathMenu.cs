using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void ToggleEndMenu()
    {
        gameObject.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    
}
