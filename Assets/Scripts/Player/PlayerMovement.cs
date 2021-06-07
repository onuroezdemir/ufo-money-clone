using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [Space]
    [SerializeField] private float speed = 2;

    private Vector3 startMousePos = Vector3.zero;
    private Vector3 deltaMousePos = Vector3.zero;
    private Vector3 direction = Vector3.zero;

    private Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startMousePos = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            deltaMousePos =Input.mousePosition - startMousePos;
            direction = new Vector3(deltaMousePos.x, 0f, deltaMousePos.y);

            body.velocity = direction.normalized * speed;
        }
        else
        {
            body.velocity = Vector3.zero;
        }
    }
}
