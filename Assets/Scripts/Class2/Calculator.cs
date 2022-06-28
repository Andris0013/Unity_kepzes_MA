using UnityEngine;
public class Calculator : MonoBehaviour
{
    [Header ("Input numbers")]
    [SerializeField] float num1;
    [SerializeField] float num2;
    [Space]
    [Header ("Output numbers")]
    [SerializeField] float summa;
    [SerializeField] float difference;
    [SerializeField] float product;
    [SerializeField] float rate;

    void OnValidate()
    {
        summa = num1 + num2;
        difference = num1 - num2;
        product = num1 * num2;
        rate = num1 / num2;
    }

}