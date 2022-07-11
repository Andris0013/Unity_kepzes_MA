
// Írjatok komponenst, ami egy beállítható vector 3 pont felé mozgatja a game objectet beállítható fix sebességgel.

using UnityEngine;

public class PositionFollower : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] Vector3 fixedDirection;

    void Update()
    {
        Vector3 velocity = (fixedDirection - transform.position).normalized;
        transform.position += speed * velocity * Time.deltaTime;
    }
}
