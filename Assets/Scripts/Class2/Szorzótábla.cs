using UnityEngine;

public class Szorzótábla : MonoBehaviour
{

    void Start()
    {
        for (int a = 1; a <= 10; a++)
        {
            for (int b = 1; b <= 10; b++)
            {
                int c = a * b;
                Debug.Log(a + "*" + b + "=" + c);
            }
        }
    }
}
