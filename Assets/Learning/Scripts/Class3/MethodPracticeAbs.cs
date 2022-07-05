using UnityEngine;

public class MethodPracticeAbs : MonoBehaviour
{


    void OnValidate()
    { }
    float Abs(float a)
        {
            if (a < 0)
                return -a;
            else
                return a;
        }
    

}
