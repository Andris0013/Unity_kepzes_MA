using System.Collections.Generic;
using UnityEngine;

public class HomeWorkH14 : MonoBehaviour
{
    [SerializeField] string text;
    [Space]
    [SerializeField] int uniqCharacterCount;

    void OnValidate()
    {
        uniqCharacterCount = CountUniqCharacters(text);
    }

    int CountUniqCharacters(string text)
    {
        List<char> characters = new List<char>();
        foreach (char c in characters)                      // char c ??
        {
            if (!characters.Contains(c))
                characters.Add(c);
        }

        return characters.Count;



    }
}
