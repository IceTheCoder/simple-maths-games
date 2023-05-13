using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountingManager : MonoBehaviour
{
    public GameObject[] cubes;
    public TextMeshProUGUI[] buttonsTexts;

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

        int activeCubes = 10 - randomNumber;

        int randomButton = Random.Range(0, buttonsTexts.Length);
        buttonsTexts[randomButton].text = activeCubes.ToString();
    }
}
