using UnityEngine;

public class ArrayPractice2 : MonoBehaviour
{
    [SerializeField] int length;
    [SerializeField] int[] intArray;


    void OnValidate()
    {
        intArray = new int[length];

        if(length >=1)
            intArray[0] = 0;
       
        if(length >=2)
            intArray[1] = 1;

        for (int i = 2; i < intArray.Length; i++)
        {
            intArray[i] = intArray[i-1] + intArray[i-2];
        }
    }
}
