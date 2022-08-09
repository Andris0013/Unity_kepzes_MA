using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ListPractice2 : MonoBehaviour
{
    [SerializeField] List<Transform> transforms;
    [SerializeField] Transform closest;

    private void Update()
    {
        closest = FindClosest(transforms);
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

    private void OnDrawGizmos()
    {
        if (closest != null)
            Gizmos.DrawLine(closest.position, transform.position);
    }
}
