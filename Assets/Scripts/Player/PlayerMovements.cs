using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] public float speed;
    [HideInInspector] private Rigidbody2D rb;
    [HideInInspector] private Animator anim;
    [HideInInspector] private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        Animation();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }


    private void Animation()
    {
        anim.SetFloat("SpeedH", movement.x);
        anim.SetFloat("SpeedV", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);
    }
}
