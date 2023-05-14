using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    public float xPositionsInterval = 3f; // the interval between the possible x positions
    public float[] xPositions = new float[] { -6f, -3f, 0f, 3f, 6f }; // the possible x positions
    public float[] yPositions = new float[] { 0f, 3f }; // the possible y positions

    void Start()
    {
        // Choose a random x and y position
        float xPos = xPositions[Random.Range(0, xPositions.Length)];
        float yPos = yPositions[Random.Range(0, yPositions.Length)];

        // Set the position of the object to the chosen position
        transform.position = new Vector3(xPos, yPos, 0f);
    }
}
