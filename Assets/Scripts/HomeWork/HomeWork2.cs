
// �rj programot, amely a bemenetben megadott num �s exponent sz�mokb�l a kimeneti v�ltoz�ba a num sz�m exponent-edik hatv�ny�t adja meg.

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