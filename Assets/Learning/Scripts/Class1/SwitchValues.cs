using UnityEngine;

public class SwitchValues : MonoBehaviour
{
    [SerializeField] float num1;
    [SerializeField] float num2;

    void Start()
    {
        float t = num1;
        num1 = num2;
        num2 = t;
    }
}
