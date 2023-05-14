using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ValidateAnswer : MonoBehaviour
{
    public TextMeshProUGUI text;
    public CountingManager manager;
    public GameObject CorrectPanel;
    public GameObject IncorrectPanel;

    /// <summary>
    /// Called when the user clicks one of the buttons, this method validates the answer
    /// and tells the user if it's correct or not.
    /// </summary>
    public void Validate()
    {
        if (Convert.ToInt16(text.text) == manager.activeCubes)
        {
            CorrectPanel.SetActive(true);
            IncorrectPanel.SetActive(false);
        }
        else
        {
            CorrectPanel.SetActive(false);
            IncorrectPanel.SetActive(true);
        }
    }
}
