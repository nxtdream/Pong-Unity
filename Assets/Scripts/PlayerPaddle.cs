using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    private void Update() {
        if (Input.GetAxis("Vertical") > 0){
            _direction = Vector2.up;
        } else if (Input.GetAxis("Vertical") < 0){
            _direction = Vector2.down;
        } else {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate() {
        if (_direction.sqrMagnitude != 0){
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
}
