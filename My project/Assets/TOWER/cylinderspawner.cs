using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderspawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab, new Vector3(UnityEngine.Random.Range(-10, 10),0, UnityEngine.Random.Range(-10, 10)), Quaternion.identity);
        }
    }
}
