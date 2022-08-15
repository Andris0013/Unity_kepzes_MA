using System;
using UnityEngine;

public class HomeWorkH12 : MonoBehaviour
{
    [SerializeField] string input;
    [Space]
    [SerializeField] bool isPalindrom;

    private void OnValidate()
    {
        isPalindrom = IsPalindrom(input);
    }

    bool IsPalindrom(string input)
    {
        if(input == null)
            return false;

        input = input.ToLower();
        input = input.Replace(" ", "");
        input = input.Replace(",", "");
        input = input.Replace(".", "");
        input = input.Replace("!", "");
        input = input.Replace("?", "");

        char[] a = input.ToCharArray();

        for (int i = 0; i < a.Length / 2; i++)
        {
            if (a[i] != a[a.Length - 1 - i])
                return false;
        }
        return true;

    }
}
