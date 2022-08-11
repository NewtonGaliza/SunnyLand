using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float JumpForce;

    public bool isJumping;
    private float inputAxis;
    private Rigidbody2D rig;

    private Vector3 _movement;

    public Vector3 movement
    {
        get { return _movement; }
        set { _movement = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
       rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        Jump();
    }

    void Move()
    {
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        _movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        transform.position += _movement * Time.deltaTime * Speed; 

        inputAxis = Input.GetAxis("Horizontal");

        if(inputAxis > 0)
        {
            transform.eulerAngles = new Vector2(0f, 0f);
        }        

        if(inputAxis < 0)
        {
            transform.eulerAngles = new Vector2(0f,180);
        }


    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && !isJumping)
        {
            rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            isJumping = false;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isJumping = true;
    }
}
