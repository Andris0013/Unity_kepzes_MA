
// Matek függvények írása, függvénygyakorlás

using UnityEngine;

public class MyMath : MonoBehaviour
{

    [SerializeField] float a;
    [SerializeField] float b;
    [SerializeField] float minLimit;
    [SerializeField] float maxLimit;
    [SerializeField] float value;
    [Space]

    [SerializeField] float minOfab;
    [SerializeField] float maxOfab;
    [Space]

    [SerializeField] float clampBetweenMinLimitAndMaxlimit;
    [SerializeField] float clampBetween0And1;
    [Space]

    [SerializeField] float absValue;
    [SerializeField] float signValue;
    [Space]

    [SerializeField] float floored;
    [SerializeField] float ceiled;
    [SerializeField] float rounded;

    private void OnValidate()
    {
        minOfab = Minimum(a, b);
        maxOfab = Maximum(a, b);
        clampBetweenMinLimitAndMaxlimit = Clamp(minLimit, maxLimit, value);
        clampBetween0And1 = Clamp01(value);
        absValue = Abs(value);
        signValue = Sign(value);
        floored = Floor(value);
        ceiled = Ceil(value);
        rounded = Round(value);
    }


    float Minimum(float n1, float n2)                                    // Minimum
    {
        float min;

        if (n1 < n2)
            min = n1;

        else
            min = n2;

        return min;
    }

    float Maximum(float n1, float n2)                                   // Maximum
    {
        if (n1 < n2)
            return n2;
        else
            return n1;
    }

    float Clamp(float minLimit, float maxLimit, float value)            // Between minLimit and maxLimit
    {
        return Minimum(Maximum(minLimit, value), maxLimit);
    }

    float Clamp01(float value)                                          // Between 0 and 1
    {
        return Minimum(Maximum(0, value), 1);
    }

    float Abs(float value)                                              // Absolut value of value
    {
        return value > 0 ? value : -value;
    }

    float Sign(float value)                                             // Returns 1 if value is >=0 and -1 if value is < 0
    {
        return value >= 0 ? 1 : -1;
    }

    float Floor(float value)                                            // Returns the smallest integer, for example 3 if 3,5 or 4 if 4,9 and 3 if 3 (why 1F and not 1?)
    {
        return value - (value % 1F);
    }

    float Ceil(float value)                                             // Returns the greatest integer, for example 4 if 3,5 or 5 if 4,9 and 3 if 3
    {
        float remains = value % 1F;
        return remains == 0 ? value : value + 1 - remains;
    }

    float Round(float value)                                            // Returns the mathematicly correct rounded value of value
    {
        float remains = value % 1F;
        return remains <= 0.5 ? Floor(value) : Ceil(value);
    }
}
