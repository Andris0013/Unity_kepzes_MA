using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] int[] myFirstArray;
    [SerializeField] int minimum;
    [SerializeField] int sum;
    [SerializeField] int product;
    [SerializeField] float average;

    void OnValidate()
    {
        if(myFirstArray.Length == 0)
        {
            minimum = 0;
            sum = 0;
            product = 0;
            return;
        }

        minimum = myFirstArray[0];
        sum = 0;
        product = 1;
        average = 0;

        for (int i = 0; i < myFirstArray.Length; i++)
        {
            int current = myFirstArray[i];
            
            if (current < minimum)
            {
                minimum = myFirstArray[i];
            }
            
            sum += current;
            product *= current;
        }

        average = sum / (float)myFirstArray.Length;

    }

}
