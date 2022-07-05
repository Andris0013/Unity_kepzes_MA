
//Írj programot, amely összefûz 3 bemeneten megadott string változót, vesszõvel elválasztva, egy kimeneti string változóvá!

using UnityEngine;

public class HomeWork3 : MonoBehaviour
{
    [SerializeField] string text1;
    [SerializeField] string text2;
    [SerializeField] string text3;

    void OnValidate()
    {
        string outcome = text1 + "," + text2 + "," + text3;

        bool notempty1 = text1 != string.Empty;
        bool notempty2 = text2 != string.Empty;
        bool notempty3 = text3 != string.Empty;

        if (notempty1 && notempty2 && notempty3 == true)
        {
            Debug.Log(outcome);
        }

        /* 
        
        if (szöveg1 != string.Empty)
        {
            if (szöveg2 != string.Empty)
            {
                if (szöveg3 != string.Empty)
                {
                    Debug.Log(eredmény);
                }
            }
        }

        */
    }

}
