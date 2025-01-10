using System.Collections;
using UnityEngine;

public class Elf : EnemyParent
{
    private Renderer renderer; 

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 2;
        hp = 5;

        renderer = GetComponent<Renderer>();

        // Start the ToggleVisibility coroutine
        StartCoroutine(ToggleVisibility());
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // Coroutine to toggle visibility every 3 seconds for 0.5 seconds
    IEnumerator ToggleVisibility()
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
