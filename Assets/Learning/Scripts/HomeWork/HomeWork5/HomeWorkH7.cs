using System;
using UnityEngine;

public class HomeWorkH7 : MonoBehaviour
{
    [SerializeField] string[] a = Array.Empty<string>();
    [Space]
    [SerializeField] string[] b = Array.Empty<string>();
    [Space]
    [SerializeField] string[] merged;


    private void Start()
    {
        merged = Merge(a, b);
    }

    string[] Merge(string[] array1, string[] array2)
    {
        string[] merged = new string[array1.Length + array2.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            merged[i] = array1[i];
        }

        for (int i = 0; i < array2.Length; i++)
        {
            merged[i + array1.Length] = array2[i];
        }
        return merged;

        /*
        if (array1.Length == 0 || array1 == null)
            return array2;

        if (array2.Length == 0 || array2 == null)
            return array1;
        */
    }
}
