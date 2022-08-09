// Egy beállított pont felé mozgatja a game objectet

using System.Collections.Generic;
using UnityEngine;

public class EnemyFollower : MonoBehaviour
{

    // [SerializeField] float speed;
    [SerializeField] AnimationCurve speedOverDistance;
    [SerializeField] List<Transform> followables;

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
        // if (followables == null || followables.Count == 0);
            
        
        Transform followable = FindClosest(followables);



        float distance = Vector3.Distance(followable.position, transform.position);     // or = (   player.position - transform.position).magnitude
        float speed = speedOverDistance.Evaluate(distance);

        Vector3 startPos = transform.position;
        transform.position = Vector3.MoveTowards(transform.position, followable.position, speed * Time.deltaTime);
        Vector3 endPos = transform.position;

        float step = (endPos - startPos).magnitude;

        Vector3 vectorPointToTarget = followable.position - transform.position;
        if (vectorPointToTarget != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(vectorPointToTarget);

        stamina -= step;

        if (stamina <= 0)
        {
            regenerating = true;
            stamina = Mathf.Max(0, stamina);
        }
    }
    private Transform FindClosest(List<Transform> transforms)
    {
        if (transforms == null || transforms.Count == 0)
            return null;

        Vector3 selfPos = transform.position;

        Transform closest = transforms[0];

        float closestDistance = Vector3.Distance(selfPos, transforms[0].position);

        foreach (Transform item in transforms)
        {
            float distance = Vector3.Distance(selfPos, item.position);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closest = item;
            }
        }
        return closest;
    }

}
