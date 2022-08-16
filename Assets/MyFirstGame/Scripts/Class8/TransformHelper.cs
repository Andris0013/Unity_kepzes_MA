using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformHelper
{
    static public Transform FindClosest(List<Transform> transforms, Transform transform)        // static so we can access it from anywhere
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
