using UnityEngine;

public class Unit : MonoBehaviour, IMovable, IDamagable
{
    public float moveSpeed; 
    public int health;      
    public float rotationSpeed;

    public int Health
    {
        get => health;
        private set => health = value; 
    }

    void Start()
    {
        Initialize();
    }

    private void Update()
    {
        Move();
    }

    protected virtual void Initialize()
    {
        moveSpeed = 1;
        health = 15;
    }

    public virtual void Move()
    {
        if (Health > 0)
        {
            // Move the unit in the direction it's facing
            transform.position += transform.right * moveSpeed * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Detect collisions
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(); // Call TakeDamage when hit by a bullet
        }
    }

    // Implementation of the TakeDamage method from IDamagable
    public void TakeDamage()
    {
        Health -= 1;
        Debug.Log("Took damage! Current HP: " + Health);

        if (Health <= 0)
        {
            Destroy(gameObject); // Destroy the unit when health is zero
        }
    }
}
