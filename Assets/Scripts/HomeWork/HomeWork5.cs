
 /*
   �rj programot, ami a GameObject l�trej�ttekor (Start met�dus) ki�rja a sz�mokat 1-t�l N-ig. N sz�mot egy bemeneti v�ltoz�val adhatod meg.
   Ha a sz�m 3 t�bbsz�r�se, a sz�m helyett: �fizz�-t �rjon ki.
   Ha a sz�m 5 t�bbsz�r�se, akkor �buzz�-t �rjon ki.
   Ha a sz�m 3 �s 5 t�bbsz�r�se is, akkor �fizzbuzz�-t �rjon ki.
   Minden egy�b esetben a sz�mot mag�t �rja ki.
 */

using UnityEngine;

public class HomeWork5 : MonoBehaviour
{
    [SerializeField] int N;
    void Start()
    {
        for (int i = 1; i <= N; i++)
        {
            bool haromT�bbsz�r�se = i % 3 == 0;
            bool �tT�bbsz�r�se = i % 5 == 0;
            bool haromEs�tT�bbsz�r�se = haromT�bbsz�r�se && �tT�bbsz�r�se;

            if (haromEs�tT�bbsz�r�se == true)
                Debug.Log("fizzbuzz");


            else if (�tT�bbsz�r�se == true)
                Debug.Log("buzz");


            else if (haromT�bbsz�r�se == true)
                Debug.Log("fizz");

            else
                Debug.Log(i);
        }
    }
}