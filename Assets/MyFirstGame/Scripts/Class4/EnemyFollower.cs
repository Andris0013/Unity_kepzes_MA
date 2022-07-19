
// Írjatok komponenst, ami egy beállítható vector 3 pont felé mozgatja a game objectet beállítható fix sebességgel.

using UnityEngine;

public class EnemyFollower : MonoBehaviour
{

    // [SerializeField] float speed;
    [SerializeField] AnimationCurve speedOverDistance;
    [SerializeField] Transform player;

    [SerializeField, Range(0, 100)] float startStamina;
    [SerializeField, Range(0, 100)] float regenerateStamina;
    float stamina;
    bool regenerating = false;


    private void Start()
    {
        stamina = startStamina;
    }

    void Update()
    {
        if (regenerating)
            Regenerate();

        else
            Move();
    }

    void Regenerate()
    {
        stamina += Time.deltaTime * regenerateStamina;
        if (stamina >= startStamina)
        {
            regenerating = false;
            stamina = startStamina;
        }
    }

    void Move()
    {
        float distance = Vector3.Distance(player.position, transform.position);     // or = (   player.position - transform.position).magnitude
        float speed = speedOverDistance.Evaluate(distance);

        Vector3 startPos = transform.position;
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        Vector3 endPos = transform.position;

        float step = (endPos - startPos).magnitude;

        Vector3 vectorPointToTarget = player.position - transform.position;
        transform.rotation = Quaternion.LookRotation(vectorPointToTarget);

        stamina -= step;

        if (stamina <= 0)
        {
            regenerating = true;
            stamina = Mathf.Max(0, stamina);
        }
    }
}
