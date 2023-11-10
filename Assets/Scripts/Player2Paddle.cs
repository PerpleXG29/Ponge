using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Paddle : Paddle
{
    private Vector2 direction;

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {

            direction = Vector2.up;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {

            direction = Vector2.down;
        }

        else
        {
            direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(direction * speed);

        }
    }
    public void resetPlayerPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);

    }
}
