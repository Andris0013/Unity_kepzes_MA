
// Írj programot, ami egy num bemenetben megadott számról eldönti, majd egy string típúsú kimenetben megadja, hogy páros-e vagy páratlan.

using UnityEngine;

public class HomeWork1 : MonoBehaviour
{
    [SerializeField] int num;

    void OnValidate()
    {
        if (num != 0)
        {
            if (num % 2 == 0)
                Debug.Log("Páros");

            else
                Debug.Log("Páratlan");

        }

    }
}
