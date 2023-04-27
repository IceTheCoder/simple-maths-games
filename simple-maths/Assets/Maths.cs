using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Maths : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Start()
    {
        int num1;
        int num2;
        int num3;
        string answer;

        System.Random random = new System.Random();
        num1 = random.Next(1, 11); // generates a random integer between 1 and 100
        num2 = random.Next(1, 11); // generates a random integer between 1 and 100
        num3 = random.Next(1, 11); // generates a random integer between 1 and 100

        text.text = num1.ToString() + " * " + num2.ToString() + " + " + num3.ToString() + " =";
        // answer = Console.ReadLine();

        return;

        if (Convert.ToInt32(answer) == num1 * num2 + num3)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }
        num1 = random.Next(1, 11); // generates a random integer between 1 and 100
        num2 = random.Next(1, 11); // generates a random integer between 1 and 100
        num3 = random.Next(1, 11); // generates a random integer between 1 and 100

        Console.WriteLine(num1.ToString() + " * " + num2.ToString() + " + " + num3.ToString());
        answer = Console.ReadLine();

        if (Convert.ToInt32(answer) == num1 * num2 + num3)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }
        num1 = random.Next(1, 11); // generates a random integer between 1 and 100
        num2 = random.Next(1, 11); // generates a random integer between 1 and 100
        num3 = random.Next(1, 11); // generates a random integer between 1 and 100

        Console.WriteLine(num1.ToString() + " * " + num2.ToString() + " + " + num3.ToString());
        answer = Console.ReadLine();

        if (Convert.ToInt32(answer) == num1 * num2 + num3)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.ReadKey();

    }
}
