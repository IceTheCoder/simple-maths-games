using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Maths : MonoBehaviour
{
    public TextMeshProUGUI exercise;
    public TextMeshProUGUI result;
    public TMP_InputField inputField;
    public int num1;
    public int num2;
    public int num3;
    public string answer;
    System.Random random = new System.Random();

    void Start()
    {

        num1 = random.Next(1, 11); // generates a random integer between 1 and 100
        num2 = random.Next(1, 11); // generates a random integer between 1 and 100
        num3 = random.Next(1, 11); // generates a random integer between 1 and 100

        exercise.text = num1.ToString() + " * " + num2.ToString() + " + " + num3.ToString() + " =";
    }

    public void ValidateResult()
    {
        answer = inputField.text.ToString();

        if (answer != "")
        {
            if (Convert.ToInt32(answer) == num1 * num2 + num3)
            {
                result.text = "Correct!";
            }
            else
            {
                result.text = "Incorrect! \n Correct: " + (num1 * num2 + num3).ToString();
            }
        }
    }
}
