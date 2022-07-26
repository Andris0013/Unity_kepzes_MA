using UnityEngine;

class MathfLerp : MonoBehaviour
{

    float MathLerp(float a, float b, float t)
    {
        float x = a + (b - a) *t;

        float min = Mathf.Min(a, b);
        float max = Mathf.Max(a, b);            // a > b ? a : b;

        return Mathf.Clamp(x, min, max);   
    }

}
