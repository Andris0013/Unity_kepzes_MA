using UnityEngine;

public class Vector2Lerp : MonoBehaviour
{

    Vector2 VectorLerp(Vector2 a, Vector2 b, float t)
    {
        float x = a.x + (b.x - a.x) * Mathf.Clamp01(t);
        float y = a.y + (b.y - a.y) * Mathf.Clamp01(t);

        Vector2 result = new Vector2(x, y); 

        return result;
    }

}
