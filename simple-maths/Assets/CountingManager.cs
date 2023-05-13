using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingManager : MonoBehaviour
{
    public GameObject[] gameObjects;

    /// <summary>
    /// Called when the script first loads,
    /// this method generates a random number and
    /// disables the first cubes (totalling that random number)
    /// </summary>
    void Start()
    {
        // Generate a random number
        int randomNumber = Random.Range(0, gameObjects.Length);

        // Disable the first randomNumber objects in the array
        for (int i = 0; i < gameObjects.Length; i++)
        {
            if (i < randomNumber)
            {
                gameObjects[i].SetActive(false);
            }
        }
    }
}
