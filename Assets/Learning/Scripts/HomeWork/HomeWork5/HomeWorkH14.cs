using System.Collections.Generic;
using UnityEngine;

public class HomeWorkH14 : MonoBehaviour
{
    [SerializeField] string text;
    [Space]
    [SerializeField] int uniqueCharacterCount;

    void OnValidate()
    {
        uniqueCharacterCount = CountUniqueCharacters(text);
    }

    int CountUniqueCharacters(string text)
    {
        List<char> characters = new List<char>();
        foreach (char c in characters)                      // creates a variable that takes the value of the indexes in order until the end -- kinda
        {
            if (!characters.Contains(c))
                characters.Add(c);
        }

        return characters.Count;



    }
}
