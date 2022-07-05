
/* Vektorok �s Transfor-ok
 
        Vektor jel�lhet a s�kban/t�rben egy pontot, vagy egy elmozdul�st
        Vektorok alapvet� m�veletei:
            - v1(a,b) v2(c,d)
            - �sszead�s: v1 + v2 = (a+c,b+d)
            - kivon�s: v1 - v2 = (a-c,b-d)
            - szorz�s/oszt�s konstansal: v1 * K = (a*k,b*k)
            - hossz�nak kisz�m�t�sa: P�thagorasz-t�tellel, ahol a vektor az �tfog�
            - normaliz�l�s: vektor osztva a hossz�val, hogy 1 hossz� vektort kapjunk. 
       
        Vektorok a Unityben:
            - vektor2: x,y koordin�t�val rendelkez� vektor a s�kban
            - vektor3: x,y,z koordin�t�val rendelkez� vektor a t�rben

 */

using UnityEngine;

public class VectorPractice : MonoBehaviour
{
    [SerializeField] Vector2 myFirst2DVector;
    [SerializeField] Vector3 myFirst3DVector;
    [SerializeField] Vector3 mySecond3DVector;

    [SerializeField] Vector3 vSum;                          // Summa
    [SerializeField] Vector3 vDiff;                         // Difference
    [SerializeField] float K;                               // Multiplier
    [SerializeField] Vector3 vProd;                         // Product
    [SerializeField] float vLength;                         // Length of the vector
    [SerializeField] Vector2 vNorm;                           // Normalized vector

    void OnValidate()
    {
        vSum = myFirst3DVector + mySecond3DVector;          // Vektorok �sszead�sa
        vDiff = myFirst3DVector - mySecond3DVector;         // Vektorok kivon�sa
        vProd = myFirst3DVector * K;                        // Vektor szorz�sa K-val
        vLength = myFirst3DVector.magnitude;                // Vektor hossza
        vNorm = myFirst3DVector.normalized;                 // Vektor hossza

        // Egyes komponensek el�r�se:
        float x = myFirst3DVector.x;
        float y = myFirst3DVector.y;
        float z = myFirst3DVector.z;

        Vector2 vector2localVariable = new Vector2(1, 2);           // Vector 2 l�trehoz�sa, mint lok�lis v�ltoz�
        Vector3 vector3localVariable = new Vector3(1, 2, 3);        // Vector 3 l�trehoz�sa, mint lok�lis v�ltoz�

    }
}
