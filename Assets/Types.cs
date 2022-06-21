using UnityEngine;

public class Types : MonoBehaviour
{
    void Start()
    {
        int i = 3;                  // Integer numbers 

        float f = 3.5f;             // Fraction numbers, f needed after value

        string s = "Some text";     // Text

        bool b1 = true;
        bool b2 = false;            // True or False

        Debug.Log(i);
        Debug.Log(f);
        Debug.Log(s);
        Debug.Log(b1);
        Debug.Log(b2);

        var v = 3.5f;       
        var p = i * f;      // var helps so we don't have to write int, float, string etc.

        int p1 = i * (int)f;        //casting equals 9 (casting = (int) basicaly we make it an int variable)
        int p2 = (int)(i * f);      //casting equals 10

        var v3 = 5;
        float v4 = v3;      //implicit casting is basicaly when we don't lose data with casting

        var sss = s + i;        //Some text 3

        var sss2 = s + i + f;   // Some text 3 3.5
        var sss3 = i + f + s;   // 6.5 ST
        var sss4 = i + s + f;   // 3ST3.5
    }

}
