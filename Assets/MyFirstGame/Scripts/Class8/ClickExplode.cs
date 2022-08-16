using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickExplode : MonoBehaviour
{
    [SerializeField] float explosionForce = 500;
    [SerializeField] float explosionRadious = 10;
    [SerializeField] float upwardModifier = 0.5f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 screenPoint = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(screenPoint);

            // Ray ray2 = new Ray(transform.position, transform.forward);

            bool isHit = Physics.Raycast(ray, out RaycastHit hit);
            if (isHit)
            {
                foreach (Rigidbody rb in FindObjectsOfType<Rigidbody>())
                {
                    rb.AddExplosionForce(explosionForce, hit.point, explosionRadious,upwardModifier);
                }
                
            }
        }
    }
}
