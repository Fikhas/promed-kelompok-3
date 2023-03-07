using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float horizontal;
    float vertical;
    private Rigidbody2D body;
    [SerializeField] private float runSpeed;

    // private float moveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.A))
        // {
        //     transform.Translate(Vector2.left);
        // }
        // if (Input.GetKeyDown(KeyCode.D))
        // {
        //     transform.Translate(Vector2.right);
        // }
        // if (Input.GetKeyDown(KeyCode.S))
        // {
        //     transform.Translate(Vector2.down);
        // }
        // if (Input.GetKeyDown(KeyCode.W))
        // {
        //     transform.Translate(Vector2.up);
        // }
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
