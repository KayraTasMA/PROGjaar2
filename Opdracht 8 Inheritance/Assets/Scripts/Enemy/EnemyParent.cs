using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    public float moveSpeed;
    public float hp;

    // Update is called once per frame
    public void Move()
    {
        if (hp >= 0)
        {
            transform.position = transform.position + transform.right * moveSpeed * Time.deltaTime;
        }
        else if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Hit. HP = " + hp);
            hp -= 1;
        }
    }
}