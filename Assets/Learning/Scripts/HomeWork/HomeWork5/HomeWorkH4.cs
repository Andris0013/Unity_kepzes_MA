using System;
using UnityEngine;

public class HomeWorkH4 : MonoBehaviour
{
    [SerializeField] float[] values = Array.Empty<float>();
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

        float minimum = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            float n = values[i];
            if (n < minimum)
                minimum = n;
        }
        return minimum;
    }

    float Max(float[] values)
    {
        if (values == null || values.Length == 0)
            return 0;

        float maximum = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            float n = values[i];
            if (n > maximum)
                maximum = n;
        }
        return maximum;

    }
}
