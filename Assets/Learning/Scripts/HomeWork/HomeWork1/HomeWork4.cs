
// Els� N (bemeneten megadott) sz�m �sszef�z�se sz�vegg�, vessz�vel elv�lasztva

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
