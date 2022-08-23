using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMover : MonoBehaviour
{
    [SerializeField] float maxSpeed = 3;
    [SerializeField] float acceleration = 1;
    [SerializeField] new Rigidbody rigidbody;

    void OnValidate()
    {
        if (rigidbody == null)
            rigidbody = GetComponent<Rigidbody>();

    }



    void Update()
    {
        transform.rotation = Quaternion.LookRotation(rigidbody.velocity);
    }

    void FixedUpdate()
    {
        Transform followable = FindClosestCollectable();
        Vector3 selfPos = transform.position;
        Vector3 targetPos = followable.position;
        targetPos.y = selfPos.y;

        Vector3 direction = targetPos - selfPos;
        direction.Normalize();
        rigidbody.velocity = Vector3.MoveTowards(rigidbody.velocity, direction * maxSpeed, Time.fixedDeltaTime * acceleration);

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
