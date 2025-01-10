using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : EnemyParent
{
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 1;
        hp = 15;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
