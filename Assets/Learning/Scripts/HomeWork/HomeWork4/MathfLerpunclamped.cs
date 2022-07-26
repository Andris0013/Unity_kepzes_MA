
// LerpUnClamped:  a + (b - a) * t

using UnityEngine;

public class MathfLerpunclamped : MonoBehaviour
{
    

    float LerpUnclamped(float a, float b, float t)
    {
        float x = a + (b - a) * t;

        return x;
    }

}
