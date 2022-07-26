using UnityEngine;

public class AutoRotater : MonoBehaviour
{

    [SerializeField] float angularspeed;

    void Update()
    {
        transform.Rotate(Vector3.up, angularspeed * Time.deltaTime,Space.World);
    }

}
