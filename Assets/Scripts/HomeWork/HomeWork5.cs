
 /*
   Írj programot, ami a GameObject létrejöttekor (Start metódus) kiírja a számokat 1-tõl N-ig. N számot egy bemeneti változóval adhatod meg.
   Ha a szám 3 többszöröse, a szám helyett: „fizz”-t írjon ki.
   Ha a szám 5 többszöröse, akkor „buzz”-t írjon ki.
   Ha a szám 3 és 5 többszöröse is, akkor „fizzbuzz”-t írjon ki.
   Minden egyéb esetben a számot magát írja ki.
 */

using UnityEngine;

public class HomeWork5 : MonoBehaviour
{
    [SerializeField] int N;
    void Start()
    {
        for (int i = 1; i <= N; i++)
        {
            bool haromTöbbszöröse = i % 3 == 0;
            bool ötTöbbszöröse = i % 5 == 0;
            bool haromEsÖtTöbbszöröse = haromTöbbszöröse && ötTöbbszöröse;

            if (haromEsÖtTöbbszöröse == true)
                Debug.Log("fizzbuzz");


            else if (ötTöbbszöröse == true)
                Debug.Log("buzz");


            else if (haromTöbbszöröse == true)
                Debug.Log("fizz");

            else
                Debug.Log(i);
        }
    }
}