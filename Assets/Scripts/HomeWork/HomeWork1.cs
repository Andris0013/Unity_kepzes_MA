
// �rj programot, ami egy num bemenetben megadott sz�mr�l eld�nti, majd egy string t�p�s� kimenetben megadja, hogy p�ros-e vagy p�ratlan.

using UnityEngine;

public class HomeWork1 : MonoBehaviour
{
    [SerializeField] int num;

    void OnValidate()
    {
        if (num != 0)
        {
            if (num % 2 == 0)
                Debug.Log("P�ros");

            else
                Debug.Log("P�ratlan");

        }

    }
}
