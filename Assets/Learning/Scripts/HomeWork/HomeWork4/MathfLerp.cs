using UnityEngine;

public class MathfLerp : MonoBehaviour
{

    float MathLerp(float a, float b, float t)
    {
        float x = a + (b - a) * Mathf.Clamp01(t);   

        return x;   
    }

}
