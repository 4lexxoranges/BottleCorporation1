using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForTest : MonoBehaviour
{
    [SerializeField] Test testGameValue;
    public List<string> test = new List<string>();
    enum Test
    {
        test,
        test2,
        test3,
        test4,
        test5,

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
