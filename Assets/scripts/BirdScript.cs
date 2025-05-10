using System;
using UnityEngine.InputSystem;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public InputAction playerControls;
    public float flapStrength;
    public GameLogic logic;
    private Camera _camera;
    
    void OnEnable()
    {
        playerControls.Enable();
    }

    void Awake()
    {
        _camera = Camera.main;
    }
    
    void OnDisable()
    {
        playerControls.Disable();
    }

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControls.triggered && !logic.isDead) {
            rb.linearVelocity = Vector2.up * flapStrength;
        }
    
        Vector3 viewPos = _camera.WorldToViewportPoint(transform.position);
        if (viewPos.y < 0f || viewPos.y > 1f)
        {
            logic.Die();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.Die();
    }
}
