
/* Vektorok és Transfor-ok
 
        Vektor jelölhet a síkban/térben egy pontot, vagy egy elmozdulást
        Vektorok alapvetõ mûveletei:
            - v1(a,b) v2(c,d)
            - összeadás: v1 + v2 = (a+c,b+d)
            - kivonás: v1 - v2 = (a-c,b-d)
            - szorzás/osztás konstansal: v1 * K = (a*k,b*k)
            - hosszának kiszámítása: Püthagorasz-tétellel, ahol a vektor az átfogó
            - normalizálás: vektor osztva a hosszával, hogy 1 hosszú vektort kapjunk. 
       
        Vektorok a Unityben:
            - vektor2: x,y koordinátával rendelkezõ vektor a síkban
            - vektor3: x,y,z koordinátával rendelkezõ vektor a térben

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
        vSum = myFirst3DVector + mySecond3DVector;          // Vektorok összeadása
        vDiff = myFirst3DVector - mySecond3DVector;         // Vektorok kivonása
        vProd = myFirst3DVector * K;                        // Vektor szorzása K-val
        vLength = myFirst3DVector.magnitude;                // Vektor hossza
        vNorm = myFirst3DVector.normalized;                 // Vektor hossza

        // Egyes komponensek elérése:
        float x = myFirst3DVector.x;
        float y = myFirst3DVector.y;
        float z = myFirst3DVector.z;

        Vector2 vector2localVariable = new Vector2(1, 2);           // Vector 2 létrehozása, mint lokális változó
        Vector3 vector3localVariable = new Vector3(1, 2, 3);        // Vector 3 létrehozása, mint lokális változó

    }
}
