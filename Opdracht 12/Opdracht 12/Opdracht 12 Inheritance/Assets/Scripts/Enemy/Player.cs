using UnityEngine;

public class Player : Unit, IMovable, IDamagable
{
    protected override void Initialize()
    {
        moveSpeed = 10;
        health = 5;
        rotationSpeed = 100;
    }

    public override void Move()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
