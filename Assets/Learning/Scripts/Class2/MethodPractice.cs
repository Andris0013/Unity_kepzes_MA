using UnityEngine;

public class MethodPractice : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;

    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float abs;
    [SerializeField] float power;

    void OnValidate()
    {
        min = Mathf.Min(a, b);
        max = Mathf.Max(a, b);
        abs = Mathf.Abs(a);
        abs = Mathf.Abs(b);
        power = Mathf.Pow(a, b);        // A a B-ediken! (a^b)
    }
}
