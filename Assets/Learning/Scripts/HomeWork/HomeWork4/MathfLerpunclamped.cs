
// LerpUnClamped:  a + (b - a) * t

using UnityEngine;

class MathfLerpunclamped : MonoBehaviour
{
    

    float LerpUnclamped(float a, float b, float t)
    {
       // float x = a + (b - a) * t;

        return a + (b - a) * t;
    }

}
