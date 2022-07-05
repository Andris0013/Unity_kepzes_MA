
// Elsõ N (bemeneten megadott) szám összefûzése szöveggé, vesszõvel elválasztva

using UnityEngine;

public class HomeWork4 : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] string text;

    void OnValidate()
    {
        text = string.Empty;

        for (int i = 1; i <= number; i++)
        {
            if (i < number)
              text = text + i + ",";

            else
                text = text + i;

        }

    }

}
