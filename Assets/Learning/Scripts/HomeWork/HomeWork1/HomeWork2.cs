
// Írj programot, amely a bemenetben megadott num és exponent számokból a kimeneti változóba a num szám exponent-edik hatványát adja meg.

using UnityEngine;

public class HomeWork2 : MonoBehaviour
{

    [SerializeField] int num;
    [SerializeField] int exponent;

    void OnValidate()
    {

        float b;
        b = Mathf.Pow(num, exponent);
        Debug.Log(b);
    }
}