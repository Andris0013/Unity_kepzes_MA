
//�rj programot, amely �sszef�z 3 bemeneten megadott string v�ltoz�t, vessz�vel elv�lasztva, egy kimeneti string v�ltoz�v�!

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
        
        if (sz�veg1 != string.Empty)
        {
            if (sz�veg2 != string.Empty)
            {
                if (sz�veg3 != string.Empty)
                {
                    Debug.Log(eredm�ny);
                }
            }
        }

        */
    }

}
