using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool isGrounded;
    public Transform groundCheck;
    //make a ceiling check for holding jump
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;
    private bool hasExtraJump;

    private Animator anim;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //GetAxisRaw for snappier movement
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        //if (moveInput > 0)
        if (mousePos.x > transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        //else if (moveInput < 0)
        else if (mousePos.x < transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (isGrounded == true && Input.GetKeyDown(KeyCode.W))
        {
            isJumping = true;
            hasExtraJump = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (NewAbility.hasBoots && !isGrounded && hasExtraJump && Input.GetKeyDown(KeyCode.W))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
            hasExtraJump = false;
        }

        if (Input.GetKey(KeyCode.W) && isJumping)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }

            else
            {
                isJumping = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            isJumping = false;
        }

        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }

        else if (moveInput > 0 || moveInput < 0)
        {
            anim.SetBool("isRunning", true);
        }
    }

    //void OnCollisionEnter2D(Collision2D other)
    //{
    //    //if (other.gameObject.tag == "Locked Door" && Key.hasKey)
    //    //{
    //    //    Key.hasKey = false;
    //    //    Debug.Log("Door unlocked");
    //    //    //Destroy(Key.lockedDoor);
    //    //}

    //    if (other.gameObject.CompareTag("Moving Platform"))
    //    {
    //        Debug.Log("First check");
    //        /*player.*/transform.parent = other.gameObject.transform;
    //        Debug.Log("Second check");
    //    }
    //}

    //private void OnCollisionExit2D(Collision2D other)
    //{
    //    if (other.gameObject.CompareTag("Moving Platform"))
    //    {
    //        /*player.*/transform.parent = null;
    //    }
    //}
}
