using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum gameState
{
    isPlaying,
    GameOver,
    Ready,
}

public class HomeWorkFlappyBird : MonoBehaviour
{
    gameState state = gameState.Ready;

    [SerializeField] float acceleration = 9.87f;
    [SerializeField] float jumpVelocity;
    [SerializeField] float minHeight;
    [SerializeField] float maxHeight;

    float speed = 0;

    void FixedUpdate()
    {
        if (state == gameState.isPlaying)
            speed -= acceleration * Time.fixedDeltaTime;
    }

    void Update()
    {
        if (state == gameState.GameOver)
            return;

        if (Input.anyKeyDown)
        {
            state = gameState.isPlaying;
            speed += jumpVelocity;
        }

        if (state == gameState.isPlaying)
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;

        float y = transform.position.y;

        if (y < minHeight || y > maxHeight)
        {
            StartCoroutine(GameOver());
        }

    }

    IEnumerator GameOver()
    {
        state = gameState.GameOver;
        yield return new WaitForSeconds(2);
        state = gameState.Ready;

        Vector3 p = transform.position;
        p.y = (minHeight + maxHeight) / 2;
        transform.position = p;

        speed = 0;
    }
}
