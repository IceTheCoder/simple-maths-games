using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountingManager : MonoBehaviour
{
    public GameObject[] cubes;
    public TextMeshProUGUI[] buttonsTexts;
    public int activeCubes;

    /// <summary>
    /// Called when the script first loads,
    /// this method generates a random number and
    /// disables the first cubes (totalling that random number)
    /// </summary>
    void Start()
    {
        // Generate a random number
        int randomNumber = Random.Range(0, cubes.Length);

        // Disable the first randomNumber objects in the array
        for (int i = 0; i < cubes.Length; i++)
        {
            if (i < randomNumber)
            {
                cubes[i].SetActive(false);
            }
        }

        activeCubes = 10 - randomNumber;

        int randomButton = Random.Range(0, buttonsTexts.Length);

        // Loop through each element of the buttonsTexts array and set the text to a random value between 0 and 10 that is not equal to activeCubes
        for (int i = 0; i < buttonsTexts.Length; i++)
        {
            int randomValue = Random.Range(0, 11);
            while (randomValue == activeCubes)
            {
                randomValue = Random.Range(0, 11);
            }
            buttonsTexts[i].text = randomValue.ToString();
        }

        buttonsTexts[randomButton].text = activeCubes.ToString();

    }
}
