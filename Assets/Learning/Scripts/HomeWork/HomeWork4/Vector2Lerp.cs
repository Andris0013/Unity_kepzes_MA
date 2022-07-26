using UnityEngine;

class Vector2Lerp : MonoBehaviour
{

    Vector2 VectorLerp(Vector2 a, Vector2 b, float t)
    {

        float min = Mathf.Min(a.x, b.x);
        float max = Mathf.Max(a.x, b.x);
        
        float min2 = Mathf.Max(a.y, b.y);
        float max2 = Mathf.Max(a.y, b.y);

        float x = a.x + (b.x - a.x) * t;
        float y = a.y + (b.y - a.y) * t;

        Vector2 result = new Vector2(Mathf.Clamp(x, min, max), Mathf.Clamp(y, min2, max2));

        return result;
    }

}
