using UnityEngine;

public class PathMover : MonoBehaviour
{
    [SerializeField] Transform p1;
    [SerializeField] Transform p2;
    [SerializeField] float speed;

    bool directionPositive;

    void Update()
    {
        Vector3 target = directionPositive ? p2.position : p1.position;

        Vector3 directionVector = target- transform.position;
        float distance = directionVector.magnitude;

        float stepLength = speed * Time.deltaTime;

        Vector3 displacement = directionVector.normalized * stepLength;
        transform.position += displacement;

        if (distance <= stepLength)
            directionPositive = !directionPositive;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(p1.position, 0.25F);
        Gizmos.DrawWireSphere(p2.position, 0.25F);
        Gizmos.DrawLine(p1.position, p2.position);
    }
}