using UnityEngine;

public class PathMover : MonoBehaviour
{
    [SerializeField] Transform p1;
    [SerializeField] Transform p2;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 velocity = (p2.position - p1.position).normalized;
        transform.position += speed * Time.deltaTime * velocity;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(p1.position, 0.25F);
        Gizmos.DrawWireSphere(p2.position, 0.25F);
        Gizmos.DrawLine(p1.position, p2.position);
    }
}