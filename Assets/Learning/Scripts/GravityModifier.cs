using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityModifier : MonoBehaviour
{
    [SerializeField] Vector3 force;
    
    List<Rigidbody> rigidbodies = new List<Rigidbody>();



    private void FixedUpdate()
    {
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.AddForce(force, ForceMode.Acceleration);         //enum variable!!
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
            rigidbodies.Add(rb);
    }

    void OnTriggerExit(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
            rigidbodies.Remove(rb);

    }


}
