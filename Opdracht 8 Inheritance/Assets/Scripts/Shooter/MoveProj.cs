using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProj : MonoBehaviour
{
    private float moveSpeed = 20f;
    void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}