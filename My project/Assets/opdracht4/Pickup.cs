using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Pickup : MonoBehaviour
{
    public static event Action Deathball;
     void OnTriggerEnter(Collider other)
    {   
         if (other.tag == "Player")
        
        {
            
            Destroy(gameObject);
            Deathball?.Invoke();
        }
    }
}
