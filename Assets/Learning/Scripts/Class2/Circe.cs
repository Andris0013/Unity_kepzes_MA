using UnityEngine;

public class Circe : MonoBehaviour
{
    [Header("Input data")]
    [SerializeField] float radius;          //sug�r
    [Space]
    [Header("Output data")]
    [SerializeField] float area;            //ker�let
    [SerializeField] float circumference;   //ter�let

    void OnValidate()                       //So it starts the calculation when we type in the input data!
    {
        area = radius * radius + Mathf.PI;          //Mathf command helps to get the mathematic data. In this case the precise value of PI.
        circumference = 2 * radius * Mathf.PI;
    }

}
