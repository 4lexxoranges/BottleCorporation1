using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Person")
        {
            
            print("You take 100 money");

            Destroy(gameObject);
        }
    }
   
}
