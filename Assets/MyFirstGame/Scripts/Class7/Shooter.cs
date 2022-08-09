using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] KeyCode shootKey;
    [SerializeField] Transform startPos;
    [SerializeField] GameObject bullet;
    [SerializeField] float speed;

    void Update()
    {
        if(Input.GetKeyDown(shootKey))
        {
            GameObject newbullet = Instantiate(bullet);

            newbullet.transform.position = startPos.position;

            Rigidbody rb = newbullet.GetComponent<Rigidbody>();
            rb.velocity = startPos.forward * speed;

            //shoot();
        }
    }


    // shoot();
}
