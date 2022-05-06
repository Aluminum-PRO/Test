using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _Joystick;
    [SerializeField] private Animator _animator;

    [SerializeField] private float _move_Spead;

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_Joystick.Horizontal * _move_Spead, _rigidbody.velocity.y, _Joystick.Vertical * _move_Spead);

        if (_Joystick.Horizontal != 0 || _Joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);  
        }
    }
}
