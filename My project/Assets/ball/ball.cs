using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject prefab;
    private void CreateBall(){
        Instantiate(prefab);
        gameObject.AddComponent<ball>();
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
