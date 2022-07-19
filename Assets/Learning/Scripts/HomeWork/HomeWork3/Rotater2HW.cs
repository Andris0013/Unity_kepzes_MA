


using UnityEngine;

public class Rotater2HW : MonoBehaviour
{
    
    [SerializeField] float angularSpeed;
    [SerializeField] Vector3 axis;

    float angle;

    void Update()
    {
        // angle += angularSpeed * Time.deltaTime;
        // transform.rotation = Quaternion.AngleAxis(angle, axis);

        transform.Rotate(axis, angularSpeed * Time.deltaTime);
    }
}
