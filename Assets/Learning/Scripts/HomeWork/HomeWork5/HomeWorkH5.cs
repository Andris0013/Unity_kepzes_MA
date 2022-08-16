using System;
using UnityEngine;

public class HomeWorkH5 : MonoBehaviour
{
    [SerializeField] int[] values = Array.Empty<int>();

    private void Start()
    {
        ChangeTheOrder(values);
    }

    void ChangeTheOrder(int[] array)
    {
        if (array == null || array.Length == 0)
            return;
        
        for (int i = 0; i < array.Length / 2; i++)
        {
            int i2 = array.Length - 1 - i;                      // -1 'cause the value[i] index starts with 0 so contains one more item than the highest index number
            
            int x = array[i];
            
            array[i] = array[i2];
            array[i2] = x;
        }
    }
}
