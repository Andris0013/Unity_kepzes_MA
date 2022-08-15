using System;
using UnityEngine;

public class HomeWorkH4 : MonoBehaviour
{
    [SerializeField] float[] values = Array.Empty<float>();         // Why not just float[] values; ?
    [Space]
    [SerializeField] float minimum;
    [SerializeField] float maximum;

    private void OnValidate()
    {
        minimum = Min(values);
        maximum = Max(values);

    }

    float Min(float[] values)
    {
        if (values == null || values.Length == 0)
            return 0;

        minimum = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] < minimum)
                minimum = values[i];
        }
        return minimum;
    }

    float Max(float[] values)
    {
        if (values == null || values.Length == 0)
            return 0;

        maximum = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if(values[i] > maximum)
                maximum = values[i];
        }
        return maximum;

    }
}
