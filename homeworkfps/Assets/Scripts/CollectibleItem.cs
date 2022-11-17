using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public Controller Controller1;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Controller1.AddCollectable();
            Destroy(this.gameObject);
            
        }
    }

}
