using System.Collections;
using UnityEngine;

public class Elf : Unit, IMovable, IDamagable
{
    private Renderer renderer; 

    protected override void Initialize()
    {
        moveSpeed = 2;
        health = 5;

        Move(); 
        
        renderer = GetComponent<Renderer>();

        StartCoroutine(ToggleVisibility());
    }

    // Coroutine to toggle visibility every 3 seconds for 0.5 seconds
    private IEnumerator ToggleVisibility()
    {
        while (true)  // Infinite loop to keep toggling visibility
        {
            // Turn invisible
            renderer.enabled = false;

            // Wait for 0.5 seconds
            yield return new WaitForSeconds(0.5f);

            // Turn visible again
            renderer.enabled = true;

            // Wait for 3 seconds before toggling again
            yield return new WaitForSeconds(3f);
        }
    }
}
