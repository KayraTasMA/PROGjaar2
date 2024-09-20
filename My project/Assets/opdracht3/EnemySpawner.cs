

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   
    private float wave = 100;
     public GameObject prefab;
    private List<GameObject> enemys = new List<GameObject>();
    private float worldTime = 0f;

    private float other = 3;
    
    // Start is called before the first frame update

    void Start()
    {
        worldTime = 0f;

    }
    public void cubewave()
    {

        for (int i = 0; i < wave; i++) 
        {
            enemys.Add(Instantiate(prefab));
            
        }
    }

    public void Threecubes()
    {
        for (int i = 0; i < other; i++)
        {
            enemys.Add(Instantiate(prefab));
        }
    }

    // Update is called once per frame
    void Update()
    {
        worldTime += Time.deltaTime;

        Debug.Log(worldTime);
        if (worldTime >= 1f)
        {
            Threecubes();
            worldTime = 0f;
            Debug.Log(worldTime);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            
            cubewave();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < enemys.Count; i++)
            {
                Destroy(enemys[i]);
            }
            enemys.Clear();
        }


    }

}