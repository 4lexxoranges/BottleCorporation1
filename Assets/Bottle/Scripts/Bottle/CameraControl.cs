using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Bottle;

    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Bottle.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Bottle.transform.position + offset;
    }
}
