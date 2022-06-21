
using UnityEngine;

public class Variables2 : MonoBehaviour
{
    void Start()
    {
        int a, b, c;

        a = 5;
        b = 3;
        c = a + b;
        c = 2;        //It's not math but instructions to the computer so it doesn't have to be true

        Debug.Log(c);

        c += 5;  // (c = c + 5)
        c -= 5;  // (c = c - 5)
        c *= 5;  // (c = c * 5)
        c /= 5;  // (c = c / 5)

        c++;     // c = c + 1
        ++c;     // c = c + 1

        c--;     // c = c - 1
        --c;     // c = c - 1

        Debug.Log(c);  // c = 2 because of line 13 that starts the value of c that we have to start with.

        int x = a + b * c; // C# keeps the prioritization of math so it's b * c + a
        Debug.Log(x);
    }
}
