using System;
using UnityEngine.InputSystem;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public InputAction playerControls;
    public float flapStrength;
    public GameLogic logic;
    private CircleCollider2D collider;
    
    void OnEnable()
    {
        playerControls.Enable();
    }
    
    void OnDisable()
    {
        playerControls.Disable();
    }

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
        collider = GameObject.FindGameObjectWithTag("Player").GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControls.triggered && !logic.isDead) {
            rb.linearVelocity = Vector2.up * flapStrength;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.Die();
        collider.enabled = false;
        collider.isTrigger = true;
    }
}
