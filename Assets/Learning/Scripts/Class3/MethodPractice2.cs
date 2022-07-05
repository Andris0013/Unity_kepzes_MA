using UnityEngine;

public class MethodPractice2 : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;
    [SerializeField] float min;


    void OnValidate()
    { }
    float Minimum(float n1, float n2)
    {
        float min;

        if (n1 < n2)
            min = n1;

        else
            min = n2;

        return min;
    }

    float MinimumV2(float n1, float n2)
    {
        if (n1 < n2)
            return n1;

        else
            return n2;
    }

  //  min = Minimum(a, b);


}
