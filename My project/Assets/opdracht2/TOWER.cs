using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TOWER : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float randomsize = Random.Range(0.5f, 2.0f);
        transform.localScale = new Vector3(randomsize, randomsize, randomsize); 
    }
    
      
    // Update is called once per frame
    void Update()
    {
        
    }
}
