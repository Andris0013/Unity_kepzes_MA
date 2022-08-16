using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMover : MonoBehaviour
{
    [SerializeField] float maxSpeed = 3;
    [SerializeField] float acceleration = 1;

    Vector3 velocity;

    void Update()
    {
        transform.position += velocity * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(velocity);
    }

    void FixedUpdate()
    {
        Transform followable = FindClosestCollectable();
        Vector3 selfPos = transform.position;
        Vector3 targetPos = followable.position;
        targetPos.y = selfPos.y;

        Vector3 direction = targetPos - selfPos;
        direction.Normalize();
        velocity = Vector3.MoveTowards(velocity, direction * maxSpeed, Time.fixedDeltaTime * acceleration);

    }

    Transform FindClosestCollectable()
    {
        Collectable[] allCollectables = FindObjectsOfType<Collectable>();
        List<Transform> transformList = new List<Transform>();
        foreach (Collectable item in allCollectables)
        {
            transformList.Add(item.transform);
        }

        return TransformHelper.FindClosest(transformList, transform);
    }
}
