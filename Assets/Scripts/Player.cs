using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.5f;
    public Rigidbody2D player;
    Vector2 move;
    public Animator animator;
    private Inventory inventory;
    // Update is called once per frame
    private void Awake()
    {
        inventory = new Inventory();
    }
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", move.x);
        animator.SetFloat("Vertical", move.y);
        animator.SetFloat("Speed", move.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        player.MovePosition(player.position + move * speed * Time.fixedDeltaTime);
    }
}
